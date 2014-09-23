using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaRangoCode
{
    public class EstabelecimentoService
    {
        /// <summary>
        /// Insere um objeto na base de dados
        /// </summary>
        /// <param name="obj">Objeto a ser inserido</param>
        /// <returns>Objeto "Retorno" (Sucesso ou falha da operação)</returns>
        public static Retorno Insert(Estabelecimento obj)
        {
            // Cria objeto de retorno
            Retorno ret = new Retorno();

            // Usando o contexto ER_Entities, execute o bloco de código
            using (var ctx = new ER_Entities())
            {
                try
                {
                    // Adiciona e salva
                    ctx.Estabelecimentos.Add(obj);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }

            // Retorna o objeto de retorno
            return ret;
        }

        /// <summary>
        /// Faz o Update de um objeto
        /// </summary>
        /// <param name="updateObj">Objeto com as novas propriedades</param>
        /// <param name="id">Id do objeto a ser editado</param>
        /// <returns>Objeto "Retorno" (Sucesso ou falha da operação)</returns>
        public static Retorno Update(Estabelecimento updateObj, int id)
        {
            // Cria objeto de retorno
            Retorno ret = new Retorno();

            // Usando o contexto ER_Entities, execute o bloco de código
            using (var ctx = new ER_Entities())
            {
                try
                {
                    // Recebe o primeiro objeto da lista de Entidades
                    Estabelecimento obj = ctx.Estabelecimentos.FirstOrDefault(x => x.Id == id);
                    // Edita os campos atuais
                    obj.Nome = updateObj.Nome;
                    obj.DescricaoCurta = updateObj.DescricaoCurta;
                    obj.Endereco = updateObj.Endereco;
                    obj.Imagem = updateObj.Imagem;
                    obj.Nota = updateObj.Nota;
                    obj.Pratos = updateObj.Pratos;
                    // Salva as mudanças feitas no contexto
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }

            // Retorna o objeto de retorno
            return ret;
        }

        /// <summary>
        /// Seleciona todos objetos respeitando os campos informados no LINQ
        /// </summary>
        /// <returns>Objeto de "Retorno" com apenas os campos necessários do banco</returns>
        public static Retorno SelectIn()
        {
            Retorno ret = new Retorno();

            using (var ctx = new ER_Entities())
            {
                try
                {

                    // var obj = from estab in ctx.Estabelecimentos
                    var teste = from p in ctx.Estabelecimentos
                                select p;


                    ret.RetObj = teste.ToList();
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }
            return ret;
        }

        /// <summary>
        /// Seleciona todos objetos
        /// </summary>
        /// <returns>Objeto de "Retorno" com todas entradas do banco</returns>
        public static Retorno SelectAll()
        {
            // Cria objeto de retorno
            Retorno ret = new Retorno();

            // Usando o contexto ER_Entities, execute o bloco de código
            using (var ctx = new ER_Entities())
            {
                try
                {
                    // Recupera todos objetos do grupo
                    var obj = ctx.Estabelecimentos;
                    ret.RetObj = obj.ToList();
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }

            // Retorna o objeto de retorno
            return ret;
        }

        /// <summary>
        /// Seleciona um objeto pelo seu ID
        /// </summary>
        /// <param name="id">ID do objeto</param>
        /// <returns>Objeto "Retorno"</returns>
        public static Retorno SelectById(int id)
        {
            // Cria objeto de retorno
            Retorno ret = new Retorno();

            // Usando o contexto ER_Entities, execute o bloco de código
            using (var ctx = new ER_Entities())
            {
                try
                {
                    // Recebe o primeiro objeto da lista de Entidades que possui a expressão especificada
                    var obj = ctx.Estabelecimentos.FirstOrDefault(x => x.Id == id);
                    ret.RetObj = obj;
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }

            // Retorna o objeto de retorno
            return ret;
        }

        /// <summary>
        /// Deleta um objeto
        /// </summary>
        /// <param name="id">ID do objeto a ser deletado</param>
        /// <returns>Objeto "Retorno" (Sucesso ou falha da operação)</returns>
        public static Retorno Delete(int id)
        {
            // Cria objeto de retorno
            Retorno ret = new Retorno();

            // Usando o contexto ER_Entities, execute o bloco de código
            using (var ctx = new ER_Entities())
            {
                try
                {
                    // Recebe o primeiro objeto da lista de Entidades que possui a expressão especificada
                    var obj = ctx.Estabelecimentos.FirstOrDefault(x => x.Id == id);
                    ctx.Estabelecimentos.Remove(obj);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    ret.Sucesso = false;
                    ret.MsgErro = ex.Message;
                }
            }

            // Retorna o objeto de retorno
            return ret;
        }
    }
}
