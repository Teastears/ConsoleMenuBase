namespace ConsoleMenuBase.DefaultHandle
{
    public class BackUpLevel : IMenuHandle
    {
        protected Menu Menu;

        public BackUpLevel(Menu UpLevel)
        {
            Menu = UpLevel;
        }

        public void Handle(MenuItem sender)
        {
            Menu.Show();
        }
    }
}