using CafeSystem.Backend;
using CafeSystem.Backend.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Forms
{
    public partial class BusinessSummaryForm : Form
    {

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font fontBtn;
        Font fontTxtBox;
        Font fontHeaderLbl;
        Font fontHeaderLblMini;
        Font fontLbl;

        //store all picbox for top foods/beverages to have its image set later
        List<PictureBox> picBoxFoodList = new List<PictureBox>();
        List<PictureBox> picBoxBeverageList = new List<PictureBox>();

        //store all labels for top 4 foods
        List<Label> lblFoodNameList = new List<Label>();
        List<Label> lblFoodQtyList = new List<Label>();

        //store all labels for top 4 beverages
        List<Label> lblBeverageNameList = new List<Label>();
        List<Label> lblBeverageQtyList = new List<Label>();


        //get the orders created
        List<Order> orderList = new OrderCollection().OrderList;

        //get summary of details of todays orders created
        DailyOrderSummary orderSummary = new DailyOrderSummary();

        //get all items in the item menu
        MenuCatalogue menuList = new MenuCatalogue();

        //count the total orders made today
        List<Order> todayOrderList = new List<Order>();
        //count total tax collected today
        private decimal serTaxAmtToday = 0;
        //count total charge collected today
        private decimal serChargeAmtToday = 0;
        //count total revenue colledted
        private decimal totalRevenueAmtToday = 0;


        public BusinessSummaryForm()
        {
            InitializeComponent();
        }

        private void BusinessSummaryForm_Load(object sender, EventArgs e)
        {
            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontBtn = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            fontHeaderLblMini = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            fontTxtBox = new Font(fonts.Families[0], 18.0F);
            fontLbl = new Font(fonts.Families[0], 13.0F);


            lblBusinessSummary.Font = fontHeaderLbl;

            //for top food fonts
            lblTopFood.Font = fontHeaderLblMini;
            lblFoodName1.Font = lblFoodName2.Font = lblFoodName3.Font = lblFoodName4.Font =
            lblFoodQty1.Font = lblFoodQty2.Font = lblFoodQty3.Font = lblFoodQty4.Font = fontLbl;

            //for top beverage fonts
            lblTopBeverage.Font = fontHeaderLblMini;
            lblBeverageName1.Font = lblBeverageName2.Font = lblBeverageName3.Font = lblBeverageName4.Font =
            lblBeverageQty1.Font = lblBeverageQty2.Font = lblBeverageQty3.Font = lblBeverageQty4.Font = fontLbl;

            //for list view fonts
            lblOverallFoodTxt.Font = fontHeaderLblMini;
            lblOverallBeverageTxt.Font = fontHeaderLblMini;

            //for item fonts
            lblSerChargeTxt.Font = lblSerTaxTxt.Font = lblTotalOrderTxt.Font = lblTotalRevenueTxt.Font = fontHeaderLblMini;
            lblSerCharge.Font = lblSerTax.Font = lblTotalOrder.Font = lblTotalRevenue.Font = fontLbl;

            //for button fonts
            btnClose.Font = btnPrint.Font = fontBtn;

            //image for buttons
            btnClose.Image = ResizeImage(global::CafeSystem.Properties.Resources.cancel_48, new Size(35, 35));
            btnPrint.Image = ResizeImage(global::CafeSystem.Properties.Resources.printer_48, new Size(35, 35));



            //calculate total items sold
            foreach (Order order in orderList)
            {
                foreach (Item orderItem in order.OrderItems)
                {
                    foreach (Item item in menuList.MenuList)
                    {
                        if (orderItem.Name.Equals(item.Name) && (order.OrderDate.Date == DateTime.Today.Date))
                        {
                            item.Quantity += orderItem.Quantity;
                        }
                    }

                }
            }//end foreach

            //add picboxes to list for the top 4
            //for food
            picBoxFoodList.Add(picBoxFood1);
            picBoxFoodList.Add(picBoxFood2);
            picBoxFoodList.Add(picBoxFood3);
            picBoxFoodList.Add(picBoxFood4);

            //for beverages
            picBoxBeverageList.Add(picBoxBeverage1);
            picBoxBeverageList.Add(picBoxBeverage2);
            picBoxBeverageList.Add(picBoxBeverage3);
            picBoxBeverageList.Add(picBoxBeverage4);

            //set labels to list for the top 4
            //food name
            lblFoodNameList.Add(lblFoodName1);
            lblFoodNameList.Add(lblFoodName2);
            lblFoodNameList.Add(lblFoodName3);
            lblFoodNameList.Add(lblFoodName4);

            //food qty
            lblFoodQtyList.Add(lblFoodQty1);
            lblFoodQtyList.Add(lblFoodQty2);
            lblFoodQtyList.Add(lblFoodQty3);
            lblFoodQtyList.Add(lblFoodQty4);

            //beverage label
            lblBeverageNameList.Add(lblBeverageName1);
            lblBeverageNameList.Add(lblBeverageName2);
            lblBeverageNameList.Add(lblBeverageName3);
            lblBeverageNameList.Add(lblBeverageName4);

            //beverage qty
            lblBeverageQtyList.Add(lblBeverageQty1);
            lblBeverageQtyList.Add(lblBeverageQty2);
            lblBeverageQtyList.Add(lblBeverageQty3);
            lblBeverageQtyList.Add(lblBeverageQty4);

            //setting the top 4 picture boxes
            SetTopPicBox(menuList.TopFoodList(), picBoxFoodList);
            SetTopPicBox(menuList.TopBeverageList(), picBoxBeverageList);

            //setting the top 4 labels(name and qty)
            SetTopLabels(menuList.TopFoodList(), lblFoodNameList, lblFoodQtyList);
            SetTopLabels(menuList.TopBeverageList(), lblBeverageNameList, lblBeverageQtyList);


            //add items to the list views
            for (int i = 0; i < menuList.TopFoodList().Count();i++)
            {
                ListViewItem listItem = new ListViewItem(new[] { (i+1).ToString(),
                    menuList.TopFoodList()[i].Name,
                    String.Format("{0:C}",menuList.TopFoodList()[i].Price),
                    menuList.TopFoodList()[i].Quantity.ToString()});

                listViewFood.Items.Add(listItem);
            }

            for (int i = 0; i < menuList.TopBeverageList().Count(); i++)
            {
                ListViewItem listItem = new ListViewItem(new[] { (i+1).ToString(), 
                    menuList.TopBeverageList()[i].Name,
                    String.Format("{0:C}",menuList.TopBeverageList()[i].Price),
                    menuList.TopBeverageList()[i].Quantity.ToString()});

                listViewBeverage.Items.Add(listItem);
            }

            //update the data obtained
            orderSummary.GenerateTodayOrdersData();

            lblTotalOrder.Text = orderSummary.OrderListToday.Count().ToString();
            lblSerTax.Text = String.Format("{0:C}", orderSummary.SerTaxAmtToday);
            lblSerCharge.Text = String.Format("{0:C}", orderSummary.SerChargeAmtToday);
            lblTotalRevenue.Text = String.Format("{0:C}", orderSummary.TotalRevenueAmtToday);


        }//end form_load

        private void SetTopPicBox(List<Item> itemList, List<PictureBox> picBoxList)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (itemList[i].Quantity >= 1)
                {
                    //String imageName = topFoodList.AsEnumerable().ElementAt(1).Image;//if kept the enumerable class type
                    String imageName = itemList[i].Image;
                    SetImage(imageName, picBoxList[i]);
                }
            }

        }

        private void SetTopLabels(List<Item> itemList, List<Label> lblNameList, List<Label> lblQtyList)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (itemList[i].Quantity >= 1)
                {
                    lblNameList[i].Text = i + 1 + ". " + itemList[i].Name;
                    lblQtyList[i].Text = itemList[i].Quantity.ToString() + " sold";
                }
                else
                {
                    lblNameList[i].Text = i + 1 + ". " + "None";
                    lblQtyList[i].Text = itemList[i].Quantity.ToString() + " sold";
                }
            }

        }

        private void SetImage(String imageURL, PictureBox picBox)
        {
            //set values of components through arguments
            //to find for file image
            String fileLocation = Path.Combine(Environment.CurrentDirectory, "..", "..", "Resource", "Images", "MenuItems", imageURL);
            picBox.Image = ResizeImage(Image.FromFile(fileLocation), new Size(151, 105));
        }

        //for resizing images that are too big
        private Image ResizeImage(Image imgToResize, Size size)
        {

            return (Image)(new Bitmap(imgToResize, size));
        }

        ///////////////////////////events for controls/////////////////////////////


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialogSummary.Document = printDocumentSummary;
            printPreviewDialogSummary.ShowDialog();
        }
        private void printDocumentSummary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);

            int overallFoodCounter = 0;
            int overallBeverageCounter = 0;


            int counter = 3;

            float linesPerPage = 0;
            float xPos = 0;
            float yPos = 0;

            float centerMargin = e.MarginBounds.Width / 2;
            float topMargin = e.MarginBounds.Top;


            float thirdRowlineYPos = 50 + (3 * printFont.GetHeight(e.Graphics));


            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);


            //format of organizing 40 +(count * printFont.GetHeight)
            //count = the row where string located
            //printfont.GetHeight = get height of the font size
            e.Graphics.DrawString("Sunway Cafe", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(centerMargin, 20));

            //row 1
            //row 1
            e.Graphics.DrawString("Overall foods sold", printFont
                , Brushes.Black, new PointF(10, 40 + printFont.GetHeight(e.Graphics)));

            //row 2
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 40 + (2*printFont.GetHeight(e.Graphics)), 1000, 40 + (2 * printFont.GetHeight(e.Graphics)));

            //row 3 onwards (for listing items ordered in descending order(by quantity)) //foods
            foreach (Item item in menuList.TopFoodList())
            {
                overallFoodCounter += 1;
                e.Graphics.DrawString(overallFoodCounter+".  "+item.ToString(), printFont, Brushes.Black, new PointF(10, 40 + (counter * printFont.GetHeight(e.Graphics))));
                counter += 1;//increment to next row
            }

            counter+=1;
            //(for listing items ordered in descending order(by quantity)) //beverages            
            e.Graphics.DrawString("Overall beverages sold", printFont
                , Brushes.Black, new PointF(10, 45+(counter * printFont.GetHeight(e.Graphics))));
            counter+=1;

            e.Graphics.DrawLine(new Pen(Color.Black), 0, 45 + (counter * printFont.GetHeight(e.Graphics)), 1000, 45 + (counter * printFont.GetHeight(e.Graphics)));

            foreach (Item item in menuList.TopBeverageList())
            {
                overallBeverageCounter += 1;
                e.Graphics.DrawString(overallBeverageCounter + ".  "+item.ToString(), printFont, Brushes.Black, new PointF(10, 45 + (counter * printFont.GetHeight(e.Graphics))));
                counter += 1;//increment to next row
            }

            counter += 1;
            //list how many orders made
            e.Graphics.DrawString(String.Format("Orders created today: {0}",orderSummary.OrderListToday.Count.ToString()), printFont,
                Brushes.Black, new PointF(10, 50 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 1;

            //show total taxes collected
            e.Graphics.DrawString(String.Format("Service tax collected today: {0:C}",orderSummary.SerTaxAmtToday)
                , printFont, Brushes.Black, new PointF(10, 60 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 1;

            //show total service charge collected
            e.Graphics.DrawString(String.Format("Service charge collected today: {0:C}", orderSummary.SerChargeAmtToday)
                , printFont, Brushes.Black, new PointF(10, 70 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 1;

            //show total revenue collected
            e.Graphics.DrawString(String.Format("Total revenue today: {0:C}", orderSummary.TotalRevenueAmtToday)
                , printFont, Brushes.Black, new PointF(10, 80 + (counter * printFont.GetHeight(e.Graphics))));
            counter += 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
