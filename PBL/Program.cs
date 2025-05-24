using System;
using System.Windows.Forms;

namespace PBL.View
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //while (true)
            //{
            //    // Mở form đăng nhập
            //    using (Login login = new Login())
            //    {
            //        if (login.ShowDialog() == DialogResult.OK)
            //        {
            //            // Nếu đăng nhập thành công → vào form chính
            //            using (Main mainForm = new Main(login.Username))
            //            {
            //                // Nếu mainForm bị đóng (logout), quay lại login
            //                DialogResult result = mainForm.ShowDialog();

            //                if (result == DialogResult.Cancel)
            //                {
            //                    // Đăng xuất → quay lại login
            //                    continue;
            //                }
            //                else
            //                {
            //                    // Thoát hoàn toàn ứng dụng
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            // Người dùng bấm Cancel ở form đăng nhập → thoát app
            //            break;
            //        }
            //    }
                Application.Run(new Main(""));
                //Application.Run(new Main("ND001"));
            //}
        }
    }
}
