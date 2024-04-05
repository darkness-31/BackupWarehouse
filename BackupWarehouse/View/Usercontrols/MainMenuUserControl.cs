using BackupWarehouse.Models;
using BackupWarehouse.View.Window;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BackupWarehouse.Models.Utils;

namespace BackupWarehouse.View.Usercontrols
{
    public partial class MainMenuUserControl : UserControl
    {
        ObservableCollection<ProductUserControl> productUserControls { get; set; }

        public MainMenuUserControl()
        {
            InitializeComponent();
            Render();

            if (Autification.CurrentAccoutn.Access.Code == 0)
            {
                TabPageUsers.Dispose();
            }

            FormCreateProduct.UpdateProductEvent += () => Render();
            Product.ProductUpdateEvent += () => Render();
            TabControlMainMenu.SelectedIndexChanged += (s, e) =>
            {
                if (TabControlMainMenu.SelectedIndex == 1)
                    DataGridUsers.DataSource = Account.GetCollection().Select(x => new
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Login = x.Login,
                        Access = x.Access.Meaning,
                    }).ToArray();
            };
            Account.AccountUpdateEvent += () =>
            {
                DataGridUsers.DataSource = Account.GetCollection().Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Login = x.Login,
                    Access = x.Access.Meaning,
                }).ToArray();
            };
        }
        

        private void ButtonCreateProduct_Click(object sender, System.EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FormCreateProduct")
                {
                    frm.Activate();
                    return;
                }
            }

            new FormCreateProduct().Show();
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
            Product[] products;
            if (!string.IsNullOrEmpty(search))
            {
                Regex regtSearch = new Regex(@"t:[^\r\n\s]+");
                var match = regtSearch.Match(search).Value;
                if (match.Contains("t:"))
                {
                    string tmpTags = match.Reverse().Substring(0, match.Length - 2).Reverse();
                    string[] tagsSearch;
                    if (tmpTags.Contains(","))
                    {
                        tagsSearch = tmpTags.Split(',').Select(x => x.ToLower()).ToArray();
                    }
                    else
                    {
                        tagsSearch = new string[] { tmpTags };
                    }


                    search = string.Join(" ", search.Split(new string[] { match }, StringSplitOptions.RemoveEmptyEntries));
                    products = Product.GetCollection(search.TrimStart(' ').TrimEnd(' '));
                    products = products.Where(x => x.Tags.Any(a => tagsSearch.Any(l => a.Meaning.ToLower().Contains(l.ToLower())))).ToArray();
                }
                else
                {
                    products = Product.GetCollection(search);
                }
            }
            else
            {
                products = Product.GetCollection();
            }


            productUserControls = new ObservableCollection<ProductUserControl>(products.Select(x => new ProductUserControl(x)));
            FlowLayoutPanelProducts.Controls.Clear();
            FlowLayoutPanelProducts.Controls.AddRange(productUserControls.ToArray());
        }

        private void ButtonAddUser_Click(object sender, System.EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FormCreateUser")
                {
                    frm.Activate();
                    return;
                }
            }

            new FormCreateUser().Show();
        }

        private void ButtonDeleteUser_Click(object sender, System.EventArgs e)
        {
            var rowIndex = DataGridUsers.CurrentCell.RowIndex;
            var accountId = Guid.Parse(DataGridUsers.Rows[rowIndex].Cells["Id"].Value.ToString());
            if (MessageBox.Show($"Вы точно хотите удалить пользователя {DataGridUsers.Rows[rowIndex].Cells["Name"].Value}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Account.Get(accountId).Delete();
            }
        }

        private void ButtonRecoveryPassword_Click(object sender, EventArgs e)
        {
            var rowIndex = DataGridUsers.CurrentCell.RowIndex;
            var accountId = Guid.Parse(DataGridUsers.Rows[rowIndex].Cells["Id"].Value.ToString());
            new FormUserRecoveryPassword(Account.Get(accountId)).Show();
        }
    }
}