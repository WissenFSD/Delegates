using System.Reflection.Metadata.Ecma335;

namespace Ornek2
{
    internal class Program
    {

        delegate int HesapDelege(int a, int b);
        static void Main(string[] args)
        {

            HesapDelege hesap = new HesapDelege(Topla);
            hesap += Carp;
            hesap += Bol;
            hesap += Cikart;



            // lambda ile metot yazdık (mod metodunu bu şekilde ekledik)
            hesap += (int a, int b) => a % b;
            



            int returnValue = hesap(10, 5);
            Console.WriteLine(returnValue);




        }

        static int Topla(int a, int b)
        {
            Console.WriteLine("Topla Çalıştı");
            return a + b;
        }
        static int Carp(int a, int b)
        {
            Console.WriteLine("Carp Calisti");
            return a * b;
        }
        static int Bol(int a, int b)
        {
            Console.WriteLine("Böl Çalıştı");
            return a / b;
        }
        static int Cikart(int a, int b)
        {
            Console.WriteLine("Çıkart çalıştı");
            return a - b;
        }
    }
}