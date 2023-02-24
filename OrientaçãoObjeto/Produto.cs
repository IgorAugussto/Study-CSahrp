using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoObjeto
{
    internal class Produto
    {
        private string _nome;

        //Isso é o auto properties, uma maneira mais facil de declarar gets e sets
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + "\nValor: $" + Preco.ToString("F2") + "\nQuantidade: " + Quantidade 
                + " unidades, \nTotal: $" + ValorEmEstoque().ToString("F2");
        }

        public string Nome
        {
            get { return _nome; }
            //O valor para atualizar o nome no metodo set é o value
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}
