using BackupWarehouse.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace BackupWarehouse.View.Usercontrols
{
    public partial class MainMenuUserControl : UserControl
    {
        ObservableCollection<ProductUserControl> productUserControls { get; set; }

        public MainMenuUserControl()
        {
            InitializeComponent();
            Render();
        }
        

        private void ButtonCreateProduct_Click(object sender, System.EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, System.EventArgs e)
        {
            Render(TextBoxSearch.Text);
        }

        private void ButtonClear_Click(object sender, System.EventArgs e)
        {
            TextBoxSearch.Text = string.Empty;
            Render();
        }

        internal void Render(string search = "")
        {
            FlowLayoutPanelProducts.Controls.Clear();

            productUserControls = new ObservableCollection<ProductUserControl>(Product.GetCollection(search).Select(x => new ProductUserControl(x)));

            FlowLayoutPanelProducts.Controls.AddRange(productUserControls.ToArray());
        }
    }
}