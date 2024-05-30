using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim.UI.Helpers
{
    public static class FormDragHelper
    {
        // user32.dll'den SendMessage ve ReleaseCapture fonksiyonlarını import edin
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        /// <summary>
        /// Bir formun MouseDown olayı için sürükleme işlevselliği ekler.
        /// </summary>
        /// <param name="form">Sürükleme işlevselliği eklenecek form</param>
        public static void EnableFormDrag(Form form)
        {
            form.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }
    }
}
