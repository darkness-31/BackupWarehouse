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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageProducts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCreateProduct = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.FlowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.TabPageUsers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabPageProducts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageProducts);
            this.tabControl1.Controls.Add(this.TabPageUsers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 398);
            this.tabControl1.TabIndex = 0;
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
            this.TabPageUsers.Controls.Add(this.dataGridView1);
            this.TabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.TabPageUsers.Name = "TabPageUsers";
            this.TabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageUsers.Size = new System.Drawing.Size(628, 372);
            this.TabPageUsers.TabIndex = 1;
            this.TabPageUsers.Text = "Пользователи";
            this.TabPageUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "MainMenuUserControl";
            this.Size = new System.Drawing.Size(636, 398);
            this.tabControl1.ResumeLayout(false);
            this.TabPageProducts.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageProducts;
        private System.Windows.Forms.TabPage TabPageUsers;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelProducts;
        private System.Windows.Forms.Button ButtonCreateProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonClear;
    }
}