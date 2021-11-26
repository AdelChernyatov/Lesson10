using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    namespace Building 
    {
        class Brick_House : House
        {
            internal Brick_House() { }
            public override void Sheathe()
            {
                Console.WriteLine("Дом будет обшит кирпичом");
            }

        }
    }  
}
