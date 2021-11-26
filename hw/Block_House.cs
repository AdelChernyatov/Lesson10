using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    namespace Building
    {
        class Block_House : House
        {
            internal Block_House() { }
            public override void Sheathe()
            {
                Console.WriteLine("Дом будет построен из блоков");
            }
        }
    }
    
}
