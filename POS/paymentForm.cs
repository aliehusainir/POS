using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class paymentForm : Form
    {
        private DataSet dataSet;
        private mainWindow parent;
        public paymentForm(mainWindow parent)
        {
            InitializeComponent();
            Text = "Add Item";
            dataSet = new DataSet();
            dataSet = DBAccess.FillDataSet("select * from item", dataSet);
            GetID();
            this.parent = parent;
        }

        public paymentForm(mainWindow parent, int ID, int quantity)
        {
            InitializeComponent();
            Text = "Edit Item";
            dataSet = new DataSet();
            dataSet = DBAccess.FillDataSet("select * from item", dataSet);
            GetID();
            for (int i = 0; i < cbID.Items.Count; i++)
            {
                if (cbID.GetItemText(cbID.Items[i]) == ID.ToString())
                {
                    cbID.SelectedIndex = i;
                    cbID_SelectedIndexChanged(new object(), new EventArgs());
                }
            }
            lblIDResult.Text = ID.ToString();
            cbID.Visible = false;
            lblIDResult.Visible = true;
            this.parent = parent;
        }

        public void GetID()
        {
            cbID.DisplayMember = "id";
            cbID.ValueMember = "id";
            cbID.DataSource = dataSet.Tables[0];
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = dataSet.Tables[0];
            foreach (DataRow row in table.Rows)
            {
                if (row["id"].ToString() == cbID.SelectedValue.ToString())
                {
                    lblNameResult.Text = row["name"].ToString();
                    lblPriceResult.Text = row["price"].ToString();
                    lblStockResult.Text = row["stock"].ToString();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || txtQuantity.Text == "0")
            {
                MessageBox.Show("Isi jumlah barang yang ingin ditransaksikan.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(lblStockResult.Text) < Int32.Parse(txtQuantity.Text))
            {
                MessageBox.Show("Jumlah barang melebihi stok tersedia.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            parent.dgvPaymentAdd(Int32.Parse(cbID.SelectedValue.ToString()), lblNameResult.Text, Int32.Parse(lblPriceResult.Text), Int32.Parse(txtQuantity.Text));
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
