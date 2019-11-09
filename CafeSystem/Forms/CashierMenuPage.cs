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
using CafeSystem.Components;

namespace CafeSystem.Forms
{
    public partial class CashierMenuPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font fontTreeView;
        Font fontBtn;
        Font fontBtnMini;
        Font fontTxtBox;
        Font fontLbl;
        Font fontHeaderLbl;
        Font fontTextDesc;


        //when click on item image, will add in item details components
        //invisible background panel behind item details
        TransparentPanel transPanelHidden = new TransparentPanel();
        // panel that store all components of item details
        BorderFlowLayoutPane panelItemDetail = new BorderFlowLayoutPane();
        //*first row panel
        Panel panelItemDetailHeader = new Panel();
        Button btnClose = new Button();
        Label lblItemName = new Label();
        //*
        Panel panelLineUnderName = new Panel();
        //*third row flow panel
        FlowLayoutPanel flowPanelThirdRow = new FlowLayoutPanel();
        PictureBox picBoxItem = new PictureBox();
        //store all descriptions components into right flow panel
        FlowLayoutPanel flowPanelDesc = new FlowLayoutPanel();
        Label lblDesc = new Label();
        Panel panelLineUnderDesc = new Panel();
        TextBox txtBoxItemDesc = new TextBox();
        //*
        Label lblPrice = new Label();
        Panel panelLineUnderPrice = new Panel();
        //* fifith row flow panel
        FlowLayoutPanel flowPanelQty = new FlowLayoutPanel();
        RoundButton btnDeleteQty = new RoundButton();
        TextBox txtBoxQty = new TextBox();
        RoundButton btnAddQty = new RoundButton();
        //*
        Label lblTotalPrice = new Label();
        RoundButton btnAddToCart2 = new RoundButton();

        public CashierMenuPage()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontTreeView = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            fontBtnMini = new Font(fonts.Families[0], 10.0F, FontStyle.Bold);
            fontTxtBox = new Font(fonts.Families[0], 20.0F);
            fontLbl = new Font(fonts.Families[0], 15.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F,FontStyle.Bold);
            fontTextDesc = new Font(fonts.Families[0], 12.0F);


        }

        //for resizing images that are too big
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void CashierMenuPage_Load(object sender, EventArgs e)
        {
            treeViewMenu.Font = fontTreeView;
            btnLogOut.Font = fontBtn;
            txtBoxSearch.Font = fontTxtBox;
            lblCashierName.Font = fontHeaderLbl;


            //add transparent background to foreground
            this.Controls.Add(transPanelHidden);
            transPanelHidden.Size = new Size(1605, 822);
            transPanelHidden.BackColor = Color.Transparent;
            transPanelHidden.Click += new EventHandler(close_popup_click);

            createMenuItems();
        }

        private void createMenuItems()
        {

            //lets use this to dynamically load menu items
            int[] tagCollection = new int[10];

            for (int i = 0; i <= 9; i++)
            {

                //adding controls of menu item horizontally
                BorderFlowLayoutPane vFlowPanel = new BorderFlowLayoutPane();
                vFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                vFlowPanel.Size = new Size(230, 340);
                vFlowPanel.Margin = new Padding(30, 30, 30, 30);

                PictureBox menuItemImg = new PictureBox();
                menuItemImg.Size = new Size(250, 220);
                menuItemImg.Image = resizeImage(global::CafeSystem.Properties.Resources.unavailable_image, new Size(250, 220));
                menuItemImg.Margin = new Padding(0, 0, 0, 0);
                //add function to add to cart button when clicked
                menuItemImg.Click += new EventHandler(menuItemImg_click);

                Label lblItemName = new Label();
                lblItemName.Font = fontLbl;
                lblItemName.Text = "Insert name here";
                lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblItemName.Size = new Size(220, 30);

                Label lblItemPrice = new Label();
                lblItemPrice.Font = fontLbl;
                lblItemPrice.Text = "Insert price here";
                lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblItemPrice.Size = new Size(220, 30);

                //adding controls of buttons of items horizontally, to be added to vFLowPanel later
                FlowLayoutPanel hFlowPanel = new FlowLayoutPanel();
                hFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
                hFlowPanel.Size = new Size(210, 45);
                hFlowPanel.Margin = new Padding(10, 5, 0, 0);

                RoundButton btnQty = new RoundButton();
                btnQty.Size = new Size(60, 45);
                btnQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                btnQty.FlatAppearance.BorderSize = 0;
                btnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnQty.Font = fontBtnMini;
                btnQty.ForeColor = Color.White;
                btnQty.Margin = new Padding(0, 0, 0, 0);
                btnQty.Text = "100";

                RoundButton btnAddToCart = new RoundButton();
                btnAddToCart.Size = new Size(140, 45);
                btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                btnAddToCart.FlatAppearance.BorderSize = 0;
                btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAddToCart.Font = fontBtnMini;
                btnAddToCart.ForeColor = Color.White;
                btnAddToCart.Margin = new Padding(10, 0, 0, 0);
                btnAddToCart.Text = "Add to cart";
                //add function to add to cart button when clicked
                btnAddToCart.Click += new EventHandler(btnAddToCart_click);

                //add buttons to horizontal flow panel, to be added to vertical flow panel later
                hFlowPanel.Controls.Add(btnQty);
                hFlowPanel.Controls.Add(btnAddToCart);

                //adding controls to vertical flow panel
                vFlowPanel.Controls.Add(menuItemImg);
                vFlowPanel.Controls.Add(lblItemName);
                vFlowPanel.Controls.Add(lblItemPrice);
                vFlowPanel.Controls.Add(hFlowPanel);

                //finally added everything to overall flow panel
                flowLayoutPanelMenu.Controls.Add(vFlowPanel);
            }
        }

        private void createItemDetails() //TODO: add contents to item detail pop up
        {

            //set item name (//TODO: remove later
            lblItemName.Text = "Item name";
            txtBoxItemDesc.Text =
                "Windows Forms (WinForms) is a graphical (GUI) class library included as a part of Microsoft .NET Framework or Mono Framework,[1] " +
                "providing a platform to write rich client applications for desktop, laptop, and tablet PCs.[2] While it is seen as a replacement for" +
                " the earlier and more complex C++ based Microsoft Foundation Class Library, it does not offer a comparable paradigm[3] and" +
                " only acts as a platform for the user interface tier in a multi-tier solution.[4]At the Microsoft Connect event on December 4, 2018," +
                " Microsoft announced releasing Windows Forms as open source project on GitHub.It is released under the MIT License.With this release, " +
                "Windows Forms has become available for projects targeting the.NET Core framework.However, the framework is still available" +
                " only on the Windows platform and Mono's incomplete implementation of WinForms remains the only cross-platform implementation.[5][6]";

           lblPrice.Text = "RM23.00";
            txtBoxQty.Text = "0";
            lblTotalPrice.Text = "Total price :RM23.00";
            

            //create overall flow pane
            panelItemDetail.Size = new Size(1000, 700);
            panelItemDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panelItemDetail.Location = new System.Drawing.Point(
                (transPanelHidden.Width-panelItemDetail.Width)/2, (transPanelHidden.Height - panelItemDetail.Height) /2);//centered

            //set all rows margins
            panelItemDetailHeader.Margin = flowPanelThirdRow.Margin = lblPrice.Margin = flowPanelQty.Margin 
                = lblTotalPrice.Margin = btnAddToCart2.Margin =new Padding(25, 15, 0, 0);

            //*1st row of flow panel(contain item name and close btn)*
            panelItemDetailHeader.Size = new Size(970, 45);
            //close button
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Size = new Size(45, 45);
            btnClose.Image = resizeImage(global::CafeSystem.Properties.Resources.close_window_48, new Size(50, 50));
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.Click += new EventHandler(close_popup_click);
            //item name label
            lblItemName.Font = fontHeaderLbl;
            lblItemName.Size = new Size(600, 45);
            lblItemName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //add components to first row of panel
            panelItemDetailHeader.Controls.Add(btnClose);
            panelItemDetailHeader.Controls.Add(lblItemName);

            //*2nd row of flow panel(add small line under item name)*
            panelLineUnderName.Size = new Size(100, 3);
            panelLineUnderName.BackColor = System.Drawing.Color.Silver;
            panelLineUnderName.Margin = new Padding(25, 1, 0, 0);

            //*3rd row of flow panel(flow panel that contains image and description)*
            flowPanelThirdRow.Size = new Size(970, 350);
            //item picture
            picBoxItem.Size = new Size(400,350);
            picBoxItem.Image = resizeImage(global::CafeSystem.Properties.Resources.unavailable_image, new Size(400, 350));//TODO: later include image from DB
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
            flowPanelThirdRow.Controls.Add(picBoxItem);
            flowPanelThirdRow.Controls.Add(flowPanelDesc);

            //*4th row of flow panel (item price)*
            lblPrice.Font = fontHeaderLbl;
            lblPrice.Size = new Size(200, 35);

            //*5th row of flow panel (add line under price)*
            panelLineUnderPrice.Size = new Size(70, 3);
            panelLineUnderPrice.BackColor = System.Drawing.Color.Silver;
            panelLineUnderPrice.Margin = new Padding(25, 1, 0, 0);

            //*6th row of flow panel (add or delete quantity of item)
            flowPanelQty.Size = new Size(500,45);

            btnDeleteQty.BackColor = Color.FromArgb(248, 80, 80);
            btnDeleteQty.FlatAppearance.BorderSize = 0;
            btnDeleteQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteQty.Size = new Size(40, 40);
            btnDeleteQty.Image = resizeImage(global::CafeSystem.Properties.Resources.minus_48, new Size(20, 20));
            btnDeleteQty.Click += new EventHandler(btnDeleteQty_click);

            txtBoxQty.MinimumSize = new Size(50, 40);
            txtBoxQty.Font = fontTxtBox;
            txtBoxQty.KeyPress += new KeyPressEventHandler(txtBoxQty_KeyPress);

            btnAddQty.BackColor = Color.FromArgb(248, 80, 80);
            btnAddQty.FlatAppearance.BorderSize = 0;
            btnAddQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddQty.Size = new Size(40, 40);
            btnAddQty.Image = resizeImage(global::CafeSystem.Properties.Resources.add_48, new Size(40, 40));
            //add components to 6th row of flow panel
            flowPanelQty.Controls.Add(btnDeleteQty);
            flowPanelQty.Controls.Add(txtBoxQty);
            flowPanelQty.Controls.Add(btnAddQty);

            //* 7th row of flow panel (add total price)
            lblTotalPrice.Font = fontHeaderLbl;
            lblTotalPrice.Size = new Size(400, 50);
            lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


            //* 8th row of flow panel (add button to add to cart)
            btnAddToCart2.ForeColor = Color.White;
            btnAddToCart2.BackColor = Color.FromArgb(248, 80, 80);
            btnAddToCart2.FlatAppearance.BorderSize = 0;
            btnAddToCart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart2.Font = fontBtnMini;
            btnAddToCart2.Text = "Add to cart";
            btnAddToCart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnAddToCart2.Size = new Size(200, 40);
            btnAddToCart2.Click += new EventHandler(btnDeleteQty_click);



            //add everything to flow panel by row
            panelItemDetail.Controls.Add(panelItemDetailHeader);
            panelItemDetail.Controls.Add(panelLineUnderName);
            panelItemDetail.Controls.Add(flowPanelThirdRow);
            panelItemDetail.Controls.Add(lblPrice);
            panelItemDetail.Controls.Add(panelLineUnderPrice);
            panelItemDetail.Controls.Add(flowPanelQty);
            panelItemDetail.Controls.Add(lblTotalPrice);
            panelItemDetail.Controls.Add(btnAddToCart2);

            //add flow panel to middle of transparent panel
            transPanelHidden.Controls.Add(panelItemDetail);

            //bring pop up to front
            transPanelHidden.BringToFront();
        }

        private void updateItemDetails()
        {
            //set item name
            lblItemName.Text = "Item name";

        }

        //events for components
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeViewMenu.SelectedNode;
            bool isSelected = treeViewMenu.Nodes["Node0"].Nodes["Node4"].IsSelected;

            if (isSelected)
            {
                MessageBox.Show("Test",treeViewMenu.Name);
            }
        }

        private void menuItemImg_click(object sender, EventArgs e)
        {
            createItemDetails();
        }

        private void txtBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
            }
        }

        private void btnAddToCart_click(object sender, EventArgs e)
        {
        }

        private void btnDeleteQty_click(object sender, EventArgs e)
        {
        }

        private void btnAddQty_click(object sender, EventArgs e)
        {
        }


        private void close_popup_click(object sender, EventArgs e)
        {
            transPanelHidden.Controls.Remove(panelItemDetail);
            transPanelHidden.SendToBack();
        }


    }
}