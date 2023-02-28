namespace Exercicio_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco conta;

            //Lendo os dados iniciais
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Banco(numero, titular, depositoInicial);
            }
            else
            {
                //Esse construtor vai jogar o saldo zero na minha conta
                conta = new Banco(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            //"quantia" está sem a palavra double pois ela j´´a está declarada acima
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
        }
    }
}