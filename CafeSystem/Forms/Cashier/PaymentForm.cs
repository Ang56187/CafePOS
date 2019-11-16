using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSystem.Backend;
using CafeSystem.Backend.Objects;


namespace CafeSystem.Forms.Cashier
{
    public partial class PaymentPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontLbl;
        Font fontHeaderLbl;
        Font fontBtn;

        // passed argument from checkout page
        ShoppingCart orderItems = new ShoppingCart();
        Cash cashPay;
        private String dineOrTakeAway;
        private decimal serCharge;
        private decimal serTax;

        //set total amount to be paid
        decimal totalAmount  = 0;

        //test
        public PaymentPage()
        {
            InitializeComponent();
        }

        //get values from the checkoutpage
        public PaymentPage(object checkoutList,decimal total,String dineOrTakeAway)
        {
            InitializeComponent();

            if (orderItems is ShoppingCart)
            {
                orderItems = ((ShoppingCart)checkoutList);
            }

            totalAmount = total;
            this.dineOrTakeAway = dineOrTakeAway;
            cashPay = new Cash(totalAmount, 0);

        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {

            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontLbl = new Font(fonts.Families[0], 18.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);

            //set font to components
            lblCashPayment.Font = lblOrderTxt.Font = lblOrderNum.Font =
                lblTotalAmtTxt.Font = lblPaymentTxt.Font = fontHeaderLbl;
             txtBoxAmount.Font = lblTotalAmt.Font = lblError.Font = fontLbl;
            btnBack.Font =btnProceed.Font = fontBtn;

            //set image for buttons
            btnBack.Image= ResizeImage(global::CafeSystem.Properties.Resources.arrow_left_white_48, new Size(33, 33));
            btnProceed.Image = ResizeImage(global::CafeSystem.Properties.Resources.arrow_right_white_48, new Size(33, 33));

            //set amount to string
            lblTotalAmt.Text = String.Format("{0:C}", totalAmount);

            lblError.Hide();

        }


        //for resizing images that are too big
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        ///////////////////////////////////////////////////events for components////////////////////////////////////////////////////////////

        private void txtBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal amount = 0;

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46;//8 is backspace ,46 is .

            if (e.KeyChar == (char)46 && txtBoxAmount.Text.IndexOf(".")> -1)
            {
                e.Handled = true;
            }

            // no dots in beginning
            if (txtBoxAmount.Text.StartsWith("."))
            {
                txtBoxAmount.Text = "";
            }

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            decimal value = 0;

            //checks if entered value can be decimal or not
            if (decimal.TryParse(txtBoxAmount.Text, out value))
            {
                txtBoxAmount.Text = String.Format("{0:0.00}", value);
                //setting paid amount
                cashPay.PaidAmt = value;
            }

            //check if amount fully paid
            if (cashPay.IsPaid(totalAmount))
            {
                lblError.Hide();
            }
            else
                lblError.Show();
                lblError.Text = "Paid amount is less than total amount.";
        }

        private void txtBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProceed_Click(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CheckoutPage checkoutPage = new CheckoutPage(orderItems, dineOrTakeAway);
            this.Hide();
            checkoutPage.ShowDialog();
            this.Close();
        }




        //////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////
    }
}
