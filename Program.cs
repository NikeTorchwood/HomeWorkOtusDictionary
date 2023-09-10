namespace HomeWorkOtusDictionary
{
    public class Program
    {
        static void Main()
        {
            var otusDictionary = new OtusDictionary();
            otusDictionary.Add(5, "5");
            otusDictionary.Add(37, "37");
            Console.WriteLine(otusDictionary.Get(37));
            Console.WriteLine(otusDictionary.Get(37));
            Console.WriteLine(otusDictionary.Get(39));
        }
    }
}