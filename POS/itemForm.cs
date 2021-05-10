using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class itemForm : Form
    {
        private bool editMode = false;
        public itemForm()
        {
            InitializeComponent();
            Text = "Add Item";
        }
        public itemForm(int ID, string name, int price, int stock)
        {
            InitializeComponent();
            lblIDResult.Text = ID.ToString();
            txtName.Text = name;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();
            editMode = true;
            Text = "Edit Item";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Pastikan seluruh field terisi.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query;
            if (editMode)
            {
                query = "update item set name = '" + txtName.Text.Trim() + "', price = " + txtPrice.Text.Trim() +
                        ", stock = " + txtStock.Text.Trim() + " where id = " + lblIDResult.Text.Trim();
            }
            else
            {
                query = "insert into item (name, price, stock) values ('" + txtName.Text.Trim() + "', " + txtPrice.Text.Trim() +
                        ", " + txtStock.Text.Trim() + ")";
            }
            DBAccess.InsertQuery(query);
            if (editMode)
            {
                MessageBox.Show("Item berhasil diubah.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Item berhasil ditambahkan.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtPrice.Clear();
                txtStock.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
