using ConsoleMenuBase;
using ConsoleMenuBase.DefaultHandle;
using Example.Main;
using Example.Main.Handle;
using Example.Main.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                var main = new  Menu( );
                main.ShowInfo = "数据库系统数据更新助手，适用于无自增字段数据表数据更新";
                main.Add("菜单_1", new ShowInfo() { Info = "选择了【示例子菜单_1】" });
                main.Add("菜单_2", new ShowInfo() { Info = "选择了【示例子菜单_2】" });
                main.Add("菜单_3", new SubMunu_1(main));
                main.Add("退出", new Exit());
                main.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write(e.StackTrace);
                Console.WriteLine();
                Console.ReadKey();
            }
            finally
            {
                
            }
        }
    }
}
