using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class nhietdo
    {
        public int doC { get; set; }
        public int doK { get; set; }

        public int doF { get; set; }
        public void DisplayInfo()
        {
            Console.Write("nhiet do C ");
            double doC = Convert.ToDouble(Console.ReadLine());

            double doK = doC + 273.15;

            double doF = (doC * 9 / 5) + 32;

            Console.WriteLine($"{doC}C = {doK}K ");
            Console.WriteLine($"{doC}C = {doF}F ");
        }
    }
}
