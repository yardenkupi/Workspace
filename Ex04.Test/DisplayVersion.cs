using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class DisplayVersion : IOperationType
    {
        void IOperationType.ApplyOperation()
        {
            Console.WriteLine("App Version 19.2.4.32");
            Console.ReadLine();
        }

    }
}
