using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class bangnhan
    {
        public int so { get; set; }
       

        public void DisplayInfo()
        {
            Console.Write("so nguyen: ");
            int so = Convert.ToInt32(Console.ReadLine());

            // In bảng nhân của số đó
            Console.WriteLine($"\n bang nhan {so}:");
            for (int i = 1; i <= 10; i++)
            {
                int ketQua = so * i;
                Console.WriteLine($"{so} x {i} = {ketQua}");
            }
        }
    }
}
