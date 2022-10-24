using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高(公分):");
            decimal heigth = Convert.ToDecimal(Console.ReadLine());
            Console.Write("請輸入體重(公斤):");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            decimal mheigth = heigth / 100;
            decimal BMI = weight / (mheigth * mheigth);
            string BMIs = BMI.ToString("##.##");
            Console.WriteLine("BMI為:"+BMIs);
        }
    }
}
