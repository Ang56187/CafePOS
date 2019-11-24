using CafeSystem.Backend;
using CafeSystem.Backend.Objects;
using CafeSystem.Components;
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

namespace CafeSystem.Forms.Kitchen
{
    public partial class KitchenForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        private Font fontLbl;
        private Font fontLblMini;
        private Font fontLblBold;
        private Font fontLblComplete;
        private Font fontBtn;
        private Font fontHeaderLbl;

        //show how much orders to be completed
        private int numOfOrders = 0;

        //keep list of order to refer back in case of order deletion
        List<FlowLayoutPanel> flowPanelOrderList = new List<FlowLayoutPanel>();

        //get the order list
        List<Order> orderList = OrderCollection.OrderList;

        Database db = new Database();

        public KitchenForm()
        {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            //create fonts
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            fontLbl = new Font(fonts.Families[0], 15.0F);
            fontLblMini = new Font(fonts.Families[0], 14.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            fontLblBold = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
            fontLblComplete = new Font(fonts.Families[0], 14.0F, FontStyle.Strikeout);

            //set font for controls
            lblKitchen.Font = lblTotalOrder.Font = fontHeaderLbl;
            btnLogOut.Font = fontBtn;


            foreach (Order order in orderList)
            {
                if (!order.IsDone)
                {
                    numOfOrders += 1;
                    CreateOrder(order);
                }

            }

            lblTotalOrder.Text = "Total: " + numOfOrders;
        }

        private void CreateOrder(Order order)
        {
            //flow panel of overall single order
            FlowLayoutPanel flowPanelOrder = new FlowLayoutPanel();

            //controls in the order flow panel 
            //first row
            FlowLayoutPanel flowPaneOrderNum = new FlowLayoutPanel();
            Label lblTakeOrDine = new Label();
            Label lblOrderNum = new Label();
            Label lblOrderTime = new Label();
            Label lblCashierName = new Label();
            Button btnDeleteOrder = new Button();

            //second row
            Panel panelLineUnderOrder = new Panel();

            //thrid row
            FlowLayoutPanel flowPanelOrderItem = new FlowLayoutPanel();

            //set text of labels
            lblTakeOrDine.Text = order.DineOrTakeAway;
            lblOrderNum.Text = "#"+order.OrderNum.ToString();
            lblOrderTime.Text = order.OrderDate.ToString("hh:mm:ss tt");
            lblCashierName.Text = "Created by: "+order.OrderUserName;


            //set settings for controls

            flowPanelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowPanelOrder.AutoSize = true;
            flowPanelOrder.Margin = new Padding(15,15,0,0);
            flowPanelOrder.MinimumSize = new Size(1490, 100);
            flowPanelOrder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            //first row
            //flowPaneOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowPaneOrderNum.Margin = new Padding(5, 5, 0, 0);
            flowPaneOrderNum.MinimumSize = new Size(500, 30);
            flowPaneOrderNum.AutoSize = true;

            lblTakeOrDine.Size = new Size(210, 30);
            lblTakeOrDine.Font = fontLblBold;

            lblOrderNum.Size = new Size(210, 30);
            lblOrderNum.Font = fontLblBold;
            lblOrderNum.ForeColor = Color.FromArgb(248, 80, 80);
            lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            lblOrderTime.Size = new Size(500, 30);
            lblOrderTime.Font = fontLbl;
            lblOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //lblOrderTime.AutoSize = true;

            lblCashierName.Size = new Size(300, 30);
            lblCashierName.Font = fontLbl;
            lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //lblOrderTime.AutoSize = true;

            btnDeleteOrder.Size = new Size(40, 40);
            btnDeleteOrder.BackColor = Color.Transparent;
            btnDeleteOrder.FlatAppearance.BorderSize = 0;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Image = ResizeImage(global::CafeSystem.Properties.Resources.close_window_48, new Size(39, 39));
            btnDeleteOrder.Margin = new Padding(200, 0, 0, 0);
            btnDeleteOrder.Click += (sender, e) =>
            {
                flowPanelKitchen.Controls.Remove(flowPanelOrder);
                order.IsDone = true;

                numOfOrders -= 1;
                lblTotalOrder.Text = "Total: " + numOfOrders;

                //updates the DB
                db.OpenDBConnection();

                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "update purchase_order set is_completed = 1 where id = @orderId";
                db.Sqlite_cmd.Parameters.AddWithValue("@orderId", order.OrderID);
                db.Sqlite_cmd.ExecuteNonQuery();

                db.CloseDBConnection();
            };

            flowPaneOrderNum.Controls.Add(lblTakeOrDine);
            flowPaneOrderNum.Controls.Add(lblOrderNum);
            flowPaneOrderNum.Controls.Add(lblOrderTime);
            flowPaneOrderNum.Controls.Add(lblCashierName);
            flowPaneOrderNum.Controls.Add(btnDeleteOrder);

            //second row
            panelLineUnderOrder.Size = new Size(1400, 3);
            panelLineUnderOrder.Margin = new Padding(15, 0, 0, 0);
            panelLineUnderOrder.BackColor = Color.Silver;

            //third row
            //flowPanelOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowPanelOrderItem.MinimumSize = new Size(1488, 55);
            flowPanelOrderItem.Margin = new Padding(5, 5, 0, 5);
            flowPanelOrderItem.AutoSize = true;

            //add items into this row
            foreach(Item item in order.OrderItems)
            {
                FlowLayoutPanel flowPanelItemDetail = new FlowLayoutPanel();
                Button btnDone = new Button();
                Label lblItemName = new Label();
                Label lblItemQty = new Label();

                //set text
                lblItemName.Text = item.Name;
                lblItemQty.Text = "X" + item.Quantity;

                //settings for controls
                btnDone.Size = new Size(80,40);
                btnDone.Margin = new Padding(0, 0, 0, 0);
                btnDone.Image = ResizeImage(global::CafeSystem.Properties.Resources.sandglass_white_32, new Size(30, 30));
                btnDone.FlatAppearance.BorderSize = 0;
                btnDone.FlatStyle = FlatStyle.Flat;
                btnDone.BackColor = Color.FromArgb(241, 93, 93);
                //when login back the page, show that items that is done as green
                if (item.IsDone)
                {
                    //change button color and image
                    btnDone.BackColor = Color.FromArgb(71, 206, 80);
                    btnDone.Image = ResizeImage(global::CafeSystem.Properties.Resources.checked_checkbox_32, new Size(30, 30));

                    lblItemName.Font = fontLblComplete;

                }
                btnDone.Click += (sender, e) =>
                {
                    lblItemName.Font = fontLblComplete;

                    //change button color and image
                    btnDone.BackColor = Color.FromArgb(71, 206, 80);
                    btnDone.Image = ResizeImage(global::CafeSystem.Properties.Resources.checked_checkbox_32, new Size(30, 30));

                    //set that item have finished 
                    item.IsDone = true;

                    //if all items are completed, auto delete the order
                    if (checkAllItemsDone(order.OrderItems))
                    {
                        order.IsDone = true;
                        flowPanelKitchen.Controls.Remove(flowPanelOrder);

                        numOfOrders -= 1;
                        lblTotalOrder.Text = "Total: " + numOfOrders;

                        //updates the DB
                        db.OpenDBConnection();

                        db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                        db.Sqlite_cmd.CommandText = "update purchase_order set is_completed = 1 where id = @orderId";
                        db.Sqlite_cmd.Parameters.AddWithValue("@orderId",order.OrderID);
                        db.Sqlite_cmd.ExecuteNonQuery();

                        db.CloseDBConnection();

                    }


                    };

                lblItemName.MinimumSize = new Size(100, 40);

                if (item.IsDone)
                    lblItemName.Font = fontLblComplete;
                else
                    lblItemName.Font = fontLblMini;
                

                lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblItemName.AutoSize = true;

                lblItemQty.Size = new Size(80, 40);
                lblItemQty.Font = fontLblMini;
                lblItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                flowPanelItemDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                flowPanelItemDetail.MinimumSize = new Size(100, 40);
                flowPanelItemDetail.Margin = new Padding(6, 6, 0, 0);
                flowPanelItemDetail.AutoSize = true;

                //add controls to that specific item flow panel
                flowPanelItemDetail.Controls.Add(btnDone);
                flowPanelItemDetail.Controls.Add(lblItemName);
                flowPanelItemDetail.Controls.Add(lblItemQty);

                //add to flow panel for all items
                flowPanelOrderItem.Controls.Add(flowPanelItemDetail);
            }//end foreach


            flowPanelOrder.Controls.Add(flowPaneOrderNum);
            flowPanelOrder.Controls.Add(panelLineUnderOrder);
            flowPanelOrder.Controls.Add(flowPanelOrderItem);

            //add flow panel to the list
            flowPanelOrderList.Add(flowPanelOrder);

            flowPanelKitchen.Controls.Add(flowPanelOrder);

        }

        //check if all items have been done prepared
        private bool checkAllItemsDone(List<Item> itemList)
        {
            foreach(Item item in itemList)
            {
                if (!item.IsDone)
                {
                    return false;
                }
            }
            return true;
        }

        //for resizing images that are too big
        private Image ResizeImage(Image imgToResize, Size size)
        {

            return (Image)(new Bitmap(imgToResize, size));
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
