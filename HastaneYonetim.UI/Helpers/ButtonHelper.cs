using System;
using System.Drawing;
using System.Windows.Forms;

namespace HastaneYonetim.UI.Helpers
{
    public static class ButtonHelper
    {
        /// <summary>
        /// Butonun fare üzerine geldiğinde tetiklenen olay.
        /// </summary>
        /// <param name="button">Rengi değiştirilecek buton</param>
        public static void ApplyMouseEnterEffect(Button button)
        {
            button.MouseEnter += (sender, e) => button.BackColor = Color.AliceBlue;
        }

        /// <summary>
        /// Butonun fare üzerine çıktığında tetiklenen olay.
        /// </summary>
        /// <param name="button">Rengi değiştirilecek buton</param>
        public static void ApplyMouseLeaveEffect(Button button)
        {
            button.MouseLeave += (sender, e) => button.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Butona hem fare giriş hem de çıkış olaylarını uygular.
        /// </summary>
        /// <param name="button">Olayların uygulanacağı buton</param>
        public static void ApplyMouseEffects(Button button)
        {
            ApplyMouseEnterEffect(button);
            ApplyMouseLeaveEffect(button);
        }
    }
}