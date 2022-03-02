using System; 
namespace alistirma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiler = new int[10];
            Random random = new Random();
            int tek = 0, cift =0;
            for (int i=0; i<10; i++)
            {
                sayiler[i] = random.Next();
                int a = sayiler[i]%2 == 1 ? tek++ : cift++;
                Console.WriteLine(sayiler[i]);
            }
            Console.WriteLine("cift sayilerin sayisi "+ cift);
            Console.WriteLine("tek sayilerin saiyis "+ tek);
        }
    }
}