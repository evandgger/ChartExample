using Graphics.Forms;

namespace Graphics
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
         
            Application.Run(new MainForm());
        }
    }
}