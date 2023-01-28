using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projendp.meyveler
{
    class Elma : Meyveler
    {
        
        public override void VitaminA()
        {
            AVitamin = 54 * (gram * verim / 100) / 100;
        }

        public override void VitaminC()
        {
            CVitamin = 5 * (gram * verim / 100) / 100;
        }


    }
}
