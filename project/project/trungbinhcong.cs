using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class trungbinhcong
    {
        public int so1 { get; set; }
        public int So2 { get; set; }
        public int So3 { get; set; }
        public int So4 { get; set; }
        public void DisplayInfo()
        {
            Console.Write("so thu nhat: ");
            double So1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("so thu 2: ");
            double So2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("so thu 3: ");
            double So3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("so thu 4: ");
            double So4 = Convert.ToDouble(Console.ReadLine());


            double TBC = (So1 + So2 + So3 + So4)/4;
            Console.WriteLine($"Tong 2 so = {TBC}");
        }
    }
}
