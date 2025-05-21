namespace ecomm_track_edp_proj
{
    partial class Payments
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridPayments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void txtOrderID_Enter(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "OrderID")
            {
                txtOrderID.Text = "";
                txtOrderID.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtOrderID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                txtOrderID.Text = "OrderID";
                txtOrderID.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPaymentDate_Enter(object sender, EventArgs e)
        {
            if (txtPaymentDate.Text == "PaymentDate")
            {
                txtPaymentDate.Text = "";
                txtPaymentDate.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPaymentDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentDate.Text))
            {
                txtPaymentDate.Text = "PaymentDate";
                txtPaymentDate.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount.Text == "Amount")
            {
                txtAmount.Text = "";
                txtAmount.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                txtAmount.Text = "Amount";
                txtAmount.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void InitializeComponent()
        {
            txtOrderID = new TextBox();
            txtPaymentDate = new TextBox();
            txtAmount = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridPayments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).BeginInit();
            SuspendLayout();
            // 
            // txtOrderID
            // 
            txtOrderID.ForeColor = Color.Gray;
            txtOrderID.Location = new Point(30, 20);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(120, 23);
            txtOrderID.TabIndex = 0;
            txtOrderID.Text = "OrderID";
            txtOrderID.Enter += txtOrderID_Enter;
            txtOrderID.Leave += txtOrderID_Leave;
            // 
            // txtPaymentDate
            // 
            txtPaymentDate.ForeColor = Color.Gray;
            txtPaymentDate.Location = new Point(160, 20);
            txtPaymentDate.Name = "txtPaymentDate";
            txtPaymentDate.Size = new Size(120, 23);
            txtPaymentDate.TabIndex = 1;
            txtPaymentDate.Text = "PaymentDate";
            txtPaymentDate.Enter += txtPaymentDate_Enter;
            txtPaymentDate.Leave += txtPaymentDate_Leave;
            // 
            // txtAmount
            // 
            txtAmount.ForeColor = Color.Gray;
            txtAmount.Location = new Point(290, 20);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(120, 23);
            txtAmount.TabIndex = 2;
            txtAmount.Text = "Amount";
            txtAmount.Enter += txtAmount_Enter;
            txtAmount.Leave += txtAmount_Leave;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(190, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(270, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 27);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dataGridPayments
            // 
            dataGridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPayments.Location = new Point(30, 110);
            dataGridPayments.Name = "dataGridPayments";
            dataGridPayments.Size = new Size(740, 300);
            dataGridPayments.TabIndex = 0;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(txtOrderID);
            Controls.Add(txtPaymentDate);
            Controls.Add(txtAmount);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dataGridPayments);
            Name = "Payments";
            Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
