using SAKILA_DESKAPP_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAKILA_DESKAPP_UI
{
    public partial class HomePage : Form
    {
        // Define your Colors
        private Color NetflixRed = ColorTranslator.FromHtml("#E50914");
        private Color TextWhite = Color.White;

        // Track the currently selected button
        private Button currentBtn;

        private RentalForms rentalForm = null;
        private FilmForms filmForm = null;      
        private InventoryForms inventoryForm = null;
        private PaymentForms paymentForm = null;
        private CustomersForms customersForm = null;
        private StaffForms staffForm = null;

        public HomePage()
        {
            InitializeComponent();

            // 2. Setup all buttons with the new Logic
            SetupMenuButton(RentalBttn);
            SetupMenuButton(CustomerBttn);
            SetupMenuButton(PaymentBttn);
            SetupMenuButton(InventoryBttn);
            SetupMenuButton(StaffBttn);
            SetupMenuButton(FilmBttn);

            // Optional: Set 'Rental' as the default active button when app starts
            RentalBttn.PerformClick();
        }

        bool SidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 58)
                {
                    SidebarExpand = false;
                    SidebarTransition.Stop();

                    pnlRental.Width = sidebar.Width;
                    pnlFilm.Width = sidebar.Width;
                    pnlInventory.Width = sidebar.Width;
                    pnlCustomers.Width = sidebar.Width;
                    pnlPayment.Width = sidebar.Width;
                    pnlStaff.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 303)
                {
                    SidebarExpand = true;
                    SidebarTransition.Stop();

                    pnlRental.Width = sidebar.Width;
                    pnlFilm.Width = sidebar.Width;
                    pnlInventory.Width = sidebar.Width;
                    pnlCustomers.Width = sidebar.Width;
                    pnlPayment.Width = sidebar.Width;
                    pnlStaff.Width = sidebar.Width;

                }
            }
        }

        private void BttnHam_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void SetupMenuButton(Button btn)
        {
            // 1. Fix the "White Flash" when clicking (Optional but recommended)
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;

            // 2. MOUSE ENTER (Hover triggers Red)
            btn.MouseEnter += (sender, e) =>
            {
                btn.ForeColor = NetflixRed;
            };

            // 3. MOUSE LEAVE (Return to White UNLESS it is the Active button)
            btn.MouseLeave += (sender, e) =>
            {
                if (currentBtn != btn)
                {
                    btn.ForeColor = TextWhite;
                }
            };

            // 4. CLICK (Sets it as Active so it STAYS Red)
            btn.Click += (sender, e) =>
            {
                // Reset the previous button to White (if there was one)
                if (currentBtn != null && currentBtn != btn)
                {
                    currentBtn.ForeColor = TextWhite;
                }

                // Set this button as the new Active one
                currentBtn = btn;
                currentBtn.ForeColor = NetflixRed;
            };
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void RentalBttn_Click(object sender, EventArgs e)
        {
            if (rentalForm == null)
            {
                rentalForm = new RentalForms();
                rentalForm.FormClosed += RentalForm_FormClosed; // Connect the close event
                rentalForm.MdiParent = this;
                rentalForm.Dock = DockStyle.Fill;
                rentalForm.Show();
            }
            else
            {
                // If already open, just bring it to front
                rentalForm.Activate();
            }

        }

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rentalForm = null;
        }

        private void FilmBttn_Click(object sender, EventArgs e)
        {
            if (filmForm == null)
            {
                filmForm = new FilmForms(); // Make sure this matches your actual Class name
                filmForm.FormClosed += FilmForm_FormClosed;
                filmForm.MdiParent = this;
                filmForm.Dock = DockStyle.Fill;
                filmForm.Show();
            }
            else
            {
                filmForm.Activate();
            }
        }

        private void FilmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            filmForm = null;
        }

        private void InventoryBttn_Click(object sender, EventArgs e)
        {
            if (inventoryForm == null)
            {
                inventoryForm = new InventoryForms();
                inventoryForm.FormClosed += (s, args) => inventoryForm = null;

                inventoryForm.MdiParent = this;
                inventoryForm.Dock = DockStyle.Fill;
                inventoryForm.Show();
            }
            else
            {
                inventoryForm.Activate();
            }
        }

        private void CustomerBttn_Click(object sender, EventArgs e)
        {
            if (customersForm == null)
            {
                customersForm = new CustomersForms();
                customersForm.FormClosed += (s, args) => customersForm = null;

                customersForm.MdiParent = this;
                customersForm.Dock = DockStyle.Fill;
                customersForm.Show();
            }
            else
            {
                customersForm.Activate();
            }
        }

        private void PaymentBttn_Click(object sender, EventArgs e)
        {
            if (paymentForm == null)
            {
                paymentForm = new PaymentForms();
                paymentForm.FormClosed += (s, args) => paymentForm = null;

                paymentForm.MdiParent = this;
                paymentForm.Dock = DockStyle.Fill;
                paymentForm.Show();
            }
            else
            {
                paymentForm.Activate();
            }
        }

        private void StaffBttn_Click(object sender, EventArgs e)
        {
            if (staffForm == null)
            {
                staffForm = new StaffForms();
                staffForm.FormClosed += (s, args) => staffForm = null;

                staffForm.MdiParent = this;
                staffForm.Dock = DockStyle.Fill;
                staffForm.Show();
            }
            else
            {
                staffForm.Activate();
            }
        }

    }
}