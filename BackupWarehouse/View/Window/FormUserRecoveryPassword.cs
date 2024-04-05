using BackupWarehouse.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BackupWarehouse.View.Window
{
    public partial class FormUserRecoveryPassword : Form
    {
        private Account _Account { get; set; }

        internal FormUserRecoveryPassword(Account account)
        {
            InitializeComponent();
            _Account = account;
        }
        private void MessageWarning(string message) => MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TextBoxPassword.Text) ||
                string.IsNullOrEmpty(TextBoxPasswordAgain.Text))
            {
                MessageWarning("Одно из полей пустое");
                return;
            }

            bool isError = false;
            if (TextBoxPassword.Text.Length < 8)
            {
                MessageWarning("Пароль не может быть меньше иметь 8 символов");
                isError = true;
            }
            if (!TextBoxPassword.Text.Any(Char.IsDigit))
            {
                MessageWarning("Пароль не имеет ни одной цифры");
                isError = true;
            }
            if (TextBoxPassword.Text != TextBoxPasswordAgain.Text)
            {
                MessageWarning("Пароли не сходятся");
                isError = true;
            }
            if (isError) return;
            _Account.RecoveryPassword(TextBoxPassword.Text);
            MessageBox.Show($"Успешно поменян пароль у пользователя {_Account.Name}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
