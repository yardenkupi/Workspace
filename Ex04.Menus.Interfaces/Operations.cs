using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Interfaces
{
    public class Operations : ISubItem
    {
        private readonly Menu r_Parent;
        protected string m_Title;
        private readonly IOperationType r_OperationType;

        public Operations(Menu i_Parent, string i_Title, IOperationType i_OperationType)
        {
            int index = 0;
            r_Parent = i_Parent;
            i_Parent.AddSubItem(this, out index);
            m_Title = index + ". " + i_Title;
            r_OperationType = i_OperationType;
        }

        public IOperationType Operation
        {
            get { return r_OperationType; }
        }




    }
}
