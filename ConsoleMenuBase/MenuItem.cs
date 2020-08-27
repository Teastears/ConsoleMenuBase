namespace ConsoleMenuBase
{
    public class MenuItem
    {
        public string Command { get; set; }

        public string ShowName { get; set; }

        public IMenuHandle MenuHandle { get; set; }

        public Menu Parent { get; set; }
    }
}