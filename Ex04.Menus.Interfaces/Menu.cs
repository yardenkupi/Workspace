using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {
        protected string m_Title = "";
        int m_NumberOfItems = 0;
        protected List<ISubItem> m_SubItems = new List<ISubItem>();

        public void AddSubItem(ISubItem i_SubItem, out int io_Index)
        {
            m_NumberOfItems++;
            m_SubItems.Add(i_SubItem);
            io_Index = m_NumberOfItems;

        }


        public bool IsValidOption(string i_InputOption, out int io_Option)
        {
            bool isValidOption = false;
            int option = 0;
            try
            {
                isValidOption = int.TryParse(i_InputOption, out option);
                if((option > 0 && option <= m_SubItems.Count()) || i_InputOption == "0")
                {
                    isValidOption = true;
                }
            }
            catch(InvalidCastException e)
            {
                throw new InvalidCastException("Invalid option.", e);
            }
            io_Option = option;
            return isValidOption;
        }

        public string MenuOptions()
        {
            StringBuilder menuOption = new StringBuilder();
            menuOption.AppendFormat("{0}{1}", m_Title, Environment.NewLine);
            menuOption.AppendFormat("=============={0}", Environment.NewLine);
            foreach(ISubItem currSubItem in m_SubItems)
            {
                menuOption.AppendFormat("{0}{1}", currSubItem.Title, Environment.NewLine);
            }
            
            return menuOption.ToString();
        }

        public bool isSubMenu(int i_Option)
        {
            return m_SubItems.ElementAt(i_Option - 1) is Menu;
        }

        public Menu GetSubMenu(int i_Option)
        {
            return (SubMenu)m_SubItems.ElementAt(i_Option - 1);
        }

        public void Operate(int i_Option)
        {
            Operations currOption = (Operations)m_SubItems.ElementAt(i_Option - 1);
            currOption.Operation.ApplyOperation();
        }

        public abstract Menu PrevMenu();
    }
}
