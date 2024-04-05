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
            this.ListBoxTags = new System.Windows.Forms.ListBox();
            this.ButtonSaveName = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListBoxTags
            // 
            this.ListBoxTags.FormattingEnabled = true;
            this.ListBoxTags.Location = new System.Drawing.Point(12, 77);
            this.ListBoxTags.Name = "ListBoxTags";
            this.ListBoxTags.Size = new System.Drawing.Size(236, 329);
            this.ListBoxTags.Sorted = true;
            this.ListBoxTags.TabIndex = 0;
            // 
            // ButtonSaveName
            // 
            this.ButtonSaveName.AutoSize = true;
            this.ButtonSaveName.Location = new System.Drawing.Point(147, 38);
            this.ButtonSaveName.Name = "ButtonSaveName";
            this.ButtonSaveName.Size = new System.Drawing.Size(101, 23);
            this.ButtonSaveName.TabIndex = 1;
            this.ButtonSaveName.Text = "Сохранить";
            this.ButtonSaveName.UseVisualStyleBackColor = true;
            this.ButtonSaveName.Click += new System.EventHandler(this.ButtonSaveName_Click);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(12, 415);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(236, 23);
            this.ButtonSelect.TabIndex = 2;
            this.ButtonSelect.Text = "Выбрать";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(236, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.ButtonSaveName);
            this.Controls.Add(this.ListBoxTags);
            this.Name = "FormTags";
            this.Text = "Теги";
            this.Load += new System.EventHandler(this.FormTags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxTags;
        private System.Windows.Forms.Button ButtonSaveName;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.TextBox TextBoxName;
    }
}