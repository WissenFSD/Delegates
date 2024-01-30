using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Delegate_1_
{
    internal class Program
    {
        public delegate void FirstDelete();

        static void Main(string[] args)
        {

            FirstDelete firstDelege = new FirstDelete(Metot1);
            firstDelege += Metot2;

            FirstDelete secondDelege = new FirstDelete(Metot3);
            secondDelege += Metot4;


            // ilk delege çalıştırılsın

            Console.WriteLine("First Delege");

            firstDelege();

            Console.WriteLine("Second DElege");
            secondDelege();


            Console.WriteLine("Toplamı çalıştıralım");



            // iki delegeyi toplayabiliyoruz
            // firstdelege ve second delege 'nin işaret ettiği metotlar sumDelege tarafından da işaret edilebilir oldu.

            // 
            FirstDelete sumDelege = firstDelege+secondDelege;

            sumDelege();

            // Çıkartma işlemi yapalım


            Console.WriteLine("çıkartma işlemi");

            // iki delege birbirinden çıkartılabilir.


            // Çıkatma işleminde seconddelege'nin işaret ettiği metotları artık sumDelege işeret edemez.

            sumDelege -= secondDelege;

            sumDelege();


            // sum delege üzerine bir metot daha ekleyelim(Farklı atama)


            Console.WriteLine("= operatörü ile metot eklendi");
            sumDelege = Metot4;

            sumDelege();


            // lambda operatorü ile tanışma !!!!!
            // lambda ile metot oluşturma

            // paramete almayan lambda metot
            sumDelege += () => Console.WriteLine("ben bir metodum");

            //parametre alan lamda metot
            var value1 = (string value) => Console.WriteLine(value);
            value1("lambda string");

            // iki sayıyı toplayan bir lamda metot
            var sumValue = (int a, int b) => Console.WriteLine(a + b);


            // delege invoke etme(invoke etmek ile normal çağırmak arasında bir fark yoktur)

            sumDelege.Invoke();
        }
        public static void Metot1()
        {
            Console.WriteLine("metot1");
        }
        public static void Metot2() { Console.WriteLine("metot2"); }
        public static void Metot3() { Console.WriteLine("metot3"); }    
        public static void Metot4() { Console.WriteLine("metot4"); }
    }
}