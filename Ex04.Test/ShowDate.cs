using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class ShowDate : IOperationType
    {
        void IOperationType.ApplyOperation()
        {
            Console.WriteLine(DateTime.Today.ToString("d"));
            Console.ReadLine();
        }
    }
}
