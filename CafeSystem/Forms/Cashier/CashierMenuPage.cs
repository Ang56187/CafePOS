using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSystem.Components;
using CafeSystem.Backend;
using CafeSystem.Backend.Objects;


namespace CafeSystem.Forms.Cashier
{
    public partial class CashierMenuPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font fontBtn;
        Font fontBtnMini;
        Font fontTxtBox;
        Font fontLbl;
        Font fontLblMini;
        Font fontHeaderLbl;
        Font fontTextDesc;

        //menu item list and shopping cart list
        MenuCatalogue menuItems = new MenuCatalogue();
        ShoppingCart cartItems = new ShoppingCart();

        //create list to refer back to buttons created in for loop , so it can be accesssed outside loop
        List<Button> btnQtyList = new List<Button>();

        //when click on item image, will add in item details components
        //invisible background panel behind item details
        TransparentPanel transPanelHidden = new TransparentPanel();
        // panel that store all components of item details
        BorderFlowLayoutPane panelItemDetail = new BorderFlowLayoutPane();
        //*first row panel
        Panel panelItemDetailHeader = new Panel();
        Button btnClose = new Button();
        Label lblItemNameDetail = new Label();
        //*

        Panel panelLineUnderName = new Panel();

        //*third row flow panel
        FlowLayoutPanel flowPanelThirdRow = new FlowLayoutPanel();
        PictureBox picBoxItemDetail = new PictureBox();
        //store all descriptions components into right flow panel
        FlowLayoutPanel flowPanelDesc = new FlowLayoutPanel();
        Label lblDesc = new Label();
        Panel panelLineUnderDesc = new Panel();
        TextBox txtBoxItemDesc = new TextBox();
        //*

        Label lblPrice = new Label();
        Panel panelLineUnderPrice = new Panel();

        //* fifith row flow panel
        NumericUpDown numUpDownQty = new NumericUpDown();
        //*
        Label lblTotalPrice = new Label();
        RoundButton btnAddToCart2 = new RoundButton();

        public CashierMenuPage()
        {
            InitializeComponent();
        }

        private void CashierMenuPage_Load(object sender, EventArgs e)
        {
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            fontBtnMini = new Font(fonts.Families[0], 10.0F, FontStyle.Bold);
            fontTxtBox = new Font(fonts.Families[0], 20.0F);
            fontLbl = new Font(fonts.Families[0], 15.0F);
            fontLblMini = new Font(fonts.Families[0], 12.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            fontTextDesc = new Font(fonts.Families[0], 12.0F);

            //set fonts to components
            treeViewMenu.Font = new Font(fonts.Families[0], 18.0F, FontStyle.Bold); ;
            btnLogOut.Font = btnCheckout.Font = fontBtn;
            txtBoxSearch.Font = fontTxtBox;
            lblCashierName.Font = lblShopCart.Font = fontHeaderLbl;
            lblClearItem.Font = new Font(fonts.Families[0], 12.0F,FontStyle.Underline);
            lblSubTotalTxt.Font = lblSubTotal.Font = lblTaxTxt.Font = lblTax.Font = lblTotalTxt.Font = lblTotal.Font
                = radioBtnDine.Font = radioBtnTake.Font  = fontLbl;

            //add transparent background to foreground
            this.Controls.Add(transPanelHidden);
            transPanelHidden.Size = new Size(1605, 822);
            transPanelHidden.BackColor = Color.Transparent;
            transPanelHidden.Click += new EventHandler(close_popup_click);

            //hide shopping cart panel upon load up unless cart btn clicked
            transPanelCart.Hide();

            CreateItemDetails();

            //TODO: config this later
            for (int i = 0; i <= 5; i++) 
            {
                AddCartItem();
            }
        }

        //for resizing images that are too big
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        //TODO: later once item info finally gathered, we insert parameters for this.
        //use linq gogo!
        private void CreateMenuItems(Item item)
        {
            //lets use this to dynamically load menu item
            //adding controls of menu item horizontally
            BorderFlowLayoutPane vFlowPanel = new BorderFlowLayoutPane();
            PictureBox picBoxItem = new PictureBox();
            Label lblItemName = new Label();
            Label lblItemPrice = new Label();

            FlowLayoutPanel hFlowPanel = new FlowLayoutPanel();
            RoundButton btnQty = new RoundButton();
            RoundButton btnAddToCart = new RoundButton();

            btnQtyList.Add(btnQty);

            // set values from arguments
            //to find for file image
            String imgLocation = Path.Combine(Environment.CurrentDirectory, "..", "..", "Resource", "Images", "MenuItems", item.Image);
            picBoxItem.Image = ResizeImage(Image.FromFile(imgLocation), new Size(250, 220));
            lblItemName.Text = item.Name;
            lblItemPrice.Text = String.Format("{0:C}",item.Price);
            btnQty.Text = item.Quantity.ToString();


            vFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            vFlowPanel.Size = new Size(230, 340);
            vFlowPanel.Margin = new Padding(30, 30, 30, 30);

            picBoxItem.Size = new Size(250, 220);
            picBoxItem.Margin = new Padding(0, 0, 0, 0);
            //add function to add to cart button when clicked
            picBoxItem.Click += (sender, e) =>
            {
                //add flow panel to middle of transparent panel
                transPanelHidden.Controls.Add(panelItemDetail);
                ShowItemDetails(item);
            };

            lblItemName.Font = fontLbl;
            lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblItemName.Size = new Size(220, 30);

            lblItemPrice.Font = fontLbl;
            lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblItemPrice.Size = new Size(220, 30);

            //adding controls of buttons of items horizontally, to be added to vFLowPanel later
            hFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            hFlowPanel.Size = new Size(210, 45);
            hFlowPanel.Margin = new Padding(10, 5, 0, 0);

            btnQty.Size = new Size(60, 45);
            btnQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            btnQty.FlatAppearance.BorderSize = 0;
            btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQty.Font = fontBtnMini;
            //btnQty.Enabled = false;
            btnQty.ForeColor = Color.White;
            btnQty.Margin = new Padding(0, 0, 0, 0);
            btnQty.Tag = item.Name;
            //updates the label once close the pop-up

            btnClose.Click += (e, sender) =>
            {
                if (btnQty.Tag.Equals(lblItemNameDetail))
                {
                    btnQty.Text = item.Quantity.ToString();
                    btnQty.Update();
                }
            };

            btnAddToCart.Size = new Size(140, 45);
            btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart.Font = fontBtnMini;
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Margin = new Padding(10, 0, 0, 0);
            btnAddToCart.Text = "Add to cart";
            //TODO: add to cart
            btnAddToCart.Click += (sender, e) =>
            {
                item.Quantity += 1;
                btnQty.Text = item.Quantity.ToString();
            };
            //divert focus so it wont appear front of pop-up
            btnAddToCart.Click += (sender, e) => btnCart.Focus();

            //add buttons to horizontal flow panel, to be added to vertical flow panel later
            hFlowPanel.Controls.Add(btnQty);
            hFlowPanel.Controls.Add(btnAddToCart);

            //adding controls to vertical flow panel
            vFlowPanel.Controls.Add(picBoxItem);
            vFlowPanel.Controls.Add(lblItemName);
            vFlowPanel.Controls.Add(lblItemPrice);
            vFlowPanel.Controls.Add(hFlowPanel);

            //finally added everything to overall flow panel
            flowLayoutPanelMenu.Controls.Add(vFlowPanel);

            //add component to their respective list
            btnQtyList.Add(btnQty);
        }


        //to create popup of more details of item
        private void CreateItemDetails() //TODO: add contents to item detail pop up
        {
            //create overall flow pane
            panelItemDetail.Size = new Size(1000, 700);
            panelItemDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panelItemDetail.Location = new System.Drawing.Point(
                (transPanelHidden.Width-panelItemDetail.Width)/2, (transPanelHidden.Height - panelItemDetail.Height) /2);//centered

            //set all rows margins
            panelItemDetailHeader.Margin = flowPanelThirdRow.Margin = lblPrice.Margin = 
                lblTotalPrice.Margin = btnAddToCart2.Margin =new Padding(25, 15, 0, 0);
            numUpDownQty.Margin = new Padding(30, 15, 0, 0);
            panelLineUnderPrice.Margin = new Padding(30, 1, 0, 0);


            //*1st row of flow panel(contain item name and close btn)*
            panelItemDetailHeader.Size = new Size(970, 45);
            //close button
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Size = new Size(45, 45);
            btnClose.Image = ResizeImage(global::CafeSystem.Properties.Resources.close_window_48, new Size(50, 50));
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.Click += new EventHandler(close_popup_click);
            //item name label
            lblItemNameDetail.Font = fontHeaderLbl;
            lblItemNameDetail.Size = new Size(600, 45);
            lblItemNameDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //add components to first row of panel
            panelItemDetailHeader.Controls.Add(btnClose);
            panelItemDetailHeader.Controls.Add(lblItemNameDetail);

            //*2nd row of flow panel(add small line under item name)*
            panelLineUnderName.Size = new Size(100, 3);
            panelLineUnderName.BackColor = System.Drawing.Color.Silver;
            panelLineUnderName.Margin = new Padding(25, 1, 0, 0);

            //*3rd row of flow panel(flow panel that contains image and description)*
            flowPanelThirdRow.Size = new Size(970, 350);
            //item picture
            picBoxItemDetail.Size = new Size(400,350);
            //description part flow panel
            flowPanelDesc.Size= new Size(550, 370);
            flowPanelDesc.Margin = new Padding(6, 0, 0, 0);
            flowPanelDesc.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            lblDesc.Font = fontHeaderLbl;
            lblDesc.Size = new Size(200,35);
            lblDesc.Text = "Description";

            panelLineUnderDesc.Size = new Size(100, 3);
            panelLineUnderDesc.BackColor = System.Drawing.Color.Silver;
            panelLineUnderDesc.Margin = new Padding(10, 0, 0, 0);

            txtBoxItemDesc.Font = fontLbl;
            txtBoxItemDesc.MaximumSize = new Size(530, 310);
            txtBoxItemDesc.Size = new Size(530, 310);
            txtBoxItemDesc.Margin = new Padding(10, 0, 0, 0);
            txtBoxItemDesc.BackColor = Color.White;
            txtBoxItemDesc.Multiline = true;
            txtBoxItemDesc.ScrollBars = ScrollBars.Vertical;
            txtBoxItemDesc.AutoSize = true;
            txtBoxItemDesc.ReadOnly = true;
            txtBoxItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;            
            //add everything to description flow panel
            flowPanelDesc.Controls.Add(lblDesc);
            flowPanelDesc.Controls.Add(panelLineUnderDesc);
            flowPanelDesc.Controls.Add(txtBoxItemDesc);            
            //add components to 3rd row flow panel
            flowPanelThirdRow.Controls.Add(picBoxItemDetail);
            flowPanelThirdRow.Controls.Add(flowPanelDesc);

            //*4th row of flow panel (item price)*
            lblPrice.Font = fontHeaderLbl;
            lblPrice.Size = new Size(200, 35);

            //*5th row of flow panel (add line under price)*
            panelLineUnderPrice.Size = new Size(70, 3);
            panelLineUnderPrice.BackColor = System.Drawing.Color.Silver;

            //*6th row of flow panel (add or delete quantity of item)
            numUpDownQty.MinimumSize = new Size(50, 40);
            numUpDownQty.Font = fontTxtBox;
            numUpDownQty.KeyPress += new KeyPressEventHandler(txtBoxQty_KeyPress);

            //* 7th row of flow panel (add total price)
            lblTotalPrice.Font = fontHeaderLbl;
            lblTotalPrice.Size = new Size(400, 50);
            lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


            //* 8th row of flow panel (add button to add to cart)
            btnAddToCart2.ForeColor = Color.White;
            btnAddToCart2.BackColor = Color.FromArgb(248, 80, 80);
            btnAddToCart2.FlatAppearance.BorderSize = 0;
            btnAddToCart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart2.Font = fontBtn;
            btnAddToCart2.Text = "Add to cart";
            btnAddToCart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnAddToCart2.Size = new Size(200, 40);

            //add everything to flow panel by row
            panelItemDetail.Controls.Add(panelItemDetailHeader);
            panelItemDetail.Controls.Add(panelLineUnderName);
            panelItemDetail.Controls.Add(flowPanelThirdRow);
            panelItemDetail.Controls.Add(lblPrice);
            panelItemDetail.Controls.Add(panelLineUnderPrice);
            panelItemDetail.Controls.Add(numUpDownQty);
            panelItemDetail.Controls.Add(lblTotalPrice);
            panelItemDetail.Controls.Add(btnAddToCart2);
        }


        //To fill in details of item at pop up
        private void ShowItemDetails(Item item)
        {
            //to find for file image
            String fileLocation = Path.Combine(Environment.CurrentDirectory, "..", "..", "Resource", "Images", "MenuItems", item.Image);

            //set item name
            lblItemNameDetail.Text = item.Name;
            txtBoxItemDesc.Text = item.Description;
            lblPrice.Text = String.Format("{0:C}",item.Price);

            numUpDownQty.Value = item.Quantity;
            numUpDownQty.ValueChanged += (e,sender) =>
            {
                lblTotalPrice.Text = "Total: " + (item.Price * numUpDownQty.Value);
                item.Quantity = (int)numUpDownQty.Value;
            };

            lblTotalPrice.Text = "Total: "+ (item.Price* numUpDownQty.Value);
            picBoxItemDetail.Image = ResizeImage(Image.FromFile(fileLocation), new Size(400, 350));//TODO: later include image from DB

            transPanelHidden.Click += (e, sender) =>
            {
                foreach (Button btn in btnQtyList)
                {
                    if (btn.Tag.Equals(item.Name))
                    {
                        btn.Text = item.Quantity.ToString();
                        btn.Update();
                    }
                }
            };

            //bring pop up to front
            transPanelHidden.Show();
            transPanelHidden.BringToFront();
        }


        //add at cart list at the side
        public void AddCartItem()
        {
            FlowLayoutPanel flowPanelCartDetail = new FlowLayoutPanel();

            PictureBox picBoxCartItemRow1 = new PictureBox();

            FlowLayoutPanel flowPanelCartRow2 = new FlowLayoutPanel();
            Label lblCartItemName = new Label();
            Panel panelLineUnderCartName = new Panel();
            NumericUpDown numUpDownItemQty = new NumericUpDown();

            FlowLayoutPanel flowPanelCartRow3 = new FlowLayoutPanel();
            Button btnDeleteItem = new Button();
            Label lblItemPrice = new Label();


            //TODO:stuff to be config later
            lblCartItemName.Text = "Hipster's favourite";
            picBoxCartItemRow1.Image = ResizeImage(global::CafeSystem.Properties.Resources.unavailable_image, new Size(140, 100));
            lblItemPrice.Text = "RM312.00";
            numUpDownItemQty.Value = 1;

            flowPanelCartDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowPanelCartDetail.Size = new Size(460,100);

            //first row of flow panel (image)
            picBoxCartItemRow1.Size = new Size(140, 100);
            picBoxCartItemRow1.Margin = new Padding(0, 0, 5, 0);

            //second row of flow panel (name,line and qty)
            flowPanelCartRow2.Size = new Size(200, 90);
            flowPanelCartRow2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            lblCartItemName.Size = new Size(200, 30);
            lblCartItemName.Margin = new Padding(0, 0, 0, 0);
            lblCartItemName.Font = fontLblMini;

            panelLineUnderCartName.Size = new Size(50, 3);
            panelLineUnderCartName.BackColor = System.Drawing.Color.Silver;

            numUpDownItemQty.MinimumSize = new Size(50, 20);
            numUpDownItemQty.Font = fontLblMini;
            numUpDownItemQty.Margin = new Padding(5, 15, 0, 0);
            numUpDownItemQty.KeyPress += new KeyPressEventHandler(txtBoxQty_KeyPress);
            //add everything to col 2
            flowPanelCartRow2.Controls.Add(lblCartItemName);
            flowPanelCartRow2.Controls.Add(panelLineUnderCartName);
            flowPanelCartRow2.Controls.Add(numUpDownItemQty);

            //3rd col of panel (close button and total price)
            flowPanelCartRow3.Size = new Size(100, 90);
            flowPanelCartRow3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;


            btnDeleteItem.BackColor = System.Drawing.Color.Transparent;//TODO: later add func to remove item from shopping cart list too
            btnDeleteItem.FlatAppearance.BorderSize = 0;
            btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteItem.Size = new Size(35, 35);
            btnDeleteItem.Margin = new Padding(65, 0, 0, 0);
            btnDeleteItem.Image = ResizeImage(global::CafeSystem.Properties.Resources.close_window_48, new Size(35, 35));
            btnDeleteItem.Click += (sender,e) =>
            {
                flowPanelCartItem.Controls.Remove(flowPanelCartDetail);
            };

            lblItemPrice.Size = new Size(100, 50);
            lblItemPrice.Font = fontLblMini;
            lblItemPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;

            flowPanelCartRow3.Controls.Add(btnDeleteItem);
            flowPanelCartRow3.Controls.Add(lblItemPrice);

            //add everything
            flowPanelCartDetail.Controls.Add(picBoxCartItemRow1);
            flowPanelCartDetail.Controls.Add(flowPanelCartRow2);
            flowPanelCartDetail.Controls.Add(flowPanelCartRow3);

            flowPanelCartItem.Controls.Add(flowPanelCartDetail);
        }


        //////////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////////////
        //TODO: later once shopping cart done, include cart qty to here
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //refreshes the flow panel menu
            flowLayoutPanelMenu.Controls.Clear();
            TreeNode treeNode = treeViewMenu.SelectedNode;
            //bool isSelected = treeViewMenu.Nodes["Node0"].Nodes["Node4"].IsSelected;

            //if root node selected, show by category (food, beverage)
            if (treeNode.Parent == null)
            {
                var returnList =
                        from item in menuItems.MenuList
                        where item.Category.Equals(treeNode.Name)
                        select item;

                foreach (Item item in returnList)
                {
                    CreateMenuItems(item);
                }

            }
            //if child node selected, show by type
            else
            {
                var returnList =
                        from item in menuItems.MenuList
                        where item.Type.Equals(treeNode.Name)
                        select item;

                foreach (Item item in returnList)
                {
                    CreateMenuItems(item);
                }
            }
        }


        //only numbers can be accepted
        private void txtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (! transPanelCart.Visible)
            {
                transPanelCart.Show();
            }
            else
                transPanelCart.Hide();
        }

        private void transPanelCart_Click(object sender, EventArgs e)
        {
            transPanelCart.Hide();
        }


        private void close_popup_click(object sender, EventArgs e)
        {
            transPanelHidden.Controls.Remove(panelItemDetail);
            transPanelHidden.Hide();
        }
    }
}