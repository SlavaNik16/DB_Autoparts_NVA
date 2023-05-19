using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DB_Autoparts_NVA.Forms
{
    public partial class UsersForm : Form
    {
        private readonly Users user;
        public UsersForm()
        {
            InitializeComponent();
            this.BackColor = ColorsHelp.ColorBackground;
            panelHeader.BackColor = ColorsHelp.ColorButtonSubmit;
            panelBack.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            ColorsHelp.ButtonSubmit(butSave);
            ColorsHelp.ButtonCancel(butCansel);

            this.Text = "Создание пользователя";
            butSave.Text = "Создать";
            user = new Users();
            user.birthday = dateTimeBirthday.Value;
            user.status = "User";
            comboGender.SelectedIndex = 0;

        }

        public UsersForm(Users sourse) : this()
        {
            user = sourse;
            this.Text = "Изменение данных пользователя";
            butSave.Text = "Изменить";
            txtBoxSurname.Text = sourse.surname;
            txtBoxName.Text = sourse.name;
            comboGender.SelectedItem = sourse.gender;
            dateTimeBirthday.Value = sourse.birthday;
            txtBoxPhone.Visible = false;
            txtBoxEmail.Visible = false;
            txtBoxPassword.Visible = false;
        }
        public Users Users => user;



        private void txtBoxSurname_TextChanged(object sender, EventArgs e)
        {
            user.surname = txtBoxSurname.Text;
            Validates();

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            user.name = txtBoxName.Text;
            Validates();
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.gender = (string)comboGender.SelectedItem;
            Validates();
        }

        private void dateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {

            user.birthday = dateTimeBirthday.Value;
            Validates();
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPhone.Text.Length >= 6 && txtBoxPhone.Text.Length <= 11)
            {
                user.phone = txtBoxPhone.Text;
                errorProviderPhone.Clear();
                Validates();
            }
            else
            {
                butSave.Enabled = false;
                errorProviderPhone.SetError(this.txtBoxPhone, "Длина номера должна быть больше 6 символов(не больше 11)");
            }

        }



        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(txtBoxEmail.Text, pattern))
            {
                errorProviderEmail.Clear();
                user.email = txtBoxEmail.Text;
                Validates();
            }
            else
            {
                butSave.Enabled = false;
                errorProviderEmail.SetError(this.txtBoxEmail, "Неправильный формат!!!");
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Validates();
            if (txtBoxPassword.Text.Length < 8)
            {
                user.password = "";

                return;
            }

            user.password = txtBoxPassword.Text;
            Validates();
        }

        public void Validates()
        {
            butSave.Enabled =
                !string.IsNullOrWhiteSpace(user.surname) &&
                !string.IsNullOrWhiteSpace(user.name) &&
                !string.IsNullOrWhiteSpace(user.phone) &&
                !string.IsNullOrWhiteSpace(user.password) &&
                !string.IsNullOrWhiteSpace(user.email);

        }

        private void KeyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void KeyEnglishAndRussiaSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) //Английские буквы прописные
              || (e.KeyChar >= 97 && e.KeyChar <= 122)//строчные
              || (e.KeyChar >= 1040 && e.KeyChar <= 1103) //руские буквы
              || e.KeyChar == 8)//Backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
