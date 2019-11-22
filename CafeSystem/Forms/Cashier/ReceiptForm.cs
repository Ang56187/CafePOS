using CafeSystem.Backend.Objects;
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

namespace CafeSystem.Forms.Cashier
{

    public partial class ReceiptForm : Form //TODO: create the order num generator later
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontLbl;
        Font fontHeaderLbl;
        Font fontBtn;

        //later create order number, but for now we hard code it...
        private String orderNum = "232342";

        //create and save order made
        Order orderDetail;

        //get arguments from form constructors
        ShoppingCart finalItemList = new ShoppingCart();
        Payment payment;
        Tax tax;
        User user;
        private decimal totalAmount;
        private decimal paidAmount;
        private String dineOrTakeAway;


        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(object user,object itemList, decimal total, String dineOrTakeAway,Object payment,object tax)
        {
            InitializeComponent();

            if (user is User)
            {
                this.user = ((User)user);
            }
            if (itemList is ShoppingCart)
            {
                finalItemList = ((ShoppingCart)itemList);
            }

            if (tax is Tax)
            {
                this.tax = ((Tax)tax);
            }
            
            if (payment is Cash)
            {
                this.payment = ((Cash)payment);
                totalAmount = ((Cash)payment).TotalAmt;
                paidAmount = ((Cash)this.payment).PaidAmt;
            }
            else if (payment is CreditCard)
            {
                this.payment = ((CreditCard)payment);
                totalAmount = ((CreditCard)payment).TotalAmt;
                paidAmount = ((CreditCard)payment).PaidAmt;
            }

            totalAmount = total;
            this.dineOrTakeAway = dineOrTakeAway;


            //save receipt as order object
            orderDetail = new Order(orderNum, this.user, finalItemList.CartList, this.tax, this.payment,dineOrTakeAway);

            OrderCollection.OrderList.Add(orderDetail);
        }

        private void ReceiptPage_Load(object sender, EventArgs e)
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
            lblPayComplete.Font = lblOrderTxt.Font = lblOrderNum.Font = fontHeaderLbl;
            btnLogOut.Font = btnNextOrder.Font = btnEndDay.Font = btnPrintReceipt.Font =  fontBtn;
            lblReceivedTxt.Font = lblReceived.Font = lblTotalTxt.Font = lblTotal.Font = lblChangeTxt.Font = lblChange.Font = fontLbl;
            lblNowWat.Font =  new Font(fonts.Families[0], 20.0F);


            //resize the image of button
            btnNextOrder.Image = ResizeImage(global::CafeSystem.Properties.Resources.create_48, new Size(35, 33));
            btnEndDay.Image = ResizeImage(global::CafeSystem.Properties.Resources.bill_48, new Size(35, 33));
            btnPrintReceipt.Image = ResizeImage(global::CafeSystem.Properties.Resources.printer_48, new Size(35, 33));

            lblTotal.Text = String.Format("{0:C}", totalAmount);
            lblReceived.Text = String.Format("{0:C}", paidAmount);
            lblChange.Text = String.Format("{0:C}",paidAmount-totalAmount);

        }

        //for resizing images that are too big
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        /////////////////////////////////////////////events for components///////////////////////////////
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            printPreviewDialogReceipt.Document = printDocumentReceipt;
            printPreviewDialogReceipt.ShowDialog();
        }

        private void printDocumentReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);

            int counter = 4;

            decimal subTotal = 0;

            float linesPerPage = 0;
            float xPos = 0;
            float yPos = 0;

            float centerMargin = e.MarginBounds.Width/2;
            float topMargin = e.MarginBounds.Top;

            

            float thirdRowlineYPos = 50 + (3 * printFont.GetHeight(e.Graphics));


            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);


            //format of organizing 40 +(count * printFont.GetHeight)
            //count = the row where string located
            //printfont.GetHeight = get height of the font size
            e.Graphics.DrawString("Sunway Cafe", new Font("Arial", 20, FontStyle.Bold), Brushes.Black,new PointF(centerMargin,20));

            //row 1
            e.Graphics.DrawString("Order number: " + orderDetail.OrderNum,printFont
                ,Brushes.Black,new PointF(10, 40 + printFont.GetHeight(e.Graphics)));
            //row 2
            e.Graphics.DrawString("Date printed: "+orderDetail.OrderDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"), printFont
                , Brushes.Black, new PointF(10, 40 + (2*printFont.GetHeight(e.Graphics))));
            //row 3
            e.Graphics.DrawLine(new Pen(Color.Black), 0, thirdRowlineYPos, 1000, thirdRowlineYPos);

            //row 4 onwards
            foreach (Item item in orderDetail.OrderItems)
            {
                e.Graphics.DrawString(item.ToString(), printFont , Brushes.Black, new PointF(10, 45 + (counter * printFont.GetHeight(e.Graphics))));
                subTotal += item.Price;
                counter += 1;//increment to next row
            }

            e.Graphics.DrawLine(new Pen(Color.Black), 0, 50 + (counter * printFont.GetHeight(e.Graphics)), 1000, 50 + (counter * printFont.GetHeight(e.Graphics)));
            counter+=1;

            e.Graphics.DrawString(String.Format("Subtotal:                    {0:C}", subTotal), printFont, Brushes.Black, new PointF(10, 50 + (counter * printFont.GetHeight(e.Graphics)))); ;
            counter += 1;

            e.Graphics.DrawString(orderDetail.OrderTax.ToString(), printFont, Brushes.Black, new PointF(10, 50 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 2;

            e.Graphics.DrawString(orderDetail.OrderPayment.ToString(), printFont, Brushes.Black, new PointF(10, 70 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 4;

            e.Graphics.DrawString(orderDetail.OrderUser.ToString(), printFont, Brushes.Black, new PointF(10, 100 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 1;

        }

        private void btnNextOrder_Click(object sender, EventArgs e)
        {
            CashierMenuForm cashierPage = new CashierMenuForm(user);
            this.Hide();
            cashierPage.ShowDialog();
            this.Close();
        }


        private void btnEndDay_Click(object sender, EventArgs e)///TODO: changed later, for now i use this to test kitchen page
        {
            BusinessSummaryForm busSumPage = new BusinessSummaryForm();
            this.Hide();
            busSumPage.ShowDialog();
            this.Close();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
