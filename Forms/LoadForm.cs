using DB_Autoparts_NVA.Colors;
using System.Drawing;
using System.Windows.Forms;

namespace DB_Autoparts_NVA.Forms
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            panelHead.BackColor = ColorsHelp.ColorButtonSubmit;
            progressBarLoad.Value = 0;
            textLoad.Text = "Загрузка ...";

        }
        public void EditTextProgress(string text, int value)
        {
            this.textLoad.Text = text;
            this.progressBarLoad.Value = value;
        }
    }
}
