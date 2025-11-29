using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAKILA_DESKAPP_UI.Forms
{
    public partial class StaffForms: Form
    {
        public StaffForms()
        {
            InitializeComponent();

            // Must be first
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Must be after border removal
            this.WindowState = FormWindowState.Maximized;
        }

        private void StaffForms_Load(object sender, EventArgs e)
        {

        }
    }
}
