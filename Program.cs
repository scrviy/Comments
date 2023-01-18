using System;

namespace Comments
{
    /// <summary>
    /// Comentário dentro de classe ou namespace
    /// </summary>
    public class Comments 
                        
    {
    
        /// <summary>
        /// Método principal onde fica localizado o código principal da aplicação.
        /// </summary>
        /// <param name="args"></param> - Local mostra o parâmetro do método
    
        public static void Main(string[] args)
        {
            /* Comentário em Csharp.
            Definição do tema comentário em C#. */
            Console.WriteLine("Bem vindo ao módulo de comentários na linguagem c#."); 

            // Impressão de mensagem no console.
            Console.WriteLine("Digite seu nome: ");

            // Armazenamento do nome escrito no console em uma variável do tipo string == texto;
            string? hello = Console.ReadLine();

            /* Instanciando variável
            Imprimindo texto no console */
            string frase = "Seja bem vindo ao console";
            Console.WriteLine(frase);


        }
    }
}