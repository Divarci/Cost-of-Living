using System.Drawing;
using System.Windows.Forms;

namespace Kart_Takip_Sis
{
    internal class ButtonColor
    {

        public void btnclr(Button btn, Color color, Color color1, Color color2)
        {
            btn.FlatAppearance.MouseOverBackColor = color;
            btn.FlatAppearance.MouseDownBackColor = color1;
            btn.FlatAppearance.BorderColor = color2;

        }


    }
}
