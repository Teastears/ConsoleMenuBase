using ConsoleMenuBase;
using ConsoleMenuBase.IMenuHandleBase;
using System;

namespace Example.Main.Handle
{
    public class ShowInfo : IActionMenuHandle
    {
        public string Info { get; set; }

        protected override void Action(MenuItem sende)
        {
            Console.WriteLine(Info);
            Console.WriteLine();
        }
    }
}