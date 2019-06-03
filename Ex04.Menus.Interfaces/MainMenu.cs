using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_Title)
        {
            m_Title = i_Title;
        }

        public override string ToString()
        {
            StringBuilder menuOption = new StringBuilder();
            menuOption.AppendFormat("{0}", this.MenuOptions());
            menuOption.AppendFormat("0. Exit{0}", Environment.NewLine);
            menuOption.AppendFormat("Please enter your choice(1-{0} or  0 to exit): {1}", m_SubItems.Count(), Environment.NewLine);
            menuOption.Append(">> ");
            return menuOption.ToString();
        }

        public override Menu PrevMenu()
        {
            return null;
        }

    }
}
