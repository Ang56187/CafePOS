﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSystem.Backend.Objects;
using CafeSystem.Backend;

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
        Font fontTakeDine;

        //passed arguments from the cashier menu page
        ShoppingCart orderItems = new ShoppingCart();

        //set value to labels controls
        String dineOrTakeAway = "";
        decimal subTotal = 0;
        decimal serTax = 0;
        decimal total = 0;
        decimal serCharge = 0;

        //test
        public CheckoutPage()
        {
            InitializeComponent();
        }

        //constructor to receive the passed shopping cart, user identity
        public CheckoutPage(object cartItem,String dineOrTakeAway)
        {
            InitializeComponent();
            
            if (cartItem is ShoppingCart)
            {
                orderItems = ((ShoppingCart)cartItem);
            }

            this.dineOrTakeAway = dineOrTakeAway;
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
            fontTakeDine = new Font(fonts.Families[0], 20.0F, FontStyle.Underline) ;
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);

            //set font to components
            lblCheckout.Font = lblOrderTxt.Font = lblOrderNum.Font = lblTotalTxt.Font = lblTotal.Font = 
                new Font(fonts.Families[0], 20.0F, FontStyle.Bold); ;
            lblTakeDine.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Underline);

            btnCash.Font = btnCreditCard.Font = btnCancel.Font = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);

            lblSubTotalTxt.Font = lblSubTotal.Font = lblSerChargeTxt.Font = lblSerCharge.Font=
            lblSerTaxTxt.Font = lblSerTax.Font =lblRound.Font = lblRoundTxt.Font = lblPaymentOption.Font = new Font(fonts.Families[0], 15.0F);

            //set label the text of either take away of dining in
            lblTakeDine.Text = dineOrTakeAway;

            //set label to middle of panel
            lblCheckout.Location = new Point((panel1.Width - lblCheckout.Width) / 2, lblCheckout.Location.Y);

            //set resized image
            btnCancel.Image = ResizeImage(global::CafeSystem.Properties.Resources.cancel_48, new Size(33, 33));

            //add item to order item list
            foreach (Item item in orderItems.CartList)
            {
                Add_order_item(item.Name, item.Quantity, item.Price);
            }

            foreach (Item item in orderItems.CartList)
            {
                subTotal += item.Price * item.Quantity;
                serTax = subTotal * 6 / 100;
                serCharge = subTotal * 10 / 100;
            }

            lblSubTotal.Text = String.Format("{0:C}", subTotal);
            lblSerTax.Text = String.Format("{0:C}", serTax);
            lblSerCharge.Text = String.Format("{0:C}",serCharge);

            //depending if dine-in or take away option selected, if take away, no service charge needed
            if (dineOrTakeAway.Equals("Dine-in"))
            {
                lblTotal.Text = String.Format("{0:C}", subTotal + serTax + serCharge);
                total = subTotal + serTax + serCharge;
            }
            else if (dineOrTakeAway.Equals("Take away"))
            {
                lblSerCharge.Hide();
                lblSerChargeTxt.Hide();
                lblTotal.Text = String.Format("{0:C}", subTotal + serTax);
                total = subTotal + serTax;
            }

        }


        private void Add_order_item(string name, int qty ,decimal price)
        {
            Panel panelOrderItem = new Panel();
            FlowLayoutPanel flowPanelNameQty = new FlowLayoutPanel();
            Label lblOrderItemName = new Label();
            Label lblOrderItemQty = new Label();
            Label lblOrderItemPrice = new Label();

            panelOrderItem.Size = new Size(1360,40);

            flowPanelNameQty.Size = new Size(700, 40);
            lblOrderItemName.Dock = System.Windows.Forms.DockStyle.Left;

            lblOrderItemName.Size = new Size(300, 40);
            lblOrderItemName.Font = fontLbl;
            lblOrderItemName.Text = name;
            //lblOrderItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            lblOrderItemQty.Size = new Size(120, 40);
            lblOrderItemQty.Font = fontLbl;
            lblOrderItemQty.Text = "x" + qty;
           // lblOrderItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            lblOrderItemPrice.Size = new Size(390, 40);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CashierMenuPage menuPage = new CashierMenuPage(orderItems);
            this.Hide();
            menuPage.ShowDialog();
            this.Close(); //close previous form
        }
    }
}
