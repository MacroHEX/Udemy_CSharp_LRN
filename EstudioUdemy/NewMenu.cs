using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class NewMenu
    {
        public void PrintM(string n)
        {
            HWList hWList = new HWList();
            Console.Clear();
            Dictionary<string, HWList> Diccionariol = new Dictionary<string, HWList>()
            {
                {"1", hWList},
            };
            hWList[0].Main(HW01ex01);
        }
    }
}

Console.