using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Magazine : Press
    {
        string quality;

        public string Quality { get => quality; set => quality = value; }
        public Magazine(int copies, string name, int price, string quality) :base(copies,name,price)
        {
            this.quality = quality;
            //if (quality == "высокое")
            //{
            //    base.Cost();
            //    Console.WriteLine($"{Cost()}");
            //}
        }
        public void Output()
        {
            base.Cost();
              
            Console.WriteLine($"{Cost()}");
        }
    }
}
