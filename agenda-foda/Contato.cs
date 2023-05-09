using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisinha_Matlugo
{
    internal class Contato
    {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
    
    //PROPRIEDADES (GET e SET)
    public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
    public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)

                    telefone = value;

                else
                {
                    telefone = "00000000000";
                }

            }
        }


        public Contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-98506-6969";
        }
        
        public Contato(string primeironome, string sobrenome, string telefone)
        { 
          PrimeiroNome = primeironome;
          Sobrenome = sobrenome;
          Telefone = telefone;

        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0, 1),
                Telefone.Substring(2, 4),
                Telefone.Substring(7, 3));

            return saida;

        }

    }
}
