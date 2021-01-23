using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> Kadro = new MyDictionary<string, int>();
            Kadro.Add("Atiba Hutchinson", 13);
            Kadro.Add("Josef de Souza", 5);
            Kadro.Add("Rıdvan Yılmaz", 33);
            Kadro.Add("Cyle Larin", 17);

            for (int i = 0; i < Kadro.key.Length; i++)
            {
                Console.WriteLine(Kadro.key[i] + " " + Kadro.value[i] + " ");
            }
        }
    }
}
