using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projendp.meyveler
{
    class Mandalina : Meyveler
   
    {
        
        public override void VitaminA()
        {
            AVitamin = 681 * (gram * verim / 100) / 100;
        }

        public override void VitaminC()
        {
            CVitamin = 26 * (gram * verim / 100) / 100;
        }


    }
}
