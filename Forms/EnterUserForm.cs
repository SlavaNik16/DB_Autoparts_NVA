using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.Models;
using System;
using System.Windows.Forms;

namespace DB_Autoparts_NVA.Forms
{
    public partial class EnterUserForm : Form
    {
        private readonly Users user;
        public EnterUserForm()
        {
            InitializeComponent();
            this.BackColor = ColorsHelp.ColorBackground;
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butCansel);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtPhone, "Введите сюда телефон от 6 до 11 символов");
            toolTip.SetToolTip(txtPassword, "Введите сюда пароль от 8 символов");
            user = new Users();
        }

        public Users Users => user;

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length >= 6 && txtPhone.Text.Length <= 11)
            {
                user.phone = txtPhone.Text;
                errorProviderPhone.Clear();
                Validates();
            }
            else
            {
                butEnter.Enabled = false;
                errorProviderPhone.SetError(this.txtPhone, "Длина номера должна быть больше 6 символов(не больше 11)");
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length <= 7)
            {
                user.password = "";
                Validates();
                return;
            }
            user.password = txtPassword.Text;
            Validates();
        }

        private void Validates()
        {
            butEnter.Enabled =
                !string.IsNullOrWhiteSpace(user.phone) &&
                !string.IsNullOrWhiteSpace(user.password);
        }

        private void KeyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

    }
}
