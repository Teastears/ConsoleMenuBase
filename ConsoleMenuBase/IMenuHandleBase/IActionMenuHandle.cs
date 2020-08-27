namespace ConsoleMenuBase.IMenuHandleBase
{
    /// <summary>
    /// 操作型菜单
    /// </summary>
    public abstract class IActionMenuHandle : IMenuHandle
    {
        public virtual void Handle(MenuItem sender)
        {
            BeforeActionExcute();
            Action(sender);
            AfterActionExcute();
            sender.Parent.Show();
        }

        protected abstract void Action(MenuItem sende);

        protected virtual void BeforeActionExcute()
        { }
        protected virtual void AfterActionExcute()
        { }
    }
}