using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projendp.meyveler
{
    class Cilek : Meyveler
    {

        
        public override void VitaminA()
        {
            AVitamin = 12 * (gram * verim / 100) / 100;
        }

        public override void VitaminC()
        {
            CVitamin = 60 * (gram * verim / 100) / 100;
        }


    }
}
