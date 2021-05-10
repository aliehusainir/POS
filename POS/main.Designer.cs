
namespace POS
{
    partial class mainWindow
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnAddItemPayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.payID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.payRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnAddItemInventory = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblPOS = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabCtrl.SuspendLayout();
            this.tabPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabPayment);
            this.tabCtrl.Controls.Add(this.tabInventory);
            this.tabCtrl.Controls.Add(this.tabHistory);
            this.tabCtrl.Location = new System.Drawing.Point(12, 86);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(978, 438);
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.lblTotalResult);
            this.tabPayment.Controls.Add(this.lblTotal);
            this.tabPayment.Controls.Add(this.txtDiscount);
            this.tabPayment.Controls.Add(this.btnCheckout);
            this.tabPayment.Controls.Add(this.lblDiscount);
            this.tabPayment.Controls.Add(this.btnAddItemPayment);
            this.tabPayment.Controls.Add(this.dgvPayment);
            this.tabPayment.Location = new System.Drawing.Point(4, 41);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(970, 393);
            this.tabPayment.TabIndex = 0;
            this.tabPayment.Text = "Payment";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalResult.Location = new System.Drawing.Point(545, 355);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(53, 25);
            this.lblTotalResult.TabIndex = 6;
            this.lblTotalResult.Text = "Rp. 0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(378, 355);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscount.Location = new System.Drawing.Point(545, 321);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(53, 31);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(747, 321);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(203, 51);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Location = new System.Drawing.Point(378, 324);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(116, 25);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount (%):";
            // 
            // btnAddItemPayment
            // 
            this.btnAddItemPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItemPayment.AutoSize = true;
            this.btnAddItemPayment.Location = new System.Drawing.Point(20, 324);
            this.btnAddItemPayment.Name = "btnAddItemPayment";
            this.btnAddItemPayment.Size = new System.Drawing.Size(203, 53);
            this.btnAddItemPayment.TabIndex = 1;
            this.btnAddItemPayment.Text = "Add Item";
            this.btnAddItemPayment.UseVisualStyleBackColor = true;
            this.btnAddItemPayment.Click += new System.EventHandler(this.btnAddItemPayment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payID,
            this.payName,
            this.payPrice,
            this.payQuantity,
            this.payEdit,
            this.payRemove});
            this.dgvPayment.Location = new System.Drawing.Point(3, 3);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 62;
            this.dgvPayment.RowTemplate.Height = 33;
            this.dgvPayment.Size = new System.Drawing.Size(964, 301);
            this.dgvPayment.TabIndex = 0;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            // 
            // payID
            // 
            this.payID.HeaderText = "Item ID";
            this.payID.MinimumWidth = 8;
            this.payID.Name = "payID";
            this.payID.ReadOnly = true;
            this.payID.Width = 150;
            // 
            // payName
            // 
            this.payName.HeaderText = "Name";
            this.payName.MinimumWidth = 8;
            this.payName.Name = "payName";
            this.payName.ReadOnly = true;
            this.payName.Width = 150;
            // 
            // payPrice
            // 
            this.payPrice.HeaderText = "Price";
            this.payPrice.MinimumWidth = 8;
            this.payPrice.Name = "payPrice";
            this.payPrice.ReadOnly = true;
            this.payPrice.Width = 150;
            // 
            // payQuantity
            // 
            this.payQuantity.HeaderText = "Quantity";
            this.payQuantity.MinimumWidth = 8;
            this.payQuantity.Name = "payQuantity";
            this.payQuantity.ReadOnly = true;
            this.payQuantity.Width = 150;
            // 
            // payEdit
            // 
            this.payEdit.HeaderText = "Edit";
            this.payEdit.MinimumWidth = 8;
            this.payEdit.Name = "payEdit";
            this.payEdit.Text = "Edit";
            this.payEdit.UseColumnTextForButtonValue = true;
            this.payEdit.Width = 150;
            // 
            // payRemove
            // 
            this.payRemove.HeaderText = "Remove";
            this.payRemove.MinimumWidth = 8;
            this.payRemove.Name = "payRemove";
            this.payRemove.Text = "Remove";
            this.payRemove.UseColumnTextForButtonValue = true;
            this.payRemove.Width = 150;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnAddItemInventory);
            this.tabInventory.Controls.Add(this.dgvInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 41);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(970, 393);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnAddItemInventory
            // 
            this.btnAddItemInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItemInventory.AutoSize = true;
            this.btnAddItemInventory.Location = new System.Drawing.Point(20, 324);
            this.btnAddItemInventory.Name = "btnAddItemInventory";
            this.btnAddItemInventory.Size = new System.Drawing.Size(203, 53);
            this.btnAddItemInventory.TabIndex = 2;
            this.btnAddItemInventory.Text = "Add Item";
            this.btnAddItemInventory.UseVisualStyleBackColor = true;
            this.btnAddItemInventory.Click += new System.EventHandler(this.btnAddItemInventory_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(3, 3);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 62;
            this.dgvInventory.RowTemplate.Height = 33;
            this.dgvInventory.Size = new System.Drawing.Size(964, 301);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.dgvHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 41);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(970, 393);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 62;
            this.dgvHistory.RowTemplate.Height = 33;
            this.dgvHistory.Size = new System.Drawing.Size(964, 301);
            this.dgvHistory.TabIndex = 1;
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPOS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPOS.Location = new System.Drawing.Point(0, 0);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(455, 65);
            this.lblPOS.TabIndex = 1;
            this.lblPOS.Text = "Point of Sale System";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(763, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(203, 51);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblPOS);
            this.Controls.Add(this.tabCtrl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.POS_Activated);
            this.tabCtrl.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Button btnAddItemPayment;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddItemInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn payID;
        private System.Windows.Forms.DataGridViewTextBoxColumn payName;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn payQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn payEdit;
        private System.Windows.Forms.DataGridViewButtonColumn payRemove;
    }
}