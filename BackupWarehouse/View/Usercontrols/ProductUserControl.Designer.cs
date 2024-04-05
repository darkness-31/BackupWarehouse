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
            this.LabelAcceptanceText = new System.Windows.Forms.Label();
            this.LabelDepartureText = new System.Windows.Forms.Label();
            this.ButtonWriteOff = new System.Windows.Forms.Button();
            this.АlowLayoutPanelTags = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddTag = new System.Windows.Forms.Button();
            this.LabelDeparture = new System.Windows.Forms.Label();
            this.LabelAcceptance = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.АlowLayoutPanelTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(13, 11);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(91, 20);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название";
            // 
            // LabelAcceptanceText
            // 
            this.LabelAcceptanceText.AutoSize = true;
            this.LabelAcceptanceText.Location = new System.Drawing.Point(293, 16);
            this.LabelAcceptanceText.Name = "LabelAcceptanceText";
            this.LabelAcceptanceText.Size = new System.Drawing.Size(92, 13);
            this.LabelAcceptanceText.TabIndex = 1;
            this.LabelAcceptanceText.Text = "Время прибытия";
            // 
            // LabelDepartureText
            // 
            this.LabelDepartureText.AutoSize = true;
            this.LabelDepartureText.Location = new System.Drawing.Point(293, 37);
            this.LabelDepartureText.Name = "LabelDepartureText";
            this.LabelDepartureText.Size = new System.Drawing.Size(85, 13);
            this.LabelDepartureText.TabIndex = 2;
            this.LabelDepartureText.Text = "Время отбытия";
            // 
            // ButtonWriteOff
            // 
            this.ButtonWriteOff.Location = new System.Drawing.Point(474, 84);
            this.ButtonWriteOff.Name = "ButtonWriteOff";
            this.ButtonWriteOff.Size = new System.Drawing.Size(85, 23);
            this.ButtonWriteOff.TabIndex = 3;
            this.ButtonWriteOff.Text = "Списать";
            this.ButtonWriteOff.UseVisualStyleBackColor = true;
            this.ButtonWriteOff.Click += new System.EventHandler(this.ButtonWriteOff_Click);
            // 
            // АlowLayoutPanelTags
            // 
            this.АlowLayoutPanelTags.AutoScroll = true;
            this.АlowLayoutPanelTags.Controls.Add(this.ButtonAddTag);
            this.АlowLayoutPanelTags.Location = new System.Drawing.Point(14, 36);
            this.АlowLayoutPanelTags.Name = "АlowLayoutPanelTags";
            this.АlowLayoutPanelTags.Size = new System.Drawing.Size(253, 64);
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
            this.ButtonAddTag.Click += new System.EventHandler(this.ButtonAddTag_Click);
            // 
            // LabelDeparture
            // 
            this.LabelDeparture.AutoSize = true;
            this.LabelDeparture.Location = new System.Drawing.Point(384, 37);
            this.LabelDeparture.Name = "LabelDeparture";
            this.LabelDeparture.Size = new System.Drawing.Size(20, 13);
            this.LabelDeparture.TabIndex = 2;
            this.LabelDeparture.Text = "Во";
            // 
            // LabelAcceptance
            // 
            this.LabelAcceptance.AutoSize = true;
            this.LabelAcceptance.Location = new System.Drawing.Point(384, 16);
            this.LabelAcceptance.Name = "LabelAcceptance";
            this.LabelAcceptance.Size = new System.Drawing.Size(20, 13);
            this.LabelAcceptance.TabIndex = 1;
            this.LabelAcceptance.Text = "Вп";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(384, 59);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(40, 13);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус товара";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.АlowLayoutPanelTags);
            this.Controls.Add(this.ButtonWriteOff);
            this.Controls.Add(this.LabelDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelDepartureText);
            this.Controls.Add(this.LabelAcceptance);
            this.Controls.Add(this.LabelAcceptanceText);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelName);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(565, 113);
            this.АlowLayoutPanelTags.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelAcceptanceText;
        private System.Windows.Forms.Label LabelDepartureText;
        private System.Windows.Forms.Button ButtonWriteOff;
        private System.Windows.Forms.FlowLayoutPanel АlowLayoutPanelTags;
        private System.Windows.Forms.Button ButtonAddTag;
        private System.Windows.Forms.Label LabelDeparture;
        private System.Windows.Forms.Label LabelAcceptance;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label label1;
    }
}
