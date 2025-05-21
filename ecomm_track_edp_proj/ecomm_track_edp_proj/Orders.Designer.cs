namespace ecomm_track_edp_proj
{
    partial class Orders
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridOrders;

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtOrderID = new TextBox();
            txtUserID = new TextBox();
            txtOrderDate = new TextBox();
            txtTotalAmount = new TextBox();
            txtOrderStatus = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridUsers = new DataGridView();
            dataGridOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            SuspendLayout();
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(20, 20);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.PlaceholderText = "Order ID";
            txtOrderID.Size = new Size(120, 23);
            txtOrderID.TabIndex = 0;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(150, 20);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "User ID";
            txtUserID.Size = new Size(120, 23);
            txtUserID.TabIndex = 1;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(280, 20);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.PlaceholderText = "Order Date";
            txtOrderDate.Size = new Size(120, 23);
            txtOrderDate.TabIndex = 2;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(410, 20);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.PlaceholderText = "Total Amount";
            txtTotalAmount.Size = new Size(120, 23);
            txtTotalAmount.TabIndex = 3;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new Point(540, 20);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.PlaceholderText = "Order Status";
            txtOrderStatus.Size = new Size(120, 23);
            txtOrderStatus.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 25);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridUsers
            // 
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.GridColor = SystemColors.ControlDark;
            dataGridUsers.Location = new Point(20, 100);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.Size = new Size(640, 200);
            dataGridUsers.TabIndex = 8;
            // 
            // dataGridOrders
            // 
            dataGridOrders.Location = new Point(20, 100);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.Size = new Size(640, 200);
            dataGridOrders.TabIndex = 0;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(700, 320);
            Controls.Add(dataGridOrders);
            Controls.Add(txtOrderID);
            Controls.Add(txtUserID);
            Controls.Add(txtOrderDate);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtOrderStatus);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridUsers);
            Name = "Orders";
            Text = "Orders Management";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
