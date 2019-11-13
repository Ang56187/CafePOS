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

namespace CafeSystem.Forms.Cashier
{
    public partial class CheckoutPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontLbl;
        Font fontHeaderLbl;
        Font fontBtn;

        public CheckoutPage()
        {
            InitializeComponent();
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontLbl = new Font(fonts.Families[0], 15.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);

            //set font to components
            lblCheckout.Font = lblOrderTxt.Font = lblOrderNum.Font = fontHeaderLbl;
            btnCash.Font = btnCreditCard.Font = btnCancel.Font = fontBtn;
            lblSubTotalTxt.Font = lblSubTotal.Font = lblSerChargeTxt.Font = lblSerCharge.Font=
            lblSerTaxTxt.Font = lblSerTax.Font =lblRound.Font = lblRoundTxt.Font = lblPaymentOption.Font = fontLbl;
            lblTotalTxt.Font = lblTotal.Font = fontHeaderLbl;


            lblCheckout.Location = new Point((panel1.Width - lblCheckout.Width) / 2, lblCheckout.Location.Y);

            btnCancel.Image = ResizeImage(global::CafeSystem.Properties.Resources.cancel_48, new Size(33, 33));

            for (int i = 0; i <= 20; i++)//TODO: edit this later
            {
                Add_order_item("EFFwdsadawdwopd poqwiwqpoeiwqp", 2, 32);
            }

        }


        private void Add_order_item(string name, int qty ,decimal price)
        {
            Panel panelOrderItem = new Panel();
            FlowLayoutPanel flowPanelNameQty = new FlowLayoutPanel();
            Label lblOrderItemName = new Label();
            Label lblOrderItemQty = new Label();
            Label lblOrderItemPrice = new Label();

            panelOrderItem.Size = new Size(1400,40);

            flowPanelNameQty.Size = new Size(700, 40);
            lblOrderItemName.Dock = System.Windows.Forms.DockStyle.Left;

            lblOrderItemName.Size = new Size(500, 40);
            lblOrderItemName.Font = fontLbl;
            lblOrderItemName.Text = name;
            //lblOrderItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            lblOrderItemQty.Size = new Size(120, 40);
            lblOrderItemQty.Font = fontLbl;
            lblOrderItemQty.Text = "x" + qty;
           // lblOrderItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            lblOrderItemPrice.Size = new Size(400, 40);
            lblOrderItemPrice.Font = fontLbl;
            lblOrderItemPrice.Dock = System.Windows.Forms.DockStyle.Right;
            lblOrderItemPrice.Text = String.Format("{0:C}",(qty*price)) ;            
            lblOrderItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;


            //add everything to panel
            flowPanelNameQty.Controls.Add(lblOrderItemName);            
            flowPanelNameQty.Controls.Add(lblOrderItemQty);

            panelOrderItem.Controls.Add(flowPanelNameQty);
            panelOrderItem.Controls.Add(lblOrderItemPrice);


            //add to flow panel at checkout
            flowPanelOrderItem.Controls.Add(panelOrderItem);
        }

        //for resizing images that are too big
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void flowPanelCheckout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
