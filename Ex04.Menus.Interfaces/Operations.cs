using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Interfaces
{
    public class Operations : ISubItem
    {
        protected  Menu r_Parent;
        protected string m_Title;

        public Operations(Menu i_Parent, string i_Title)
        {
            int index = 0;
            r_Parent = i_Parent;
            i_Parent.AddSubItem(this, out index);
            m_Title = index + ". " + i_Title;
        }


        public virtual void ApplyOperation()
        {

        }

        public string Title
        {
            get { return m_Title; }
        }


    }
}
