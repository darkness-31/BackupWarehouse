using BackupWarehouse.Models;
using BackupWarehouse.View.Window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupWarehouse.View.Usercontrols
{
    internal partial class ProductUserControl : UserControl
    {
        internal Product Value { get; set; }

        internal ProductUserControl(Product product)
        {
            Value = product; 
            InitializeComponent();

            LabelName.Text = product.Name;
            LabelStatus.Text = product.Status.Meaning;
            LabelAcceptance.Text = product.Acceptance.ToString();

            if (product.Departure == null || product.Departure == DateTime.MinValue)
                LabelDeparture.Text = string.Empty;
            else
                LabelDeparture.Text = product.Departure.ToString();

            foreach (Entity item in product.Tags)
            {
                var but = new Button()
                {
                    Name = string.Join("", item.Name, item.Meaning),
                    Text = item.Meaning
                };
                but.Click += ButtonTagClick;
                АlowLayoutPanelTags.Controls.Add(but);
            }

            АlowLayoutPanelTags.Controls.SetChildIndex(ButtonAddTag ,АlowLayoutPanelTags.Controls.Count - 1);
        }

        private async void ButtonAddTag_Click(object sender, EventArgs e)
        {
            var entity = await new FormTags().ShowEnt();
            if (Value.Tags.Any(x => x.Id == entity.Id)) return;
            Value.LinkTag(entity);

            var but = new Button()
            {
                Text = entity.Meaning,
                AutoSize = true
            };
            but.Click += ButtonTagClick;

            АlowLayoutPanelTags.Controls.Add(but);
            АlowLayoutPanelTags.Controls.SetChildIndex(ButtonAddTag, АlowLayoutPanelTags.Controls.Count);
        }

        private void ButtonTagClick(object sender, EventArgs e)
        {
            АlowLayoutPanelTags.Controls.Remove((Button)sender);
            var ent = Value.Tags.First(x => x.Meaning == ((Button)sender).Text);
            Value.DeleteTag(ent);
        }

        private void ButtonWriteOff_Click(object sender, EventArgs e)
        {
            Value.Delete();
        }
    }
}
