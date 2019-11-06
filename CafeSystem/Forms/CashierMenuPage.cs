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
using CafeSystem.Components;

namespace CafeSystem.Forms
{
    public partial class CashierMenuPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font treeViewFont;
        Font btnFont;
        Font btnFontMini;
        Font txtBoxFont;
        Font lblFont;

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

            treeViewFont = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
            btnFont = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            btnFontMini = new Font(fonts.Families[0], 10.0F, FontStyle.Bold);
            txtBoxFont = new Font(fonts.Families[0], 20.0F);
            lblFont = new Font(fonts.Families[0], 15.0F);

        }

        //for resizing images that are too big
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void CashierMenuPage_Load(object sender, EventArgs e)
        {
            treeViewMenu.Font = treeViewFont;
            btnLogOut.Font = btnFont;
            txtBoxSearch.Font = txtBoxFont;

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

                Label itemName = new Label();
                itemName.Font = lblFont;
                itemName.Text = "Insert name here";
                itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                itemName.Size = new Size(220, 30);

                Label itemPrice = new Label();
                itemPrice.Font = lblFont;
                itemPrice.Text = "Insert price here";
                itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                itemPrice.Size = new Size(220, 30);

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
                btnQty.Font = btnFontMini;
                btnQty.ForeColor = Color.White;
                btnQty.Margin = new Padding(0, 0, 0, 0);
                btnQty.Text = "100";

                RoundButton btnAddToCart = new RoundButton();
                btnAddToCart.Size = new Size(140, 45);
                btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                btnAddToCart.FlatAppearance.BorderSize = 0;
                btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAddToCart.Font = btnFontMini;
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
                vFlowPanel.Controls.Add(itemName);
                vFlowPanel.Controls.Add(itemPrice);
                vFlowPanel.Controls.Add(hFlowPanel);

                //finally added everything to overall flow panel
                flowLayoutPanelMenu.Controls.Add(vFlowPanel);

     
            }
        }

        private void createItemDetails()
        {
            TransparentPanel panelHidden = new TransparentPanel();
            panelHidden.Size = new Size(1605,835);
            panelHidden.Opacity = 60;
            panelHidden.BackColor = Color.DarkGray;

            Panel panelItemDetail = new Panel();
            panelItemDetail.Size = new Size(600, 600);
            panelItemDetail.BackColor = Color.White;
            panelItemDetail.Paint +=  new System.Windows.Forms.PaintEventHandler(panelItemDetail_paint);

            panelHidden.Controls.Add(panelItemDetail);

            this.Controls.Add(panelHidden);
            panelHidden.BringToFront();
        }


        private void panelItemDetail_paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);

        }


        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeViewMenu.SelectedNode;
            bool isSelected = treeViewMenu.Nodes["Node0"].Nodes["Node4"].IsSelected;

            if (isSelected)
            {
                MessageBox.Show("Selected {0}",treeViewMenu.Name);
            }
        }

        private void menuItemImg_click(object sender, EventArgs e)
        {

            createItemDetails();
        }

        private void btnAddToCart_click(object sender, EventArgs e)
        {
        }

        private void panelHidden_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
