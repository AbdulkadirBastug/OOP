using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projendp.meyveler
{
    class Portakal : Meyveler
    {
        

        public override void VitaminA()
        {

            AVitamin = 225 * (gram * verim / 100) / 100;
            
        }

        public override void VitaminC()
        {
            CVitamin = 45 * (gram * verim / 100) / 100;
        }


    }
}
