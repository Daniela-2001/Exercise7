namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nome; //Variável que armazena o nome do usuário

            Console.WriteLine("Escreva seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Meu nome é");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Nome);
            Console.ReadKey();

            
        }
    }
}