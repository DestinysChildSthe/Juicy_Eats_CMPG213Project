namespace Juicy_Eats_CMPG213Project
{
    partial class frmManager
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeDetailsStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeSalesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(414, 49);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(351, 40);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "Juicy Eats Manager";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.hireEmployeesToolStripMenuItem,
            this.fireEmployeesToolStripMenuItem,
            this.updateEmployeeDetailsStatusToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // hireEmployeesToolStripMenuItem
            // 
            this.hireEmployeesToolStripMenuItem.Name = "hireEmployeesToolStripMenuItem";
            this.hireEmployeesToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.hireEmployeesToolStripMenuItem.Text = "Hire Employees";
            this.hireEmployeesToolStripMenuItem.Click += new System.EventHandler(this.hireEmployeesToolStripMenuItem_Click);
            // 
            // fireEmployeesToolStripMenuItem
            // 
            this.fireEmployeesToolStripMenuItem.Name = "fireEmployeesToolStripMenuItem";
            this.fireEmployeesToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.fireEmployeesToolStripMenuItem.Text = "Fire Employees";
            this.fireEmployeesToolStripMenuItem.Click += new System.EventHandler(this.fireEmployeesToolStripMenuItem_Click);
            // 
            // updateEmployeeDetailsStatusToolStripMenuItem
            // 
            this.updateEmployeeDetailsStatusToolStripMenuItem.Name = "updateEmployeeDetailsStatusToolStripMenuItem";
            this.updateEmployeeDetailsStatusToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.updateEmployeeDetailsStatusToolStripMenuItem.Text = "Update Employee Details/Status";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.purchaseInventoryToolStripMenuItem,
            this.deleteInventoryToolStripMenuItem,
            this.updateInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            // 
            // purchaseInventoryToolStripMenuItem
            // 
            this.purchaseInventoryToolStripMenuItem.Name = "purchaseInventoryToolStripMenuItem";
            this.purchaseInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.purchaseInventoryToolStripMenuItem.Text = "Purchase Inventory";
            this.purchaseInventoryToolStripMenuItem.Click += new System.EventHandler(this.purchaseInventoryToolStripMenuItem_Click);
            // 
            // deleteInventoryToolStripMenuItem
            // 
            this.deleteInventoryToolStripMenuItem.Name = "deleteInventoryToolStripMenuItem";
            this.deleteInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteInventoryToolStripMenuItem.Text = "Delete Inventory";
            this.deleteInventoryToolStripMenuItem.Click += new System.EventHandler(this.deleteInventoryToolStripMenuItem_Click);
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSuppliersToolStripMenuItem,
            this.addSuppliersToolStripMenuItem,
            this.deleteSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // viewSuppliersToolStripMenuItem
            // 
            this.viewSuppliersToolStripMenuItem.Name = "viewSuppliersToolStripMenuItem";
            this.viewSuppliersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewSuppliersToolStripMenuItem.Text = "View Suppliers";
            // 
            // addSuppliersToolStripMenuItem
            // 
            this.addSuppliersToolStripMenuItem.Name = "addSuppliersToolStripMenuItem";
            this.addSuppliersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addSuppliersToolStripMenuItem.Text = "Add Suppliers";
            this.addSuppliersToolStripMenuItem.Click += new System.EventHandler(this.addSuppliersToolStripMenuItem_Click);
            // 
            // deleteSuppliersToolStripMenuItem
            // 
            this.deleteSuppliersToolStripMenuItem.Name = "deleteSuppliersToolStripMenuItem";
            this.deleteSuppliersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteSuppliersToolStripMenuItem.Text = "Delete Suppliers";
            this.deleteSuppliersToolStripMenuItem.Click += new System.EventHandler(this.deleteSuppliersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // requestReportsToolStripMenuItem
            // 
            this.requestReportsToolStripMenuItem.Name = "requestReportsToolStripMenuItem";
            this.requestReportsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.requestReportsToolStripMenuItem.Text = "Request Reports";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeSalesOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // placeSalesOrderToolStripMenuItem
            // 
            this.placeSalesOrderToolStripMenuItem.Name = "placeSalesOrderToolStripMenuItem";
            this.placeSalesOrderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.placeSalesOrderToolStripMenuItem.Text = "Place sales order";
            this.placeSalesOrderToolStripMenuItem.Click += new System.EventHandler(this.placeSalesOrderToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 522);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1086, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManager";
            this.Text = "Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeDetailsStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestReportsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeSalesOrderToolStripMenuItem;
    }
}