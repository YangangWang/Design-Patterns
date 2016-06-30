using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter2
{
    public partial class Form1 : Form
    {
        double _count = 0;
        double _price = 0;
        double _total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCount.Focus();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                _count = Convert.ToDouble(txtCount.Text.Trim());
                _price = Convert.ToDouble(txtPrice.Text.Trim());
                _total = _count * _price;
                txtTotal.Text = _total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _count = 0;
            _price = 0;
            txtCount.Text = "";
            txtPrice.Text = "";
            txtTotal.Text = "";
            
        }
    }
}
