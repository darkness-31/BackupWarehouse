namespace BackupWarehouse.View.Window
{
    partial class FormCreateProduct
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthCalendarAcceptance = new System.Windows.Forms.MonthCalendar();
            this.DateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.NumericUpDownDeparture = new System.Windows.Forms.NumericUpDown();
            this.RadioButtonDepartureOff = new System.Windows.Forms.RadioButton();
            this.RadioButtonDepartureCountDays = new System.Windows.Forms.RadioButton();
            this.RadioButtonDepartureDateTime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonCreateProduct = new System.Windows.Forms.Button();
            this.FlowLayoutPanelTags = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddTag = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBoxStatusProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeparture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.FlowLayoutPanelTags.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 28);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(332, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // MonthCalendarAcceptance
            // 
            this.MonthCalendarAcceptance.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.MonthCalendarAcceptance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthCalendarAcceptance.Location = new System.Drawing.Point(3, 16);
            this.MonthCalendarAcceptance.MaxDate = new System.DateTime(2025, 4, 5, 0, 0, 0, 0);
            this.MonthCalendarAcceptance.MaxSelectionCount = 1;
            this.MonthCalendarAcceptance.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.MonthCalendarAcceptance.Name = "MonthCalendarAcceptance";
            this.MonthCalendarAcceptance.TabIndex = 3;
            this.MonthCalendarAcceptance.TodayDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            // 
            // DateTimePickerDeparture
            // 
            this.DateTimePickerDeparture.Enabled = false;
            this.DateTimePickerDeparture.Location = new System.Drawing.Point(103, 65);
            this.DateTimePickerDeparture.MaxDate = new System.DateTime(2025, 4, 5, 0, 0, 0, 0);
            this.DateTimePickerDeparture.MinDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.DateTimePickerDeparture.Name = "DateTimePickerDeparture";
            this.DateTimePickerDeparture.Size = new System.Drawing.Size(223, 20);
            this.DateTimePickerDeparture.TabIndex = 4;
            this.DateTimePickerDeparture.Value = new System.DateTime(2024, 4, 5, 13, 20, 17, 0);
            // 
            // NumericUpDownDeparture
            // 
            this.NumericUpDownDeparture.Enabled = false;
            this.NumericUpDownDeparture.Location = new System.Drawing.Point(103, 42);
            this.NumericUpDownDeparture.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.NumericUpDownDeparture.Name = "NumericUpDownDeparture";
            this.NumericUpDownDeparture.Size = new System.Drawing.Size(223, 20);
            this.NumericUpDownDeparture.TabIndex = 6;
            // 
            // RadioButtonDepartureOff
            // 
            this.RadioButtonDepartureOff.AutoSize = true;
            this.RadioButtonDepartureOff.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonDepartureOff.Name = "RadioButtonDepartureOff";
            this.RadioButtonDepartureOff.Size = new System.Drawing.Size(44, 17);
            this.RadioButtonDepartureOff.TabIndex = 7;
            this.RadioButtonDepartureOff.TabStop = true;
            this.RadioButtonDepartureOff.Text = "Нет";
            this.RadioButtonDepartureOff.UseVisualStyleBackColor = true;
            this.RadioButtonDepartureOff.CheckedChanged += new System.EventHandler(this.RadioButtonDeparture_CheckedChanged);
            // 
            // RadioButtonDepartureCountDays
            // 
            this.RadioButtonDepartureCountDays.AutoSize = true;
            this.RadioButtonDepartureCountDays.Location = new System.Drawing.Point(6, 42);
            this.RadioButtonDepartureCountDays.Name = "RadioButtonDepartureCountDays";
            this.RadioButtonDepartureCountDays.Size = new System.Drawing.Size(95, 17);
            this.RadioButtonDepartureCountDays.TabIndex = 7;
            this.RadioButtonDepartureCountDays.TabStop = true;
            this.RadioButtonDepartureCountDays.Text = "Сколько дней";
            this.RadioButtonDepartureCountDays.UseVisualStyleBackColor = true;
            this.RadioButtonDepartureCountDays.CheckedChanged += new System.EventHandler(this.RadioButtonDeparture_CheckedChanged);
            // 
            // RadioButtonDepartureDateTime
            // 
            this.RadioButtonDepartureDateTime.AutoSize = true;
            this.RadioButtonDepartureDateTime.Location = new System.Drawing.Point(6, 65);
            this.RadioButtonDepartureDateTime.Name = "RadioButtonDepartureDateTime";
            this.RadioButtonDepartureDateTime.Size = new System.Drawing.Size(96, 17);
            this.RadioButtonDepartureDateTime.TabIndex = 7;
            this.RadioButtonDepartureDateTime.TabStop = true;
            this.RadioButtonDepartureDateTime.Text = "Выбрать дней";
            this.RadioButtonDepartureDateTime.UseVisualStyleBackColor = true;
            this.RadioButtonDepartureDateTime.CheckedChanged += new System.EventHandler(this.RadioButtonDeparture_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonDepartureOff);
            this.groupBox1.Controls.Add(this.RadioButtonDepartureDateTime);
            this.groupBox1.Controls.Add(this.DateTimePickerDeparture);
            this.groupBox1.Controls.Add(this.RadioButtonDepartureCountDays);
            this.groupBox1.Controls.Add(this.NumericUpDownDeparture);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время отбытия";
            // 
            // ButtonCreateProduct
            // 
            this.ButtonCreateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCreateProduct.Location = new System.Drawing.Point(12, 490);
            this.ButtonCreateProduct.Name = "ButtonCreateProduct";
            this.ButtonCreateProduct.Size = new System.Drawing.Size(332, 23);
            this.ButtonCreateProduct.TabIndex = 9;
            this.ButtonCreateProduct.Text = "Создать";
            this.ButtonCreateProduct.UseVisualStyleBackColor = true;
            this.ButtonCreateProduct.Click += new System.EventHandler(this.ButtonCreateProduct_Click);
            // 
            // FlowLayoutPanelTags
            // 
            this.FlowLayoutPanelTags.Controls.Add(this.ButtonAddTag);
            this.FlowLayoutPanelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelTags.Location = new System.Drawing.Point(3, 16);
            this.FlowLayoutPanelTags.Name = "FlowLayoutPanelTags";
            this.FlowLayoutPanelTags.Size = new System.Drawing.Size(326, 70);
            this.FlowLayoutPanelTags.TabIndex = 10;
            // 
            // ButtonAddTag
            // 
            this.ButtonAddTag.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddTag.Name = "ButtonAddTag";
            this.ButtonAddTag.Size = new System.Drawing.Size(23, 23);
            this.ButtonAddTag.TabIndex = 0;
            this.ButtonAddTag.Text = "+";
            this.ButtonAddTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonAddTag.UseVisualStyleBackColor = true;
            this.ButtonAddTag.Click += new System.EventHandler(this.ButtonAddTag_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.FlowLayoutPanelTags);
            this.groupBox2.Location = new System.Drawing.Point(12, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 89);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Теги";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MonthCalendarAcceptance);
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время прибытия";
            // 
            // ComboBoxStatusProduct
            // 
            this.ComboBoxStatusProduct.FormattingEnabled = true;
            this.ComboBoxStatusProduct.Location = new System.Drawing.Point(15, 361);
            this.ComboBoxStatusProduct.Name = "ComboBoxStatusProduct";
            this.ComboBoxStatusProduct.Size = new System.Drawing.Size(326, 21);
            this.ComboBoxStatusProduct.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Статус";
            // 
            // FormCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxStatusProduct);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCreateProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxName);
            this.Name = "FormCreateProduct";
            this.Text = "Создать поступаемый продукт";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeparture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FlowLayoutPanelTags.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar MonthCalendarAcceptance;
        private System.Windows.Forms.DateTimePicker DateTimePickerDeparture;
        private System.Windows.Forms.NumericUpDown NumericUpDownDeparture;
        private System.Windows.Forms.RadioButton RadioButtonDepartureOff;
        private System.Windows.Forms.RadioButton RadioButtonDepartureCountDays;
        private System.Windows.Forms.RadioButton RadioButtonDepartureDateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonCreateProduct;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelTags;
        private System.Windows.Forms.Button ButtonAddTag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBoxStatusProduct;
        private System.Windows.Forms.Label label2;
    }
}