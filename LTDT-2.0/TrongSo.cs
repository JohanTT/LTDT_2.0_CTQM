using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT_2._0
{
    public partial class TrongSoForm : Form
    {
        public static TrongSoForm instance;
        public TrongSoForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void Taobtn_Click(object sender, EventArgs e)
        {
            MainForm.instance.number = int.Parse(TrongSotxt.Text);
            MainForm.instance.CheckTaobtn = true;
            this.Close();
        }

        private void Huybtn_Click(object sender, EventArgs e)
        {
            MainForm.instance.CheckTaobtn = false;
            this.Close();
        }

        private void TrongSo_Load(object sender, EventArgs e)
        {
            DinhFrom.Text = MainForm.instance.lb1.Text;
            DinhTo.Text = MainForm.instance.lb2.Text;
        }
    }
}
