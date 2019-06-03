using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
namespace Ex04.Test
 {
    public class BootMenu 
    {
        private static void RunInterfaceMenu()
        {
            Ex04.Menus.Interfaces.MainMenu interfaceMenu = new Menus.Interfaces.MainMenu("Interfrace Menu");

            Ex04.Menus.Interfaces.SubMenu subMenu1 = new Menus.Interfaces.SubMenu(interfaceMenu, "Show Date/Time");
            Ex04.Menus.Interfaces.SubMenu subMenu2 = new Menus.Interfaces.SubMenu(interfaceMenu, "Version and Digits");

            Ex04.Menus.Interfaces.Operations subMenu1a = new Menus.Interfaces.Operations(subMenu1, "Show Time", new ShowDate());
            Ex04.Menus.Interfaces.Operations subMenu1b = new Menus.Interfaces.Operations(subMenu1, "Show Date", new ShowDate());

            Ex04.Menus.Interfaces.Operations subMenu2a = new Menus.Interfaces.Operations(subMenu2, "Count Digits", new CountingDigits());
            Ex04.Menus.Interfaces.Operations subMenu2b = new Menus.Interfaces.Operations(subMenu2, "Display Version", new DisplayVersion());

            Ex04.Menus.Interfaces.Menu currentMenu = interfaceMenu; 
            while (currentMenu != null)
            {
                Console.Clear();
                Console.WriteLine(currentMenu.ToString());
                string input = Console.ReadLine();
                int option = 0;
                currentMenu.IsValidOption(input, out option);
                if (option  == 0)
                {
                    currentMenu = currentMenu.PrevMenu();
                }
                else if(currentMenu.isSubMenu(option))
                {
                    currentMenu = currentMenu.GetSubMenu(option);
                }
                else
                {
                    currentMenu.Operate(option);
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
        
        public void Run()
        {
            RunInterfaceMenu();
        }
  
    }
}