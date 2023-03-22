namespace Calculadora.ConsolesApp
{

    internal class Program
    {
        static double pNumero1, pNumero2;
        static double resultado = 0;
        static List<string> Contas = new List<string>();
        static void Main(string[] args)
        {

            const string SAIR = "S";
            string resposta = "";
            double resultado = 0;

            Console.WriteLine("Calculdadora diferenciada\n------------------");
            while (resposta.ToUpper() != SAIR)
            {
                string Operacao = MenuIncial();

                if (Operacao != "+" && Operacao != "-" && Operacao != "*" && Operacao != "/" && Operacao != "h" && Operacao != "H")
                {
                    MensagemDeErro("Operação Inválida...");
                    continue;
                }

                if (Operacao.ToUpper() == "H")
                {
                    if (Contas.Count() == 0)
                    {
                        MensagemDeErro("Sem Histórico");
                        continue;
                    }
                    else
                    {
                        GeraHistorico(Contas);
                        continue;
                    }

                }

                PegaOsNumeros();
                EscreveHistorico(out resposta, out resultado, Operacao);
                if (resposta.ToUpper() == "S")
                {
                    GeraHistorico(Contas);
                }
            }
            Console.ReadLine();
        }



        private static void EscreveHistorico(out string resposta, out double resultado, string Operacao)
        {
            resultado = Historico(Operacao);
            Console.WriteLine("Sair S/N");
            resposta = Console.ReadLine();
        }

        private static double Historico(string Operacao)
        {
            resultado = FazerContas(resultado, Operacao);
            string conta = Convert.ToString(pNumero1) + " " + Operacao + " " + Convert.ToString(pNumero2) + " = " + Convert.ToString(Math.Round(resultado, 2));
            Contas.Add(conta);           
            return resultado;
        }

        private static double FazerContas(double resultado, string Operacao)
        {
            if (Operacao == "+")
            {
                resultado = Soma();
            }
            if (Operacao == "-")
            {
                resultado = Subtracao();
            }
            if (Operacao == "*")
            {
                resultado = Multiplicacao();
            }
            if (Operacao == "/")
            {
                resultado = Divisao();
            }

            return resultado;
        }

        static double Divisao()
        {
            double resultado;
            while (pNumero2 == 0)
            {
                MensagemDeErro("O número deve ser diferente de 0...");
                pNumero2 = Convert.ToDouble(Console.ReadLine());

            }
            resultado = pNumero1 / pNumero2;
            Console.WriteLine("Resultado: " + resultado);
            return resultado;
        }

         static double Multiplicacao()
        {
            double resultado = pNumero1 * pNumero2;
            Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
            return resultado;
        }

         static double Subtracao()
        {
            double resultado = pNumero1 - pNumero2;
            Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
            return resultado;
        }

         static double Soma()
        {
            double resultado = pNumero1 + pNumero2;
            Console.WriteLine("Resultado: " + Math.Round(resultado, 2));
            return resultado;
        }

         static void PegaOsNumeros()
        {
            Console.WriteLine("Digite o primeiro Número:\n");
            pNumero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo Número:\n");
            pNumero2 = Convert.ToDouble(Console.ReadLine());
        }

         static void GeraHistorico(List<string> Contas)
        {
            Console.WriteLine("Histórico: ");
            foreach (var item in Contas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Número de operaçoes: " + Contas.Count());
            Console.ReadLine();
        }

        static string MenuIncial()
        {
            Console.WriteLine("------------------");

            Console.WriteLine("operações: + | - | * | / | H para Histórico | ");
            string Operacao = Console.ReadLine();
            return Operacao;
        }
        static void MensagemDeErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}