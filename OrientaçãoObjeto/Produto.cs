using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientaçãoObjeto
{
    /*Ordem recomendada para implemntação dos membros
     
     * Atributos Privados
     * Propriedades autoimplementadas
     * Construtores
     * Propriedades Customizadas
     * Outros métodos da classe
     
     Essa ordem está sendo seguida nessa classe Produto*/
    internal class Produto
    {
        //Como o nome tem uma propriedade particular que no caso é a condição "if", vamos manter com o underline normal
        private string _nome;

        //Isso é o auto properties, uma maneira mais facil de declarar gets e sets
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            //O valor para atualizar o nome no metodo set é o value
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + "\nValor: $" + Preco.ToString("F2") + "\nQuantidade: " + Quantidade 
                + " unidades, \nTotal: $" + ValorEmEstoque().ToString("F2");
        }
    }
}
