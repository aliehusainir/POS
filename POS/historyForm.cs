using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class historyForm : Form
    {
        public historyForm(int id, decimal discount, DateTime date)
        {
            InitializeComponent();
            lblIDResult.Text = id.ToString();
            lblDiscountResult.Text = discount.ToString() + "%";
            lblDateResult.Text = date.ToString();
            DataSet dataSet = new DataSet();
            dataSet = DBAccess.FillDataSet("select id, name, price, quantity from item join orders " +
                                           "on item.id = orders.itemid where invoiceid = " + id, dataSet);
            dgvInvoice.DataSource = dataSet.Tables[0];
            dgvInvoice.Columns[0].HeaderText = "Item ID";
            dgvInvoice.Columns[1].HeaderText = "Name";
            dgvInvoice.Columns[2].HeaderText = "Price";
            dgvInvoice.Columns[3].HeaderText = "Quantity";
        }
    }
}
