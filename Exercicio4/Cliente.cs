using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Cliente
    {
        private int id;
        private string name;
        private string cpf;
        private string endereco;
        private double renda;

        public Cliente(int id, string name, string cpf, string endereco, double renda)
        {
            this.id = id;
            this.name = name;
            this.cpf = cpf;
            this.endereco = endereco;
            this.renda = renda;
        }

        public Cliente() { }

        public int Id 
        { 
            get { return id; } 
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { this.endereco = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set
            {
                this.cpf = value;
            }
        }

        public double Renda
        {
            get { return renda; }
            set
            {
                this.renda = value;
            }
        }

    }
}
