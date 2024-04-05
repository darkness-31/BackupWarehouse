using BackupWarehouse.Models;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BackupWarehouse.View.Window
{
    public partial class FormCreateProduct : Form
    {
        private Product _product { get; set; } = new Product();
        private ObservableCollection<Entity> _entitiesStatus { get; set; }

        internal delegate void UpdateProductHandler();
        internal static event UpdateProductHandler UpdateProductEvent;

        public FormCreateProduct()
        {
            InitializeComponent();
            _product.Id = Guid.NewGuid();
            _entitiesStatus = Entity.GetCollection(Entity.eGroup.status);
            ComboBoxStatusProduct.DataSource = _entitiesStatus.Select(x => x.Meaning).ToList();
        }

        private void RadioButtonDeparture_CheckedChanged(object sender, EventArgs e)
        {
            var rad = sender as RadioButton;

            if (rad.Checked)
            {
                if (rad == RadioButtonDepartureOff)
                {
                    NumericUpDownDeparture.Enabled = false;
                    DateTimePickerDeparture.Enabled = false;
                }
                else if (rad == RadioButtonDepartureCountDays)
                {
                    NumericUpDownDeparture.Enabled = true;
                    DateTimePickerDeparture.Enabled = false;    
                }
                else if (rad == RadioButtonDepartureDateTime)
                {
                    NumericUpDownDeparture.Enabled = false;
                    DateTimePickerDeparture.Enabled = true;    
                }
            }
        }

        private async void ButtonAddTag_Click(object sender, EventArgs e)
        {
            var entity = await new FormTags().ShowEnt();
            if (_product.Tags.Any(x => x.Id == entity.Id)) return;
            _product.Tags.Add(entity);

            Button but = new Button()
            {
                Text = entity.Meaning,
                AutoSize = true
            };

            but.Click += (s, ev) =>
            {
                FlowLayoutPanelTags.Controls.Remove((Button)s);
            };

            FlowLayoutPanelTags.Controls.Add(but);

            FlowLayoutPanelTags.Controls.SetChildIndex(ButtonAddTag, FlowLayoutPanelTags.Controls.Count);
        }

        private void ButtonCreateProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxName.Text) || TextBoxName.TextLength < 2)
            {
                MessageBox.Show("Нет название или оно слишком мальенькое","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _product.Name = TextBoxName.Text;

            _product.Acceptance = MonthCalendarAcceptance.SelectionStart.Date;

            if (RadioButtonDepartureDateTime.Checked)
            {
                if (DateTimePickerDeparture.Value < MonthCalendarAcceptance.SelectionStart.Date) 
                {
                    MessageBox.Show("Значение прибытия не может быть меньше чем отбытия товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                _product.Departure = MonthCalendarAcceptance.SelectionStart.Date;
            }
            else if (RadioButtonDepartureCountDays.Checked)
            {
                _product.Departure = _product.Acceptance.AddDays((int)NumericUpDownDeparture.Value);
            }

            _product.Status = _entitiesStatus.FirstOrDefault(x => x.Meaning == ComboBoxStatusProduct.Text);

            _product.CreatedAt = DateTime.Now;
            _product.ModifiedAt = DateTime.Now;
            _product.CreatedBy = Autification.CurrentAccoutn;

            Product.Create(_product);
            UpdateProductEvent?.Invoke();
            Close();
        }
    }
}
