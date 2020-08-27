using System;

namespace ConsoleMenuBase.DefaultHandle
{
    public class Exit : IMenuHandle
    {
        public string ExitInfo { get; set; }
        public bool ShowExitInfo { get; set; }

        public Exit()
        {
            ExitInfo = "按任意键退出...";
            ShowExitInfo = true;
        }

        public void Handle(MenuItem sender)
        {
            if (ShowExitInfo)
            {
                Console.WriteLine(ExitInfo);
                Console.ReadKey();
            }
        }
    }
}