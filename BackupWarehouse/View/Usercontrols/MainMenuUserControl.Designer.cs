using System.ComponentModel;

namespace BackupWarehouse.View.Usercontrols
{
    partial class MainMenuUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlMainMenu = new System.Windows.Forms.TabControl();
            this.TabPageProducts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCreateProduct = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.FlowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.TabPageUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.DataGridUsers = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteUser = new System.Windows.Forms.Button();
            this.ButtonRecoveryPassword = new System.Windows.Forms.Button();
            this.TabControlMainMenu.SuspendLayout();
            this.TabPageProducts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPageUsers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMainMenu
            // 
            this.TabControlMainMenu.Controls.Add(this.TabPageProducts);
            this.TabControlMainMenu.Controls.Add(this.TabPageUsers);
            this.TabControlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.TabControlMainMenu.Name = "TabControlMainMenu";
            this.TabControlMainMenu.SelectedIndex = 0;
            this.TabControlMainMenu.Size = new System.Drawing.Size(636, 398);
            this.TabControlMainMenu.TabIndex = 0;
            // 
            // TabPageProducts
            // 
            this.TabPageProducts.Controls.Add(this.tableLayoutPanel1);
            this.TabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.TabPageProducts.Name = "TabPageProducts";
            this.TabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageProducts.Size = new System.Drawing.Size(628, 372);
            this.TabPageProducts.TabIndex = 0;
            this.TabPageProducts.Text = "Товары";
            this.TabPageProducts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ButtonCreateProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonClear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FlowLayoutPanelProducts, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 366);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ButtonCreateProduct
            // 
            this.ButtonCreateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCreateProduct.Location = new System.Drawing.Point(3, 3);
            this.ButtonCreateProduct.Name = "ButtonCreateProduct";
            this.ButtonCreateProduct.Size = new System.Drawing.Size(71, 24);
            this.ButtonCreateProduct.TabIndex = 0;
            this.ButtonCreateProduct.Text = "Добавить";
            this.ButtonCreateProduct.UseVisualStyleBackColor = true;
            this.ButtonCreateProduct.Click += new System.EventHandler(this.ButtonCreateProduct_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Location = new System.Drawing.Point(80, 3);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(371, 20);
            this.TextBoxSearch.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSearch.Location = new System.Drawing.Point(457, 3);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(81, 24);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonClear.Location = new System.Drawing.Point(544, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 24);
            this.ButtonClear.TabIndex = 3;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FlowLayoutPanelProducts
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FlowLayoutPanelProducts, 4);
            this.FlowLayoutPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelProducts.Location = new System.Drawing.Point(3, 33);
            this.FlowLayoutPanelProducts.Name = "FlowLayoutPanelProducts";
            this.FlowLayoutPanelProducts.Size = new System.Drawing.Size(616, 330);
            this.FlowLayoutPanelProducts.TabIndex = 1;
            // 
            // TabPageUsers
            // 
            this.TabPageUsers.Controls.Add(this.tableLayoutPanel2);
            this.TabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.TabPageUsers.Name = "TabPageUsers";
            this.TabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageUsers.Size = new System.Drawing.Size(628, 372);
            this.TabPageUsers.TabIndex = 1;
            this.TabPageUsers.Text = "Пользователи";
            this.TabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ButtonAddUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataGridUsers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonDeleteUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonRecoveryPassword, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 366);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddUser.TabIndex = 0;
            this.ButtonAddUser.Text = "Добавить";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // DataGridUsers
            // 
            this.DataGridUsers.AllowUserToAddRows = false;
            this.DataGridUsers.AllowUserToDeleteRows = false;
            this.DataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.DataGridUsers, 3);
            this.DataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUsers.Location = new System.Drawing.Point(3, 32);
            this.DataGridUsers.Name = "DataGridUsers";
            this.DataGridUsers.ReadOnly = true;
            this.DataGridUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUsers.Size = new System.Drawing.Size(616, 331);
            this.DataGridUsers.TabIndex = 0;
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.Location = new System.Drawing.Point(84, 3);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteUser.TabIndex = 0;
            this.ButtonDeleteUser.Text = "Удалить";
            this.ButtonDeleteUser.UseVisualStyleBackColor = true;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonRecoveryPassword
            // 
            this.ButtonRecoveryPassword.Location = new System.Drawing.Point(165, 3);
            this.ButtonRecoveryPassword.Name = "ButtonRecoveryPassword";
            this.ButtonRecoveryPassword.Size = new System.Drawing.Size(163, 23);
            this.ButtonRecoveryPassword.TabIndex = 1;
            this.ButtonRecoveryPassword.Text = "Восстановить пароль";
            this.ButtonRecoveryPassword.UseVisualStyleBackColor = true;
            this.ButtonRecoveryPassword.Click += new System.EventHandler(this.ButtonRecoveryPassword_Click);
            // 
            // MainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControlMainMenu);
            this.Name = "MainMenuUserControl";
            this.Size = new System.Drawing.Size(636, 398);
            this.TabControlMainMenu.ResumeLayout(false);
            this.TabPageProducts.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TabPageUsers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMainMenu;
        private System.Windows.Forms.TabPage TabPageProducts;
        private System.Windows.Forms.TabPage TabPageUsers;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelProducts;
        private System.Windows.Forms.Button ButtonCreateProduct;
        private System.Windows.Forms.DataGridView DataGridUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonDeleteUser;
        private System.Windows.Forms.Button ButtonRecoveryPassword;
    }
}