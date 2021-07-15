using System;

namespace calculo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Esta é a loja do João, Seja Bem vindo!");
            Console.WriteLine("Siga os passos da lista, informe se deseja adicionar ao carrinho com s ou n");


            Console.WriteLine("Abacate promoção R$ 10,00");
            string item1 = Console.ReadLine();
            if (item1 == "s"){
            Console.WriteLine("Confirmado");
            }
            else {
                Console.WriteLine("Que pena");

            }

            Console.WriteLine("Melancia só R$ 50,00");
            string item2 = Console.ReadLine();
            if (item2 == "s"){
            Console.WriteLine("Confirmado");
            }
            else {
                Console.WriteLine("Que pena");

            }
            

            Console.WriteLine("Jaca R$30,00");
            string item3 = Console.ReadLine();
            if (item3 == "s"){
            Console.WriteLine("Confirmado");
            }
            else {
                Console.WriteLine("Que pena");

            }

            Console.WriteLine("Ovo de galinha R$20,00 a cartela");
            string item4 = Console.ReadLine();
            if (item4 == "s"){
            Console.WriteLine("Confirmado");
            }
            else {
                Console.WriteLine("Que pena");

            }

            Console.WriteLine("Olha o carro do abacaxi! R$10,00");
            string item5 = Console.ReadLine();
               if (item5 == "s"){
            Console.WriteLine("Confirmado");
            }
            else {
                Console.WriteLine("Que pena");

            }
            

            
        }
    }
}
