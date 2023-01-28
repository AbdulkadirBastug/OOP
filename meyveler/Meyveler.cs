using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projendp.meyveler
{
    abstract class Meyveler
    {
        
        public int verim { get; set; }
        public int gram { get; set; }
        public int AVitamin { get; set; }
        public int CVitamin { get; set; }
        public void agirlik()       //70-120 arasında rastgele ağırlık üretip grama değişkenine aktarırç
        {
            Random rastgele = new Random();
            gram = rastgele.Next(70, 120);

        }

        public  void Verim()    //30-70 arasında rastgele değer üretip verim değişkenine aktarır.
        {
            Random rastgele = new Random();
            verim = rastgele.Next(30, 70);
            
        }
        public abstract void VitaminA();
        public abstract void VitaminC();
        

    }
}
