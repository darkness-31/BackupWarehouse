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
    public partial class FormTags : Form
    {
        ObservableCollection<Entity> entities { get; set; }
        internal TaskCompletionSource<Entity> _taskComplate = new TaskCompletionSource<Entity>();

        public FormTags()
        {
            InitializeComponent();
        }

        internal async Task<Entity> ShowEnt()
        {
            Show();
            return await _taskComplate.Task;
        }

        private void FormTags_Load(object sender, EventArgs e)
        {
            render();
        }

        private void render()
        {
            entities = Entity.GetCollection(Entity.eGroup.tag);
            ListBoxTags.DataSource = entities.Select(x => x.Meaning).ToList();
        }

        private void ButtonSaveName_Click(object sender, EventArgs e)
        {
            var text = TextBoxName.Text;

            if (string.IsNullOrEmpty(text) && text.Length < 2)
            {
                return;
            }

            Entity.Create(Entity.eGroup.tag, text);
            TextBoxName.Text = string.Empty;
            render();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            var ent = entities.FirstOrDefault(x => x.Meaning == ListBoxTags.SelectedItem.ToString());
            _taskComplate.SetResult(ent);
            Close();
        }
    }
}
