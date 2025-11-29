namespace SAKILA_DESKAPP_UI.Forms
{
    partial class InventoryForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbboxFilms = new System.Windows.Forms.ComboBox();
            this.chckboxAvail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(734, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtSearch.Location = new System.Drawing.Point(47, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 36);
            this.txtSearch.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1505, 717);
            this.dataGridView1.TabIndex = 12;
            // 
            // cmbboxFilms
            // 
            this.cmbboxFilms.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cmbboxFilms.FormattingEnabled = true;
            this.cmbboxFilms.Location = new System.Drawing.Point(269, 38);
            this.cmbboxFilms.Name = "cmbboxFilms";
            this.cmbboxFilms.Size = new System.Drawing.Size(201, 36);
            this.cmbboxFilms.TabIndex = 15;
            // 
            // chckboxAvail
            // 
            this.chckboxAvail.AutoSize = true;
            this.chckboxAvail.FlatAppearance.BorderSize = 3;
            this.chckboxAvail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chckboxAvail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckboxAvail.ForeColor = System.Drawing.Color.Green;
            this.chckboxAvail.Location = new System.Drawing.Point(493, 38);
            this.chckboxAvail.Name = "chckboxAvail";
            this.chckboxAvail.Size = new System.Drawing.Size(224, 34);
            this.chckboxAvail.TabIndex = 16;
            this.chckboxAvail.Text = "Show Only Available";
            this.chckboxAvail.UseVisualStyleBackColor = true;
            // 
            // InventoryForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAKILA_DESKAPP_UI.Properties.Resources.MovieRental;
            this.ClientSize = new System.Drawing.Size(1599, 850);
            this.Controls.Add(this.chckboxAvail);
            this.Controls.Add(this.cmbboxFilms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForms";
            this.Text = "InventoryForms";
            this.Load += new System.EventHandler(this.InventoryForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbboxFilms;
        private System.Windows.Forms.CheckBox chckboxAvail;
    }
}