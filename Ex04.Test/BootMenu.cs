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

            ShowTime subMenu1a = new ShowTime(subMenu1, "Show Time");
            ShowDate subMenu1b = new ShowDate(subMenu1, "Show Date");
            DisplayVersion subMenu2a = new DisplayVersion(subMenu2, "Display Version");
            CountingDigits subMenu2b = new CountingDigits(subMenu2, "Count Digits");

            Ex04.Menus.Interfaces.Menu currentMenu = interfaceMenu;
            int option = 0;
            while (currentMenu != null)
            {
                Console.Clear();
                Console.Write(currentMenu.ToString());
                string input = Console.ReadLine();
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
                    Console.Clear();
                    currentMenu.Operate(option);
                    Console.Write("To go back press any key");
                    Console.ReadLine();
                }
            }
        }
        
        public void Run()
        {
            RunInterfaceMenu();
        }
  
    }
}