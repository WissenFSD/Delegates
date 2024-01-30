using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{


    // delegeler işaret edecekleri metotlara göre tasarlanmalıdır.
    // delegeyi geri dönüş tipi void ve parametre almayan bir delege olarak tasarlarsanız
    // bu degele geri dönüş tipi void ve parametre almayan metotları işaret eder.


    public class FirstDelegate
    {

        delegate void IlkDenege(string value);



        public FirstDelegate()
        {
            // delegeye metot işaret ettirme
            IlkDenege delege = new IlkDenege(Metot1);

            // farklı metot işaret ettirme
            delege += Metot2;



            // delege çalıştırıldı
            delege("deger");
           
            delege -= Metot2;


            // bu şekilde delege içerisinden metot çıkartabilirsiniz
            delege("deger");

            // delegeler sadece tanımlandıkları tipte metotları işaret edebilirler.
            //delege += Metot4;
        }
        void Metot1(string value)
        {
            Console.WriteLine("metot 1 çalıştı");
        }
        void Metot2(string value)
        {
            Console.WriteLine("metot 2 çalıştı");
        }
        void Metot3(string value)
        {
            Console.WriteLine("metot 3 çalıştı");
        }
        void Metot4()
        {
            Console.WriteLine("metot 1 çalıştı");
        }




    }
}
