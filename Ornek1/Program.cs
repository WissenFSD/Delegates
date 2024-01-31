namespace Ornek1
{
    internal class Program
    {
        public delegate double MathDelege(double x);
        static void Main(string[] args)
        {
            MathDelege mathDelege = new MathDelege(Math.Acos);

            mathDelege += Math.Acosh;
            mathDelege += Math.Sqrt;
            mathDelege += Math.Tan;


            double doubleValue1 = mathDelege(10.15);
            Console.WriteLine(doubleValue1);

            // metotları çıkartalım
            mathDelege -= Math.Tan;
            double doubleValue2 = mathDelege(10.15);
            Console.WriteLine(doubleValue2);

            // geriye değer döndüren metotları işaret eden bir delegeniz olduğunda, işaret ettiği her metot geriye değer döndürdüğü için tüm metotların sonucunu size vermez
            // delegeler sadece en son kendilerine eklenen metotların değerlerini dönerler.


            // yukarıdaki örnekte geriye değer döndüren metotları işaret eden delege örnepi yaptık.
            // hatta en sonuncunun değerini döner bilgisini test etmek için, eklediğimiz son metodu silerek değiştirdik.




            // Hesap makinası'nın metotlarını işaret eden bir delege yapınız

            
            // ara : dönüş 8 30
        }
    }
}