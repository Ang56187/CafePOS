using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        //set total amount to be paid
        decimal totalAmount = 0;

        //test
        public PaymentPage()
        {
            InitializeComponent();
        }

        //get values from the checkoutpage
        public PaymentPage(object checkoutList,decimal total)
        {
            InitializeComponent();

            if (orderItems is ShoppingCart)
            {
                orderItems = ((ShoppingCart)checkoutList);
            }

            totalAmount = total;

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
                lblLeftAmountTxt.Font = lblPaymentTxt.Font = fontHeaderLbl;
             txtBoxAmount.Font = lblLeftAmount.Font = fontLbl;
            btnBack.Font =btnProceed.Font = fontBtn;

            //set image for buttons
            btnBack.Image= resizeImage(global::CafeSystem.Properties.Resources.arrow_left_white_48, new Size(33, 33));
            btnProceed.Image = resizeImage(global::CafeSystem.Properties.Resources.arrow_right_white_48, new Size(33, 33));

            //set mask for text box for entering amount
            txtBoxAmount.Mask = "$999,990.00";

            //set amount to string
            lblLeftAmount.Text = totalAmount.ToString();
        }


        //for resizing images that are too big
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        //////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////
    }
}
