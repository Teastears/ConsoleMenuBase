using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMenuBase
{
    public class Menu
    {
        public Menu()
        {
            MenuItems = new List<MenuItem>();
            MenuTopString = "*************************************************";
            MenuBottomString = "**************************************************";
        }

        public string ShowInfo { get; set; }

        public string MenuTopString { get; set; }

        public string MenuBottomString { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public void Add(string ShowName, IMenuHandle Handle)
        {
            var item = new MenuItem();
            item.Command = (MenuItems.Count + 1).ToString();
            item.ShowName = ShowName;
            item.MenuHandle = Handle;
            item.Parent = this;
            MenuItems.Add(item);
        }

        public void Show()
        {
            ShowMenu();
            bool actresult;
            do
            {
                var select = Select();
                actresult = Act(select);
            } while (!actresult);
        }

        private void ShowMenu()
        {
            Console.WriteLine(MenuTopString);
            Console.WriteLine(ShowInfo);
            foreach (var item in MenuItems)
            {
                Console.WriteLine(item.Command.ToString() + ":" + item.ShowName);
            }
            Console.WriteLine(MenuBottomString);
        }

        private MenuItem Select()
        {
            MenuItem Select = null;
            do
            {
                Console.Write("请选择操作：");
                var Command = Console.ReadLine();
                Select = MenuItems.FirstOrDefault(t => t.Command.Equals(Command, StringComparison.OrdinalIgnoreCase));
                if (Select != null)
                {
                    return Select;
                }
                Console.WriteLine("选择不正确");
                Console.WriteLine();
            } while (true);
        }

        private bool Act(MenuItem Select)
        {
            try
            {
                Select.MenuHandle.Handle(Select);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}