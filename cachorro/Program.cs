using System;

namespace cachorro
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Os cachorros do seu Roberto, o maioral!");
            Console.WriteLine("Olá Roberto, sei que é o maioral");
            Console.WriteLine("Por isto vamos inserir o nome de seus 5 cachorros?");
            Console.WriteLine("Por favor digite o nome do seu primeiro cachorro:");

            string cachorro1 = Console.ReadLine();
            Console.WriteLine("Seu primeiro cão chama: " + cachorro1);

            Console.WriteLine("Vamos lá, qual é o nome do segundo:");
            string cachorro2 = Console.ReadLine();
            Console.WriteLine("Seu segundo cão chama: " + cachorro2);

            Console.WriteLine("Vamos lá, qual é o nome do terceiro:");
            string cachorro3 = Console.ReadLine();
            Console.WriteLine("Seu terceiro cão chama: " + cachorro3);

            Console.WriteLine("Nossa tem mais certo? digite o nome do quarto:");
            string cachorro4 = Console.ReadLine();
            Console.WriteLine("Seu quarto cão chama: " + cachorro4);

            Console.WriteLine("Espero que seja o ultimo... Qual é o nome do quinto?");
            string cachorro5 = Console.ReadLine();
            Console.WriteLine("Seu quinto cão chama: " + cachorro5);
        

            var cachorros = cachorro1 + cachorro2 + cachorro3 + cachorro4 + cachorro5;


            if (!(cachorros == "pipoca"))
            {

                Console.WriteLine("A pipoca esteve por aqui");

            }

            else
            {

                Console.WriteLine("Cadê a pipoca?");

            }



            Console.WriteLine("Parabéns! Eles devem dar um trabalhão:" + "\n" + cachorro1 + "\n" + cachorro2 + "\n" + cachorro3 + "\n" + cachorro4 + "\n" + cachorro5);


        }
    }
}
