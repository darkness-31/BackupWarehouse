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
            this.TabPageUsers = new System.Windows.Forms.TabPage();
            this.ButtonCreateProduct = new System.Windows.Forms.Button();
            this.FlowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabPageProducts.SuspendLayout();
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
            this.TabPageProducts.Controls.Add(this.FlowLayoutPanelProducts);
            this.TabPageProducts.Controls.Add(this.ButtonCreateProduct);
            this.TabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.TabPageProducts.Name = "TabPageProducts";
            this.TabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageProducts.Size = new System.Drawing.Size(628, 372);
            this.TabPageProducts.TabIndex = 0;
            this.TabPageProducts.Text = "Товары";
            this.TabPageProducts.UseVisualStyleBackColor = true;
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
            // ButtonCreateProduct
            // 
            this.ButtonCreateProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCreateProduct.Location = new System.Drawing.Point(3, 3);
            this.ButtonCreateProduct.Name = "ButtonCreateProduct";
            this.ButtonCreateProduct.Size = new System.Drawing.Size(622, 23);
            this.ButtonCreateProduct.TabIndex = 0;
            this.ButtonCreateProduct.Text = "Добавить";
            this.ButtonCreateProduct.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanelProducts
            // 
            this.FlowLayoutPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelProducts.Location = new System.Drawing.Point(3, 26);
            this.FlowLayoutPanelProducts.Name = "FlowLayoutPanelProducts";
            this.FlowLayoutPanelProducts.Size = new System.Drawing.Size(622, 343);
            this.FlowLayoutPanelProducts.TabIndex = 1;
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
    }
}