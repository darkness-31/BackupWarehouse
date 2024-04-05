using BackupWarehouse.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupWarehouse.View.Usercontrols
{
    public partial class AutorizationUserControl : UserControl
    {
        private TaskCompletionSource<bool> _taskComplateAutorization = new TaskCompletionSource<bool>();
        
        public AutorizationUserControl()
        {
            InitializeComponent();

            Autification.AutorizationErrorfullyEvent += (mes) =>
            {
                MessageBox.Show(mes, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            Autification.RegistrationErrorfullyEvent += (mes) =>
            {
                MessageBox.Show(mes, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            Autification.RegistrationSuccessfullyEvent += (mes) =>
            {
                TextBoxRegistrationPassword.Text = string.Empty;
                TextBoxRegistrationPasswordAgain.Text = string.Empty;
                TextBoxRegistrationLogin.Text = string.Empty;
                TextBoxRegistrationName.Text = string.Empty;

                MessageBox.Show(mes, "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            Autification.AutorizationSuccessfullyEvent += (mes) =>
            {
                _taskComplateAutorization.SetResult(true);
            };
        }

        internal async Task<bool> Show()
        {
            return await _taskComplateAutorization.Task;
        }

        private void ButtonAutorization_Click(object sender, EventArgs e)
        {
            Autification.Autorization(
                    TextBoxAutorizationLogin.Text,
                    TextBoxAutorizationPassword.Text
                );
        }

        private void LinkLabelLosePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Позовите администратора", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            Autification.Registration(
                    TextBoxRegistrationName.Text,
                    TextBoxRegistrationLogin.Text,
                    TextBoxRegistrationPassword.Text,
                    TextBoxRegistrationPasswordAgain.Text
                );
        }

        private void AutorizationUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}