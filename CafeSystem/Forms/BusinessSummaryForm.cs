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
        List<Order> orderList = OrderCollection.orderList;

        //get all items in the item menu
        List<Item> menuList = new MenuCatalogue().MenuList;


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

            //for lsit viiew fonts
            lblOverallFoodTxt.Font = fontHeaderLblMini;
            lblOverallBeverageTxt.Font = fontHeaderLblMini;

            //calculate total items sold
            foreach (Order order in orderList)
            {
                foreach (Item orderItem in order.OrderItems)
                {
                    foreach (Item item in menuList)
                    {
                        if (orderItem.Name.Equals(item.Name))
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


            //linq to get top sold foods first
            var topFoodList = (from item in menuList
                              where item.Category == "Food"
                              orderby item.Quantity descending
                              select item).ToList();


            //linq to get top sold beverage first
            var topBeverageList = (from item in menuList
                              where item.Category == "Beverage"
                              orderby item.Quantity descending
                              select item).ToList();

            //setting the top 4 picture boxes
            SetTopPicBox(topFoodList, picBoxFoodList);
            SetTopPicBox(topBeverageList, picBoxBeverageList);

            //setting the top 4 labels(name and qty)
            SetTopLabels(topFoodList, lblFoodNameList, lblFoodQtyList);
            SetTopLabels(topBeverageList, lblBeverageNameList, lblBeverageQtyList);


            //add items to the list views
            for (int i = 0; i < topFoodList.Count();i++)
            {
                ListViewItem listItem = new ListViewItem(new[] { (i+1).ToString(), topFoodList[i].Name,
                    String.Format("{0:C}",topFoodList[i].Price),topFoodList[i].Quantity.ToString()});
                listViewFood.Items.Add(listItem);
            }

            for (int i = 0; i < topBeverageList.Count(); i++)
            {
                ListViewItem listItem = new ListViewItem(new[] { (i+1).ToString(), topBeverageList[i].Name,
                    String.Format("{0:C}",topBeverageList[i].Price),topBeverageList[i].Quantity.ToString()});
                listViewBeverage.Items.Add(listItem);
            }

        }//end form_load

        private void SetTopPicBox(List<Item> itemList, List<PictureBox> picBoxList)
        {
            for (int i = 0; i <= 3; i++)
            {
                //String imageName = topFoodList.AsEnumerable().ElementAt(1).Image;//if kept the enumerable class type
                String imageName = itemList[i].Image;
                SetImage(imageName, picBoxList[i]);
            }

        }

        private void SetTopLabels(List<Item> itemList, List<Label> lblNameList, List<Label> lblQtyList)
        {
            for (int i = 0; i <= 3; i++)
            {
                lblNameList[i].Text = itemList[i].Name;
                lblQtyList[i].Text = itemList[i].Quantity.ToString() + " sold";
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

    }
}
