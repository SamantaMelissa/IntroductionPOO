using System;

namespace PrimeiroPooAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
        personagem alex = new personagem();
         
        Console.WriteLine(alex.nome);
        Console.WriteLine(alex.idade);
         Console.WriteLine( alex.atacarFraco(34.5f, 20f));

        }
        
        }
       
    
}

