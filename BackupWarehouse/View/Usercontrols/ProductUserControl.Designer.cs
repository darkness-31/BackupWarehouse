namespace BackupWarehouse.View.Usercontrols
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelAcceptance = new System.Windows.Forms.Label();
            this.LabelDeparture = new System.Windows.Forms.Label();
            this.ButtonWriteOff = new System.Windows.Forms.Button();
            this.АlowLayoutPanelTags = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddTag = new System.Windows.Forms.Button();
            this.АlowLayoutPanelTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(13, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(57, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название";
            // 
            // LabelAcceptance
            // 
            this.LabelAcceptance.AutoSize = true;
            this.LabelAcceptance.Location = new System.Drawing.Point(274, 10);
            this.LabelAcceptance.Name = "LabelAcceptance";
            this.LabelAcceptance.Size = new System.Drawing.Size(92, 13);
            this.LabelAcceptance.TabIndex = 1;
            this.LabelAcceptance.Text = "Время прибытия";
            // 
            // LabelDeparture
            // 
            this.LabelDeparture.AutoSize = true;
            this.LabelDeparture.Location = new System.Drawing.Point(274, 36);
            this.LabelDeparture.Name = "LabelDeparture";
            this.LabelDeparture.Size = new System.Drawing.Size(85, 13);
            this.LabelDeparture.TabIndex = 2;
            this.LabelDeparture.Text = "Время отбытия";
            // 
            // ButtonWriteOff
            // 
            this.ButtonWriteOff.Location = new System.Drawing.Point(455, 31);
            this.ButtonWriteOff.Name = "ButtonWriteOff";
            this.ButtonWriteOff.Size = new System.Drawing.Size(75, 23);
            this.ButtonWriteOff.TabIndex = 3;
            this.ButtonWriteOff.Text = "Списать";
            this.ButtonWriteOff.UseVisualStyleBackColor = true;
            // 
            // АlowLayoutPanelTags
            // 
            this.АlowLayoutPanelTags.AutoScroll = true;
            this.АlowLayoutPanelTags.Controls.Add(this.ButtonAddTag);
            this.АlowLayoutPanelTags.Location = new System.Drawing.Point(3, 31);
            this.АlowLayoutPanelTags.Name = "АlowLayoutPanelTags";
            this.АlowLayoutPanelTags.Size = new System.Drawing.Size(253, 25);
            this.АlowLayoutPanelTags.TabIndex = 4;
            // 
            // ButtonAddTag
            // 
            this.ButtonAddTag.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddTag.Name = "ButtonAddTag";
            this.ButtonAddTag.Size = new System.Drawing.Size(24, 21);
            this.ButtonAddTag.TabIndex = 0;
            this.ButtonAddTag.Text = "+";
            this.ButtonAddTag.UseVisualStyleBackColor = true;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.АlowLayoutPanelTags);
            this.Controls.Add(this.ButtonWriteOff);
            this.Controls.Add(this.LabelDeparture);
            this.Controls.Add(this.LabelAcceptance);
            this.Controls.Add(this.LabelName);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(533, 59);
            this.АlowLayoutPanelTags.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAcceptance;
        private System.Windows.Forms.Label LabelDeparture;
        private System.Windows.Forms.Button ButtonWriteOff;
        private System.Windows.Forms.FlowLayoutPanel АlowLayoutPanelTags;
        private System.Windows.Forms.Button ButtonAddTag;
    }
}
