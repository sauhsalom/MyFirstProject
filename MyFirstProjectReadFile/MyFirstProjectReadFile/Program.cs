namespace MyFirstProjectReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "C:\\Users\\sauh\\Downloads\\Com.csv";
            var conteudo = File.ReadAllText(FilePath);

            string[] splitFile = conteudo.Split('\n');
            
            foreach (var row in splitFile)
            {
                Console.Write("DESEJA MODIFICAR A LINHA?");
                Console.WriteLine(row);
                Console.ReadLine();
            }
        }

    }
}
