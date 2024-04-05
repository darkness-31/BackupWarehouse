namespace BackupWarehouse.View.Window
{
    partial class FormTags
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTags));
            this.ListBoxTags = new System.Windows.Forms.ListBox();
            this.ButtonSaveName = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxTags
            // 
            this.ListBoxTags.FormattingEnabled = true;
            this.ListBoxTags.Location = new System.Drawing.Point(12, 93);
            this.ListBoxTags.Name = "ListBoxTags";
            this.ListBoxTags.Size = new System.Drawing.Size(236, 329);
            this.ListBoxTags.Sorted = true;
            this.ListBoxTags.TabIndex = 1;
            // 
            // ButtonSaveName
            // 
            this.ButtonSaveName.AutoSize = true;
            this.ButtonSaveName.Location = new System.Drawing.Point(129, 45);
            this.ButtonSaveName.Name = "ButtonSaveName";
            this.ButtonSaveName.Size = new System.Drawing.Size(101, 23);
            this.ButtonSaveName.TabIndex = 1;
            this.ButtonSaveName.Text = "Сохранить";
            this.ButtonSaveName.UseVisualStyleBackColor = true;
            this.ButtonSaveName.Click += new System.EventHandler(this.ButtonSaveName_Click);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(12, 428);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(236, 23);
            this.ButtonSelect.TabIndex = 2;
            this.ButtonSelect.Text = "Выбрать";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(6, 19);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(224, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSaveName);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание тега";
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.ListBoxTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Теги";
            this.Load += new System.EventHandler(this.FormTags_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxTags;
        private System.Windows.Forms.Button ButtonSaveName;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}