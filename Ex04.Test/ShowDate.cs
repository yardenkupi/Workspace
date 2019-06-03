using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    public class ShowDate : Ex04.Menus.Interfaces.Operations
    {
        public ShowDate(Menu i_Parent, string i_Title) : base(i_Parent, i_Title)
        {

        }

        public override void ApplyOperation()
        {
            Console.WriteLine(DateTime.Today.ToString("d"));
        }
    }
}
