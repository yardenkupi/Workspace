using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class DisplayVersion : Ex04.Menus.Interfaces.Operations
    {
        public DisplayVersion(Menu i_Parent, string i_Title) : base(i_Parent, i_Title)
        {

        }

        public override void ApplyOperation()
        {
            Console.WriteLine("App Version 19.2.4.32");
        }

    }
}
