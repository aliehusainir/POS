using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataTable dataTable = new DataTable();
                dataTable = DBAccess.FillDataTable("select * from account where username='" + txtUsername.Text.Trim() +
                                            "' and password='" + txtPassword.Text.Trim() + "'", dataTable);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    mainWindow mainWindow = new mainWindow();
                    mainWindow.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Masukkan username dan password.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
