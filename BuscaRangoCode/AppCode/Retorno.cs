using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaRangoCode
{
    public class Retorno
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public Retorno()
        {
            this.Sucesso = true;
        }

        #region Atributos
        private bool sucesso;
        public bool Sucesso
        {
            get { return sucesso; }
            set { sucesso = value; }
        }

        private object retObj;
        public object RetObj
        {
            get { return retObj; }
            set { retObj = value; }
        }

        private string msgErro;
        public string MsgErro
        {
            get { return msgErro; }
            set { msgErro = value; }
        }
        #endregion
    }
}
