namespace Delegate_CallBack_
{
    internal class Program
    {
        public delegate void CallBackDelege(string value);
        static void Main(string[] args)
        {


            // bu kısım yarın detaylı konuşulacak

            CallBackDelege delege = ClassA.MethodA;

            Topla(10, 20, delege);
        }
        static void Topla(int a,int b,CallBackDelege delege)
        {
            int toplam = a + b;
            delege("Topla metodu çalıştı sonuç " + toplam);

        }
    }
}