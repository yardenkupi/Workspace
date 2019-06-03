using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : Menu, ISubItem
    {
        protected readonly Menu r_Parent;

        public SubMenu(Menu i_Parent, string i_Title)
        {
            int index = 0;
            r_Parent = i_Parent;
            i_Parent.AddSubItem(this, out index);
            m_Title = index + ". " + i_Title;

        }

        public override string ToString()
        {
            StringBuilder menuOption = new StringBuilder();
            menuOption.AppendFormat("{0}", this.MenuOptions());
            menuOption.AppendFormat("0. Back{0}", Environment.NewLine);
            menuOption.AppendFormat("Please enter your choice(1-{0} or  0 to go back): {1}", m_SubItems.Count(), Environment.NewLine);
            menuOption.Append(">> ");
            return menuOption.ToString();
        }

        public override Menu PrevMenu()
        {
            return r_Parent;
        }
        public string Title
        {
            get { return m_Title;}
        }

    }
}
