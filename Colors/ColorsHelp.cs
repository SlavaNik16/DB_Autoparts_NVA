using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Autoparts_NVA.Colors
{
    public static class ColorsHelp
    {
        public static Color ColorBackground {get => Color.FromArgb(255, 2, 74, 104);}
        public static Color ColorBackgroundPanelBack {get => Color.FromArgb(155, ColorButtonSubmit.R, ColorButtonSubmit.G, ColorButtonSubmit.B); }
        public static Color ColorButtonSubmit {get => Color.FromArgb(255, 59, 163, 208);}
        public static Color ColorButtonSubmitOver {get => Color.FromArgb(255, 0, 255, 255);}
        public static Color ColorButtonCancel {get => Color.FromArgb(255, 176, 51, 0); }
        public static Color ColorButtonCancelOver {get => Color.FromArgb(255, 200, 70, 9); }
        public static void ButtonSubmit(Button but)
        {
            but.BackColor = ColorButtonSubmit;
            but.FlatStyle = FlatStyle.Flat;
            but.FlatAppearance.BorderSize = 1;
            but.FlatAppearance.MouseOverBackColor = ColorButtonSubmitOver;
        } 
        public static void ButtonCancel(Button but)
        {
            but.BackColor = ColorButtonCancel;
            but.FlatStyle = FlatStyle.Flat;
            but.FlatAppearance.BorderSize = 1;
            but.FlatAppearance.MouseOverBackColor = ColorButtonCancelOver;
        }
    }

   
}
