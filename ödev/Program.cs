namespace ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Altay");
            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
        }
    }
}