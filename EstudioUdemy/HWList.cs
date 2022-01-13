using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1e1 = Udemy.HW01ex01;
using H1e2 = Udemy.HW01ex02;
using H2e1 = Udemy.HW02ex01;
using H2e2 = Udemy.HW02ex02;
using H3e1 = Udemy.HW03ex01;
using H3e2 = Udemy.HW03ex02;
using H3e3 = Udemy.HW03ex03;
using H4e1 = Udemy.HW04ex01;
using H4e2 = Udemy.HW04ex02;
using H5e1 = Udemy.HW05ex01;
using H5e2 = Udemy.HW05ex02;
using H6 = Udemy.HW06;
using H7 = Udemy.HW07;
using H8 = Udemy.HW08; 

namespace Udemy
{
    public class HWList
    {
        public void GetHW(string homework, string exercise)
        {
            string hoex = homework + "-" + exercise;

            switch (hoex)
            {
                case "1-1":
                    H1e1.Main();
                    break;
                case "1-2":
                    H1e2.Main();
                    break;
                case "2-1":
                    H2e1.Main();
                    break;
                case "2-2":
                    H2e2.Main();
                    break;
                case "3-1":
                    H3e1.Main();
                    break;
                case "3-2":
                    H3e2.Main();
                    break;
                case "3-3":
                    H3e3.Main();
                    break;
                case "4-1":
                    H4e1.Main();
                    break;
                case "4-2":
                    H4e2.Main();
                    break;
                case "5-1":
                    H5e1.Main();
                    break;
                case "5-2":
                    H5e2.Main();
                    break;
                case "6-1":
                    H6.Main(exercise);
                    break;
                case "6-2":
                    H6.Main(exercise);
                    break;
                case "6-3":
                    H6.Main(exercise);
                    break;
                case "6-4":
                    H6.Main(exercise);
                    break;
                case "7-1":
                    H7.Main();
                    break;
                case "8-1":
                    H8.Main();
                    break;
            }
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
