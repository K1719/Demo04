using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj1
{
    class Hissi
    {
        // field variables
        private int floor {
            get
            {

            }
            set
            {
                if (value > 5)
                {
                    Console.WriteLine("This floor doesn't exist - set to maximum");
                    floor = 5;
                }
                else if (value < 1)
                    {
                    Console.WriteLine("This floor doesn't exist - set to minimum");
            }
        }
    }
}
