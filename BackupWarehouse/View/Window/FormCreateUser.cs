using BackupWarehouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupWarehouse.View.Window
{
    public partial class FormCreateUser : Form
    {
        ObservableCollection<Entity> _entitiesAccess = new ObservableCollection<Entity>();

        public FormCreateUser()
        {
            InitializeComponent();

            _entitiesAccess = Entity.GetCollection(Entity.eGroup.access);
            ComboBoxAccess.DataSource = _entitiesAccess.Select(x => x.Meaning).ToArray();
            ComboBoxAccess.SelectedIndex = 0;
        }

        private void MessageWarning(string message) => MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxName.Text) || 
                string.IsNullOrEmpty(TextBoxLogin.Text) ||
                string.IsNullOrEmpty(TextBoxPassword.Text) || 
                string.IsNullOrEmpty(TextBoxPasswordAgain.Text))
            {
                MessageWarning("Одно из полей пустое");
                return;
            }

            bool isError = false;

            if (TextBoxName.Text.Length < 2) 
            {
                MessageWarning("Имя имеет меньше 2-х символов");
                isError = true;
            }
            if (TextBoxName.Text.Any(Char.IsDigit))
            {
                MessageWarning("ФИО имеет цифры");
                isError = true;
            }

            if (TextBoxLogin.Text.Length < 4)
            {
                MessageWarning("Логин не может быть меньше 4 символов");
                isError = true;
            }
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

            Account.Create(TextBoxName.Text, TextBoxLogin.Text, TextBoxPassword.Text, _entitiesAccess.First(x => x.Meaning == ComboBoxAccess.Text), Autification.CurrentAccoutn.Id);
            Close();
        }
    }
}
