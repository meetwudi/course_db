using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            User user = new User();
            Console.WriteLine(user.Login("qinyidan", "charles86223764"));
            Console.WriteLine(user.Login("yushuai", "charles86223764"));
            Console.WriteLine(user.Login("yushuai", "000000"));
            Console.WriteLine(user.Login("huan", "000000"));
        }
    }
}
