using ConsoleMenuBase;
using ConsoleMenuBase.DefaultHandle;
using ConsoleMenuBase.IMenuHandleBase;
using Example.Main.Handle;

namespace Example.Main.Item
{
    public class SubMunu_1 : IShowMenuHandle
    {
        public SubMunu_1(Menu Sender) : base(Sender)
        {
            IsClear = true;
            Menu.ShowInfo = "子菜单1";
            Menu.MenuBottomString = "##############################";
            Menu.MenuTopString = "##############################";
            Menu.Add("示例子菜单_1", new ShowInfo() { Info = "选择了【示例子菜单_1】" });
            Menu.Add("返回上一层", new BackUpLevel(Sender));
            Menu.Add("退出", new Exit() { ShowExitInfo = false });
        }
    }
}