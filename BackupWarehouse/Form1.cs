using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackupWarehouse.Models.Utils;

namespace BackupWarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var auto = new View.Usercontrols.AutorizationUserControl();
            auto.Location = auto.CenterWindow(this);
            Controls.Add(auto);
            if (await auto.Show())
            {
                
            }
        }
    }
}