
namespace POS
{
    partial class historyForm
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIDResult = new System.Windows.Forms.Label();
            this.lblDiscountResult = new System.Windows.Forms.Label();
            this.lblDateResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(12, 147);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 62;
            this.dgvInvoice.RowTemplate.Height = 33;
            this.dgvInvoice.Size = new System.Drawing.Size(714, 291);
            this.dgvInvoice.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 32);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Invoice ID:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Location = new System.Drawing.Point(12, 55);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 32);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblIDResult
            // 
            this.lblIDResult.AutoSize = true;
            this.lblIDResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDResult.Location = new System.Drawing.Point(184, 9);
            this.lblIDResult.Name = "lblIDResult";
            this.lblIDResult.Size = new System.Drawing.Size(37, 32);
            this.lblIDResult.TabIndex = 4;
            this.lblIDResult.Text = "ID";
            // 
            // lblDiscountResult
            // 
            this.lblDiscountResult.AutoSize = true;
            this.lblDiscountResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountResult.Location = new System.Drawing.Point(184, 55);
            this.lblDiscountResult.Name = "lblDiscountResult";
            this.lblDiscountResult.Size = new System.Drawing.Size(47, 32);
            this.lblDiscountResult.TabIndex = 5;
            this.lblDiscountResult.Text = "0%";
            // 
            // lblDateResult
            // 
            this.lblDateResult.AutoSize = true;
            this.lblDateResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateResult.Location = new System.Drawing.Point(184, 101);
            this.lblDateResult.Name = "lblDateResult";
            this.lblDateResult.Size = new System.Drawing.Size(138, 32);
            this.lblDateResult.TabIndex = 6;
            this.lblDateResult.Text = "01-01-0001";
            // 
            // historyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.lblDateResult);
            this.Controls.Add(this.lblDiscountResult);
            this.Controls.Add(this.lblIDResult);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "historyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIDResult;
        private System.Windows.Forms.Label lblDiscountResult;
        private System.Windows.Forms.Label lblDateResult;
    }
}