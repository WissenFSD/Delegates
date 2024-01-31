using System.Reflection.Metadata.Ecma335;

namespace LambdaOperatoru
{
    internal class Program
    {
        delegate int LambdaDelege(int n);
        static void Main(string[] args)
        {
            // LAmbda operatörleri  sadeleştirilmiş anonim(isimsiz) metotlardır


            // Lambda operatorleri ile // parametre alan yada parametre almayan anonim metotlar tasarlayabiliriz.


            // Lambda operatörü (=>)


            // örnek

            //n=>n*n;

            // n=>n==10;
            // yukarıdaki örnekteki kodun anlamı şudur

            // n adında parametre alan bir anonim metot ve bu metodun içerisinde  n*n yapılmış

            // yukarıdaki örnek kodda => ifadenin sol tarafı metodun aldığı parametre bölümü(çoklu yada tekli parametre olabilir)
            //=> sağ tarafı ise metodun gövdesi görevini görür


            // aşağıdaki metodu anonim bir metot ile yazalım 

            //delegate (int n)
            //{
            //    return n * n;
            //}

            // delege ifadesini çıkartalım

            //(int n){
            //    return n * n;
            //}

            // lambda şu lşekilde


            LambdaDelege delege = (int n) => n * n;



            List<int> list = new List<int>();
            list.Add(5);
            list.Add(15);

            list.Add(20);
            list.Add(7);

          var value =   list.Where(s=>s>5).ToList();

        }
        int Metot(int n)
        {
            return n*n;
        }
    }
}