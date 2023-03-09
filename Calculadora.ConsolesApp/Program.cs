namespace Calculadora.ConsolesApp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            const string sair = "S";
            string resposta = "";

            double resultado = 0;

            List<string> Contas = new List<string>();
            List<double> Resultados = new List<double>();
            Console.WriteLine("Calculdadora diferenciada\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("------------------");


                console.writeline("operações: + | - | * | / |");
                string operacao = console.readline();

                if (Operacao != "+" &&  Operacao != "-" && Operacao != "*" && Operacao != "/")
                {
                    Console.WriteLine("Erro: Operação inválida");
                    continue;
                }


                

                Console.WriteLine("Digite o primeiro Número:\n");

                double pNumero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo Número:\n");

                double pNumero2 = Convert.ToDouble(Console.ReadLine());
                

                if (Operacao == "+")
                {
                    resultado = pNumero1 + pNumero2;
                    Console.WriteLine("Resultado: "+ Math.Round(resultado, 2));
                }
                if (Operacao == "-")
                {
                    resultado = pNumero1 - pNumero2;
                    Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
                }
                if (Operacao == "*")
                {
                    resultado = pNumero1 * pNumero2;
                    Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
                }
                if (Operacao == "/")
                {
                    while(pNumero2 == 0)
                    {
                        Console.WriteLine("Erro:");
                        Console.WriteLine("Digite o segundo Número Novamente:\n");

                        pNumero2 = Convert.ToDouble(Console.ReadLine());

                    }
                    resultado = pNumero1 / pNumero2;
                    Console.WriteLine("Resultado: " + resultado);
                }

                string conta  = Convert.ToString(pNumero1) + " " + Operacao + " " + Convert.ToString(pNumero2) + " = " + Convert.ToString(Math.Round(resultado,2));
                
                
                Resultados.Add(resultado);
                Contas.Add(conta);



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
            Console.WriteLine("Histórico: ");
            foreach (var item in Contas)
            {
                
              Console.WriteLine(item);
                

            }
            
            Console.WriteLine("Número de operaçoes: " + Resultados.Count());
            Console.ReadLine();
        }
    }
}