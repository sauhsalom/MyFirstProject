using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstProjectReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "C:\\Users\\sauh\\Downloads\\testesauh.csv";
            var conteudo = File.ReadAllText(FilePath);

            List<string> splitFile = conteudo.Split('\n').ToList();

            for (int i = 0; i < splitFile.Count; i++)
            {
                string pergunta = "DESEJA MODIFICAR A LINHA?";
                Console.WriteLine(splitFile[i]);

                Console.Write(pergunta);
                string resposta = Console.ReadLine();

                if (resposta.Contains("sim"))
                {
                    string linha = "Digite como ficará a linha:";
                    Console.Write(linha);
                    string novaLinha = Console.ReadLine()!;

                    splitFile[i] = novaLinha;
                }

                else
                {
                    Console.WriteLine("Ótimo!Vamos para a próxima linha.");
                }

            }
            File.WriteAllLines(FilePath, splitFile);
        }
    }
}
