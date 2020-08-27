using System;

namespace ConsoleMenuBase.IMenuHandleBase
{
    /// <summary>
    /// 显示型菜单
    /// </summary>
    public abstract class IShowMenuHandle : IMenuHandle
    {
        protected Menu Menu;
        public Menu Parent { get; set; }

        public bool IsClear { set; get; }

        public IShowMenuHandle(Menu Sender)
        {
            IsClear = false;
            Menu = new Menu();
            Parent = Sender;
        }

        public virtual void Handle(MenuItem sender)
        {
            if (IsClear)
                Console.Clear();
            Menu.Show();
        }
    }
}