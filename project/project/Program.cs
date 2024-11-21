using System;
using project;
internal class Program
{
    private static void aa(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    static void Main(string[] args)
    {
        tong2so tong2so = new tong2so();
        tong2so.DisplayInfo();

        bangnhan bangnhan =new bangnhan();
        bangnhan.DisplayInfo();

        trungbinhcong trungbinhcong = new trungbinhcong();
        trungbinhcong.DisplayInfo();

        nhietdo nhietdo = new nhietdo();
        nhietdo.DisplayInfo();
    }
}