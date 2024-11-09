namespace ConsolePegadinhas
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Bem-vindo desenvolvedor!");
            Console.WriteLine("Tente encontrar e corrigir os problemas no código.");

            //1° desafio, O famoso Loop Infinito
            LoopInfinito();

            //2° desafio, Conversao incorreta
            ConversaoIncorreta();

            //2° desafio, Calculo errado na média
            CalcularMedia();

            Console.WriteLine("Fim do programa. Boa sorte corrigindo!");
        }

        static void LoopInfinito()
        {
            Console.WriteLine("Ajuste a logica para sair do loop inifito");

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Loop Infinito: {i}");
            }
        }

        static void ConversaoIncorreta()
        {
            //Converta o double para outro tipo.
            //Valor esperado 123.456

            double valor = 123.456;

            var valorConvertido = (int)valor;

            if (valorConvertido != valor)
            {
                Console.WriteLine("Problema na conversão. Tente novamente");
            }
            else
            {
                Console.WriteLine("Parabens, você conseguiu");
            }
        }

        static void CalcularMedia()
        {
            Console.WriteLine("Problema: Calcule a média correta de três números.");

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int media = (num1 + num2 + num3) / 5;

            if (media == 20)
                Console.WriteLine("Parabens, você conseguiu");

            else
                Console.WriteLine("tenta novamente");
        }
    }
}
