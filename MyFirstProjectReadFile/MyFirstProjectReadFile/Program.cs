using System.Diagnostics;
using System.IO;

namespace MyFirstProjectReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "C:\\Users\\sauh\\Downloads\\Com.csv";
            var conteudo = File.ReadAllText(FilePath);

            string[] splitFile = conteudo.Split('\n');
            string pergunta = "DESEJA MODIFICAR A LINHA?";

            foreach (var row in splitFile)
            {
                Console.WriteLine(row);

                Console.Write(pergunta);
                string resposta = Console.ReadLine();

                if (resposta.Contains("sim"))
                {
                    Console.WriteLine("Digite como ficará a linha:");
                    string respostafile = Console.ReadLine();
                    File.WriteAllText(FilePath, respostafile);
                }
                else
                {
                    Console.WriteLine("Ótimo!! Aperte enter para ir para a próxima linha.");
                }
            }
        }

    }
}
