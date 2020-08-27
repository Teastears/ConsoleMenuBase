using ConsoleMenuBase;
using ConsoleMenuBase.IMenuHandleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Main.Handle
{
    public class ShowInfo : IActionMenuHandle
    {
        public string  Info { get; set; }
        protected override void Action(MenuItem sende)
        {
            Console.WriteLine(Info);
            Console.WriteLine();
        }
    }
}
