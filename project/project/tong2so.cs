using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class tong2so
    {
        public int tong { get; set; }
        public int So2 { get; set; }

        public void DisplayInfo()
        {
            Console.Write("so thu nhat: ");
            double So1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("so thu 2: ");
            double So2 = Convert.ToDouble(Console.ReadLine());

            double nhan = So1 * So2;
            double chia = So1 / So2;
            double cong = So1 + So2;
            double tru = So1 - So2;

            Console.WriteLine($"nhan 2 so = {nhan}");
            Console.WriteLine($"chia 2 so = {chia}");
            Console.WriteLine($"cong 2 so = {cong}");
            Console.WriteLine($"tru 2 so = {tru}");

        }
    }
}
