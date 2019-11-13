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
        List<Button> btnAddToCartList = new List<Button>();
        List<Button> btnAddToCart2List = new List<Button>();
        List<NumericUpDown> numUpDownListPopUp = new List<NumericUpDown>();
        List<NumericUpDown> numUpDownListCart = new List<NumericUpDown>();


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

        //* fifith row flow panel - created at createmenuitems method
        //*
        Label lblTotalPrice = new Label();
        //add to cart 2 - created at createmenuitems method

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
            fontHeaderLbl = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
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

            CreateItemDetails();

            //hide shopping cart panel upon load up unless cart btn clicked
            transPanelCart.Hide();

        }


        //TODO: later once item info finally gathered, we insert parameters for this.
        //use linq gogo!
        private void CreateMenuItems(Item item)
        {
            //**created new for each menu item popup before hand
            NumericUpDown numUpDownQty = new NumericUpDown();
            numUpDownQty.MinimumSize = new Size(50, 40);
            numUpDownQty.Font = fontTxtBox;
            numUpDownQty.KeyPress += new KeyPressEventHandler(txtBoxQty_KeyPress);
            numUpDownQty.Margin = new Padding(30, 15, 0, 0);
            numUpDownQty.Tag = item.Name;
            //add to list of buttons for access by controls outside loop
            numUpDownListPopUp.Add(numUpDownQty);

            RoundButton btnAddToCart2 = new RoundButton();
            btnAddToCart2.ForeColor = Color.White;
            btnAddToCart2.BackColor = Color.FromArgb(248, 80, 80);
            btnAddToCart2.FlatAppearance.BorderSize = 0;
            btnAddToCart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart2.Font = fontBtn;
            btnAddToCart2.Text = "Add to cart";
            btnAddToCart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnAddToCart2.Size = new Size(200, 40);
            btnAddToCart2.Margin = new Padding(25, 10, 0, 0);

            //lets use this to dynamically load menu item
            //adding controls of menu item horizontally
            BorderFlowLayoutPane vFlowPanel = new BorderFlowLayoutPane();
            PictureBox picBoxItem = new PictureBox();
            Label lblItemName = new Label();
            Label lblItemPrice = new Label();

            FlowLayoutPanel hFlowPanel = new FlowLayoutPanel();
            RoundButton btnQty = new RoundButton();
            RoundButton btnAddToCart = new RoundButton();


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
                ////add everything to flow panel  in item pop-up by row 
                panelItemDetail.Controls.Add(panelItemDetailHeader);
                panelItemDetail.Controls.Add(panelLineUnderName);
                panelItemDetail.Controls.Add(flowPanelThirdRow);
                panelItemDetail.Controls.Add(lblPrice);
                panelItemDetail.Controls.Add(panelLineUnderPrice);
                panelItemDetail.Controls.Add(numUpDownQty);
                panelItemDetail.Controls.Add(lblTotalPrice);
                panelItemDetail.Controls.Add(btnAddToCart2);

                //add flow panel to middle of transparent panel
                transPanelHidden.Controls.Add(panelItemDetail);

                ShowItemDetails(item, numUpDownQty);
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
            transPanelHidden.Click += (e, sender) =>
            {
                ButtonUpdate(btnQty,item.Quantity.ToString());
            };

            btnClose.Click += (e, sender) =>
            {
                ButtonUpdate(btnQty, item.Quantity.ToString());
            };

            //btnQty added to list to be accessed controls outside the loop
            btnQtyList.Add(btnQty);

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

                //update item quantity in cart
                foreach (NumericUpDown numUpDown in numUpDownListCart)
                {
                    if (numUpDown.Tag.Equals(item.Name))
                    {
                        numUpDown.Value = item.Quantity;
                        numUpDown.Update();
                    }
                }

                //update quantity button at menu
                btnQty.Text = item.Quantity.ToString();
                AddCartItem(item);
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


            //add to cart button at pop up
            btnAddToCart2.Click += (sender, e) =>
            {
                item.Quantity += 1;

                //update item quantity in cart
                foreach (NumericUpDown numUpDown in numUpDownListCart)
                {
                    if (numUpDown.Tag.Equals(item.Name))
                    {
                        numUpDown.Value = item.Quantity;
                        numUpDown.Update();
                    }
                }

                //update the pop-up qty numUpDown
                numUpDownQty.Value = item.Quantity;
                AddCartItem(item);
            };
        }


        //////////////////////////////////////////////////////to create popup of more details of item/////////////////////////
        private void CreateItemDetails() //TODO: add contents to item detail pop up
        {
            //create overall flow pane, keeps every control in pop-up
            panelItemDetail.Size = new Size(1000, 700);
            panelItemDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panelItemDetail.Location = new System.Drawing.Point(
                (transPanelHidden.Width-panelItemDetail.Width)/2, (transPanelHidden.Height - panelItemDetail.Height) /2);//centered

            //set all rows margins
            panelItemDetailHeader.Margin = new Padding(25, 5, 0, 0);
            flowPanelThirdRow.Margin = lblPrice.Margin = 
                lblTotalPrice.Margin = new Padding(25, 10, 0, 0);
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

            //*6th row of flow panel (add or delete quantity of item) - created at createmenuitems method


            //* 7th row of flow panel (add total price)
            lblTotalPrice.Font = fontHeaderLbl;
            lblTotalPrice.Size = new Size(400, 50);
            lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            //* 8th row of flow panel (add button to add to cart) --created at createmenuitems method

        }


        //To fill in details of item at pop up
        private void ShowItemDetails(Item item,NumericUpDown numUpDown)
        {
            //to find for file image
            String fileLocation = Path.Combine(Environment.CurrentDirectory, "..", "..", "Resource", "Images", "MenuItems", item.Image);
            picBoxItemDetail.Image = ResizeImage(Image.FromFile(fileLocation), new Size(400, 350));

            //set item name
            lblItemNameDetail.Text = item.Name;
            txtBoxItemDesc.Text = item.Description;
            lblPrice.Text = String.Format("{0:C}",item.Price);

            //for numericupdown part
            numUpDown.Value = item.Quantity;
            numUpDown.ValueChanged += (e,sender) =>
            {
                //update item quantity at menu page
                item.Quantity = (int)numUpDown.Value;
                lblTotalPrice.Text = "Total: " + (item.Price * numUpDown.Value);

                //update item quantity in cart
                foreach (NumericUpDown upDown in numUpDownListCart)
                {
                    if (upDown.Tag.Equals(item.Name))
                    {
                        upDown.Value = item.Quantity;
                        upDown.Update();
                    }
                }

                AddCartItem(item);
            };

            lblTotalPrice.Text = "Total: "+ (item.Price* numUpDown.Value);

            //bring pop up to front
            transPanelHidden.Show();
            transPanelHidden.BringToFront();
        }


        ////////////////////////////////////////////// create controls for cart items//////////////////////////////////////////
        private void CreateCartItem(Item item)
        {
            UpdateLbl();

            //add all components for cart item
            FlowLayoutPanel flowPanelCartDetail = new FlowLayoutPanel();

            PictureBox picBoxCartItemRow1 = new PictureBox();

            FlowLayoutPanel flowPanelCartRow2 = new FlowLayoutPanel();
            Label lblCartItemName = new Label();
            Panel panelLineUnderCartName = new Panel();
            NumericUpDown numUpDownItemQty = new NumericUpDown();

            FlowLayoutPanel flowPanelCartRow3 = new FlowLayoutPanel();
            Button btnDeleteItem = new Button();
            Label lblItemPrice = new Label();

            //set values of components through arguments
            //to find for file image
            String fileLocation = Path.Combine(Environment.CurrentDirectory, "..", "..", "Resource", "Images", "MenuItems", item.Image);
            picBoxCartItemRow1.Image = ResizeImage(Image.FromFile(fileLocation), new Size(140, 100));

            lblCartItemName.Text = item.Name;
            lblItemPrice.Text = String.Format("{0:C}",item.Price*item.Quantity);
            numUpDownItemQty.Value = item.Quantity;

            //set flow panel of overall item detail
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
            numUpDownItemQty.Tag = item.Name;
            numUpDownListCart.Add(numUpDownItemQty);
            numUpDownItemQty.KeyPress += new KeyPressEventHandler(txtBoxQty_KeyPress);

            //update qty from cart to menu
            numUpDownItemQty.ValueChanged += (e, sender) =>
            {
                item.Quantity = (int)numUpDownItemQty.Value;
                lblItemPrice.Text = String.Format("{0:C}", item.Price * item.Quantity);
                UpdateLbl();
            };

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
            //change quantity to 0 once deleted
            btnDeleteItem.Click += (sender,e) =>
            {
                item.Quantity = 0;

                UpdateLbl();

                //remove the NumericUoDown control for that item
                numUpDownListCart.Remove(numUpDownItemQty);
                flowPanelCartItem.Controls.Remove(flowPanelCartDetail);

                //remove item from cart list
                cartItems.CartList.Remove(item);
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

            //where it actually update quantity at menu list, to prevent error where button will appear front of cart list
            transPanelCart.Click += (e, sender) =>
            {
                if (numUpDownItemQty.Value == 0)
                {
                    RemoveCartItem(item, numUpDownItemQty, flowPanelCartDetail);
                }
                UpdateMenuQty(item);
            };

            btnCart.Click += (e, sender) =>
            {
                if (numUpDownItemQty.Value == 0)
                {
                    RemoveCartItem(item, numUpDownItemQty, flowPanelCartDetail);
                }

                if (!transPanelCart.Visible)
                    UpdateMenuQty(item);
            };
 

        }

        //it changes quantity of item to 0, and removes controls of cart item in the flow panel cart
        //but doesnt actually updates quantity to 0 at menu page, thats for another method
        private void RemoveCartItem(Item item,NumericUpDown upDown,FlowLayoutPanel flowPanel)
        {
            item.Quantity = 0;

            //remove the NumericUoDown control and panel for that item in the cart flow panel
            numUpDownListCart.Remove(upDown);
            flowPanelCartItem.Controls.Remove(flowPanel);

            cartItems.CartList.Remove(item);
        }


        //procedure of actually adding item to cart
        private void AddCartItem(Item addedItem)
        {
            //MessageBox.Show(cartItems.CartList.Count.ToString());

            //ensure added item must be more than 1, and there's no duplicate already in cart list
            if (addedItem.Quantity > 0 && !cartItems.CartList.Contains(addedItem))
            {
                //add item to cart list first
                cartItems.CartList.Add(addedItem);
                CreateCartItem(cartItems.CartList.Last());
            }
            else
            {
                foreach (Item item in cartItems.CartList)
                {
                    if (addedItem.Name.Equals(item.Name))
                        {
                            item.Quantity = addedItem.Quantity;
                        }
                }
            }
        }

        private void UpdateLbl()
        {
            decimal subTotal = 0;
            decimal serTax = 0;
            decimal total = 0;
            foreach (Item item in cartItems.CartList)
            {
                subTotal += item.Price * item.Quantity;
                serTax = subTotal * 6 / 100;
            }

            lblSubTotal.Text = String.Format("{0:C}",subTotal);
            lblTax.Text = String.Format("{0:C}", serTax);
            lblTotal.Text = String.Format("{0:C}",subTotal + serTax);
        }

        private void UpdateMenuQty(Item itemUpdated)
        {
            //update numeric up down in item pop-up
            foreach (NumericUpDown upDown in numUpDownListPopUp)
            {
                if (upDown.Tag.Equals(itemUpdated.Name))
                {
                    upDown.Value = itemUpdated.Quantity;
                    upDown.Update();
                }
            }

            //update button that show quantity at menu page
            foreach (Button btn in btnQtyList)
            {
                if (btn.Tag.Equals(itemUpdated.Name))
                {
                    btn.Text = itemUpdated.Quantity.ToString();
                    btn.Update();
                }
            }
        }

        //updating button
        private void ButtonUpdate(Button btn, String txt) 
        {
            btn.Text = txt;
            btn.Update();
        }


        //for resizing images that are too big
        private Image ResizeImage(Image imgToResize, Size size)
        {

            return (Image)(new Bitmap(imgToResize, size));
        }


        //////////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////////////

        //TODO: later once shopping cart done, include cart qty to here
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            //clear the menu everytime select new category/type
            numUpDownListPopUp.Clear();
            btnQtyList.Clear();

            //refreshes the flow panel menu
            flowLayoutPanelMenu.Controls.Clear();
            TreeNode treeNode = treeViewMenu.SelectedNode;

            //if root node selected, show by category (food, beverage)
            if (treeNode.Parent == null)
            {
                foreach (Item item in menuItems.MenuList)
                {
                    if (item.Category.Equals(treeNode.Name))
                        CreateMenuItems(item);
                }

            }
            //if child node selected, show by type
            else
            {
                foreach (Item item in menuItems.MenuList)
                {
                    if (item.Type.Equals(treeNode.Name))
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
            panelItemDetail.Controls.Clear();
            transPanelHidden.Controls.Remove(panelItemDetail);
            transPanelHidden.Hide();
        }

        private void transPanelCart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}