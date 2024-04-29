using System.IO;
class writer
{
    static void Main(string[] args)
    {
        using (StreamReader sr = new StreamReader(args[0]))
        {
            String line = sr.ReadToEnd();
            Console.WriteLine(line);
        }
    }
}