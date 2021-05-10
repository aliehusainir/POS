using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class mainWindow : Form
    {
        int total = 0;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvPayment.Rows[e.RowIndex];
                paymentForm paymentForm = new paymentForm(this, (int) row.Cells[0].Value, (int) row.Cells[3].Value);
                paymentForm.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvPayment.Rows[e.RowIndex];
                int price = (int)row.Cells[2].Value;
                int quantity = (int)row.Cells[3].Value;
                total -= price * quantity;
                updateTotalText();
                dgvPayment.Rows.Remove(dgvPayment.Rows[e.RowIndex]);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItemPayment_Click(object sender, EventArgs e)
        {
            paymentForm paymentForm = new paymentForm(this);
            paymentForm.Show();
        }

        private void btnAddItemInventory_Click(object sender, EventArgs e)
        {
            itemForm itemForm = new itemForm();
            itemForm.Show();
        }

        private void POS_Activated(object sender, EventArgs e)
        {
            DataSet invDataSet = new DataSet();
            invDataSet = DBAccess.FillDataSet("select * from item", invDataSet);
            dgvInventory.Columns.Clear();
            dgvInventory.DataSource = invDataSet.Tables[0];

            dgvInventory.Columns[0].HeaderText = "Item ID";
            dgvInventory.Columns[1].HeaderText = "Name";
            dgvInventory.Columns[2].HeaderText = "Price";
            dgvInventory.Columns[3].HeaderText = "Stock";

            DataSet hisDataSet = new DataSet();
            hisDataSet = DBAccess.FillDataSet("select * from invoice", hisDataSet);
            dgvHistory.Columns.Clear();
            dgvHistory.DataSource = hisDataSet.Tables[0];

            dgvHistory.Columns[0].HeaderText = "Invoice ID";
            dgvHistory.Columns[1].HeaderText = "Discount";
            dgvHistory.Columns[2].HeaderText = "Date";

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn detailsColumn = new DataGridViewButtonColumn();
            detailsColumn.Name = "Details";
            detailsColumn.Text = "Details";
            detailsColumn.UseColumnTextForButtonValue = true;

            dgvInventory.Columns.Add(editColumn);
            dgvInventory.Columns.Add(deleteColumn);
            dgvHistory.Columns.Add(detailsColumn);
        }

        public void dgvPaymentAdd(int id, string name, int price, int quantity)
        {
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                if (row.Cells[0].Value.ToString() == id.ToString())
                {
                    int oldQuantity = (int) row.Cells[3].Value;
                    row.Cells[3].Value = quantity;
                    total -= price * oldQuantity;
                    total += price * quantity;
                    updateTotalText();
                    return;
                }
            }
            dgvPayment.Rows.Add(id, name, price, quantity);
            total += price * quantity;
            updateTotalText();
            return;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void updateTotalText()
        {
            if (txtDiscount.Text == "")
            {
                lblTotalResult.Text = "Rp. " + total.ToString();
            }
            else
            {
                int discText = Int32.Parse(txtDiscount.Text);
                if (discText > 100)
                {
                    discText = 100;
                }
                float discTotal = total * (100 - discText) / 100;
                lblTotalResult.Text = "Rp. " + discTotal.ToString();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            updateTotalText();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvPayment.Rows.Count == 0)
            {
                return;
            }
            string discText;
            if (txtDiscount.Text == "")
            {
                discText = "0";
            }
            else if (Int32.Parse(txtDiscount.Text) > 100)
            {
                discText = "100";
            }
            else
            {
                discText = txtDiscount.Text;
            }
            DBAccess.InsertQuery("insert into invoice (discount, date) values(" + discText + ", getdate())");
            DataSet dataSet = new DataSet();
            dataSet = DBAccess.FillDataSet("select top 1 id from invoice order by id desc", dataSet);
            string invoiceID = dataSet.Tables[0].Rows[0][0].ToString();
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                string itemID = row.Cells[0].Value.ToString();
                string quantity = row.Cells[3].Value.ToString();
                DBAccess.InsertQuery("insert into orders values (" + itemID + ", " + invoiceID + ", " + quantity + ")");
                DBAccess.InsertQuery("update item set stock = stock - " + quantity + " where id = " + itemID);
            }
            MessageBox.Show("Transaksi berhasil.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            while (dgvPayment.Rows.Count > 0)
            {
                dgvPayment.Rows.Remove(dgvPayment.Rows[0]);
            }
            total = 0;
            txtDiscount.Text = "";
            updateTotalText();
        }

        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            POS_Activated(new object(), new EventArgs());
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                itemForm itemForm = new itemForm((int)row.Cells[0].Value, (string)row.Cells[1].Value,
                                                (int)row.Cells[2].Value, (int)row.Cells[3].Value);
                itemForm.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                string itemID = row.Cells[0].Value.ToString();
                if (MessageBox.Show("Hapus barang ini?", "POS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DBAccess.InsertQuery("delete from orders where itemid = " + itemID);
                    DBAccess.InsertQuery("delete from item where id = " + itemID);
                    POS_Activated(new object(), new EventArgs());
                }
            }
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 3)
            {
                
                DataGridViewRow row = dgvHistory.Rows[e.RowIndex];
                int invoiceID = (int)row.Cells[0].Value;
                decimal discount = (decimal)row.Cells[1].Value;
                DateTime date = (DateTime)row.Cells[2].Value;
                historyForm historyForm = new historyForm(invoiceID, discount, date);
                historyForm.Show();
            }
        }
    }
}