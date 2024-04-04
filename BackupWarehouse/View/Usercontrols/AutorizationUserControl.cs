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
        }

        internal async Task<bool> Show()
        {
            return await _taskComplateAutorization.Task;
        }

        private void ButtonAutorization_Click(object sender, EventArgs e)
        {
            
        }

        private void LinkLabelLosePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Позовите администратора", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}