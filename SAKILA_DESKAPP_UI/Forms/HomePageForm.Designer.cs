namespace SAKILA_DESKAPP_UI
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRental = new System.Windows.Forms.Panel();
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlFilm = new System.Windows.Forms.Panel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.RentalBttn = new System.Windows.Forms.Button();
            this.FilmBttn = new System.Windows.Forms.Button();
            this.InventoryBttn = new System.Windows.Forms.Button();
            this.CustomerBttn = new System.Windows.Forms.Button();
            this.PaymentBttn = new System.Windows.Forms.Button();
            this.StaffBttn = new System.Windows.Forms.Button();
            this.BttnHam = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnlRental.SuspendLayout();
            this.pnlFilm.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BttnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BttnHam);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1498, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(67, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.pnlRental);
            this.sidebar.Controls.Add(this.pnlFilm);
            this.sidebar.Controls.Add(this.pnlInventory);
            this.sidebar.Controls.Add(this.pnlCustomers);
            this.sidebar.Controls.Add(this.pnlPayment);
            this.sidebar.Controls.Add(this.pnlStaff);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 81);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(306, 766);
            this.sidebar.TabIndex = 1;
            // 
            // pnlRental
            // 
            this.pnlRental.Controls.Add(this.RentalBttn);
            this.pnlRental.Location = new System.Drawing.Point(3, 3);
            this.pnlRental.Name = "pnlRental";
            this.pnlRental.Size = new System.Drawing.Size(303, 102);
            this.pnlRental.TabIndex = 3;
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // pnlFilm
            // 
            this.pnlFilm.Controls.Add(this.FilmBttn);
            this.pnlFilm.Location = new System.Drawing.Point(3, 111);
            this.pnlFilm.Name = "pnlFilm";
            this.pnlFilm.Size = new System.Drawing.Size(303, 70);
            this.pnlFilm.TabIndex = 4;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.InventoryBttn);
            this.pnlInventory.Location = new System.Drawing.Point(3, 187);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(303, 70);
            this.pnlInventory.TabIndex = 5;
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Controls.Add(this.CustomerBttn);
            this.pnlCustomers.Location = new System.Drawing.Point(3, 263);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(303, 90);
            this.pnlCustomers.TabIndex = 5;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.PaymentBttn);
            this.pnlPayment.Location = new System.Drawing.Point(3, 359);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(303, 70);
            this.pnlPayment.TabIndex = 5;
            // 
            // pnlStaff
            // 
            this.pnlStaff.Controls.Add(this.StaffBttn);
            this.pnlStaff.Location = new System.Drawing.Point(3, 435);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(303, 70);
            this.pnlStaff.TabIndex = 5;
            // 
            // RentalBttn
            // 
            this.RentalBttn.BackColor = System.Drawing.SystemColors.MenuText;
            this.RentalBttn.FlatAppearance.BorderSize = 0;
            this.RentalBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalBttn.ForeColor = System.Drawing.Color.Silver;
            this.RentalBttn.Image = ((System.Drawing.Image)(resources.GetObject("RentalBttn.Image")));
            this.RentalBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RentalBttn.Location = new System.Drawing.Point(3, 22);
            this.RentalBttn.Name = "RentalBttn";
            this.RentalBttn.Size = new System.Drawing.Size(232, 55);
            this.RentalBttn.TabIndex = 2;
            this.RentalBttn.Text = "  Rental";
            this.RentalBttn.UseVisualStyleBackColor = false;
            this.RentalBttn.Click += new System.EventHandler(this.RentalBttn_Click);
            // 
            // FilmBttn
            // 
            this.FilmBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.FilmBttn.FlatAppearance.BorderSize = 0;
            this.FilmBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmBttn.ForeColor = System.Drawing.Color.Silver;
            this.FilmBttn.Image = ((System.Drawing.Image)(resources.GetObject("FilmBttn.Image")));
            this.FilmBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilmBttn.Location = new System.Drawing.Point(3, 8);
            this.FilmBttn.Name = "FilmBttn";
            this.FilmBttn.Size = new System.Drawing.Size(232, 55);
            this.FilmBttn.TabIndex = 2;
            this.FilmBttn.Text = "              Film";
            this.FilmBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilmBttn.UseVisualStyleBackColor = false;
            this.FilmBttn.Click += new System.EventHandler(this.FilmBttn_Click);
            // 
            // InventoryBttn
            // 
            this.InventoryBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.InventoryBttn.FlatAppearance.BorderSize = 0;
            this.InventoryBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBttn.ForeColor = System.Drawing.Color.Silver;
            this.InventoryBttn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryBttn.Image")));
            this.InventoryBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBttn.Location = new System.Drawing.Point(3, 7);
            this.InventoryBttn.Name = "InventoryBttn";
            this.InventoryBttn.Size = new System.Drawing.Size(232, 55);
            this.InventoryBttn.TabIndex = 2;
            this.InventoryBttn.Text = "        Inventory";
            this.InventoryBttn.UseVisualStyleBackColor = false;
            this.InventoryBttn.Click += new System.EventHandler(this.InventoryBttn_Click);
            // 
            // CustomerBttn
            // 
            this.CustomerBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.CustomerBttn.FlatAppearance.BorderSize = 0;
            this.CustomerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBttn.ForeColor = System.Drawing.Color.Silver;
            this.CustomerBttn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBttn.Image")));
            this.CustomerBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBttn.Location = new System.Drawing.Point(3, 7);
            this.CustomerBttn.Name = "CustomerBttn";
            this.CustomerBttn.Size = new System.Drawing.Size(232, 55);
            this.CustomerBttn.TabIndex = 2;
            this.CustomerBttn.Text = "         Customers";
            this.CustomerBttn.UseVisualStyleBackColor = false;
            this.CustomerBttn.Click += new System.EventHandler(this.CustomerBttn_Click);
            // 
            // PaymentBttn
            // 
            this.PaymentBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.PaymentBttn.FlatAppearance.BorderSize = 0;
            this.PaymentBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBttn.ForeColor = System.Drawing.Color.Silver;
            this.PaymentBttn.Image = ((System.Drawing.Image)(resources.GetObject("PaymentBttn.Image")));
            this.PaymentBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentBttn.Location = new System.Drawing.Point(3, 8);
            this.PaymentBttn.Name = "PaymentBttn";
            this.PaymentBttn.Size = new System.Drawing.Size(232, 55);
            this.PaymentBttn.TabIndex = 2;
            this.PaymentBttn.Text = "      Payment";
            this.PaymentBttn.UseVisualStyleBackColor = false;
            this.PaymentBttn.Click += new System.EventHandler(this.PaymentBttn_Click);
            // 
            // StaffBttn
            // 
            this.StaffBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.StaffBttn.FlatAppearance.BorderSize = 0;
            this.StaffBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffBttn.ForeColor = System.Drawing.Color.Silver;
            this.StaffBttn.Image = ((System.Drawing.Image)(resources.GetObject("StaffBttn.Image")));
            this.StaffBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBttn.Location = new System.Drawing.Point(3, 8);
            this.StaffBttn.Name = "StaffBttn";
            this.StaffBttn.Size = new System.Drawing.Size(232, 55);
            this.StaffBttn.TabIndex = 2;
            this.StaffBttn.Text = "Staff";
            this.StaffBttn.UseVisualStyleBackColor = false;
            this.StaffBttn.Click += new System.EventHandler(this.StaffBttn_Click);
            // 
            // BttnHam
            // 
            this.BttnHam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnHam.BackgroundImage")));
            this.BttnHam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BttnHam.Location = new System.Drawing.Point(3, 3);
            this.BttnHam.Name = "BttnHam";
            this.BttnHam.Size = new System.Drawing.Size(58, 72);
            this.BttnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BttnHam.TabIndex = 0;
            this.BttnHam.TabStop = false;
            this.BttnHam.Click += new System.EventHandler(this.BttnHam_Click);
            // 
            // HomePage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1498, 847);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "SakilaFlix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.pnlRental.ResumeLayout(false);
            this.pnlFilm.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BttnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox BttnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button RentalBttn;
        private System.Windows.Forms.Panel pnlRental;
        private System.Windows.Forms.Button FilmBttn;
        private System.Windows.Forms.Button InventoryBttn;
        private System.Windows.Forms.Button CustomerBttn;
        private System.Windows.Forms.Button PaymentBttn;
        private System.Windows.Forms.Button StaffBttn;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Panel pnlFilm;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlStaff;
    }
}

