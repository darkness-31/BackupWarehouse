using BackupWarehouse.Models;
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

            LabelName.Text = product.Name;
            LabelAcceptance.Text = product.Acceptance.ToString();
            LabelDeparture.Text = product.Departure.ToString();

            foreach (Entity item in product.Tags)
            {
                АlowLayoutPanelTags.Controls.Add(new Button() { Name = string.Join("", item.Name, item.Meaning), Text = item.Meaning });
            }

            АlowLayoutPanelTags.Controls.SetChildIndex(ButtonAddTag ,АlowLayoutPanelTags.Controls.Count - 1);

            InitializeComponent();
        }
    }
}
