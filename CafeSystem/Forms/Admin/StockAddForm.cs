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
using System.Security.Cryptography;

namespace CafeSystem.Forms.Admin
{
    public partial class StockAddForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky", "Admin");

        Database db = new Database();

        public StockAddForm()
        {
            InitializeComponent();
        }




        //////////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////////////

        private void treeViewAdminNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeViewAdminNav.SelectedNode;

            if (treeNode.Name.Equals("nodeProduct") && !(this.Name.Equals("ProductViewForm")))
            {
                ProductViewForm viewProductPage = new ProductViewForm();
                this.Hide();
                viewProductPage.ShowDialog();
                this.Close(); //close previous form
            }
            else if (treeNode.Name.Equals("nodeUser") && !(this.Name.Equals("UserViewForm")))
            {
                UserViewForm viewUserPage = new UserViewForm();
                this.Hide();
                viewUserPage.ShowDialog();
                this.Close(); //close previous form
            }
            else if (treeNode.Name.Equals("nodeStock") && !(this.Name.Equals("StockViewForm")))
            {
                StockViewForm viewStockPage = new StockViewForm();
                this.Hide();
                viewStockPage.ShowDialog();
                this.Close(); //close previous form
            }
        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            String stockName = txtStockName.Text;
            decimal stockQty = numUpDownStockQty.Value;

            decimal stockPrice = 0;
            decimal value = 0;
            if (decimal.TryParse(txtStockCost.Text, out value))
            {
                txtStockCost.Text = String.Format("{0:0.00}", value);
                //setting paid amount
                stockPrice = value;
            }
            String supplierLink = txtSupplierLink.Text;
            DateTime dateTime = DateTime.Now;

            if ((!stockName.Equals("")) && (stockQty > 0) && (stockPrice>0) && (!supplierLink.Equals(""))){
                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "INSERT INTO stock (stock_name,stock_quantity,stock_cost,supplier_link,last_restock_date) " +
                    "VALUES('"+ stockName + "', " + stockQty + ", " + stockPrice + ",'"+ supplierLink + "','"+ dateTime.ToString("yyyy-MM-dd HH:mm:ss") +"')";
                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database
                db.Sqlite_cmd.Dispose();
                db.CloseDBConnection();

                StockViewForm stockViewPage = new StockViewForm();
                this.Hide();
                stockViewPage.ShowDialog();
                this.Close(); //close previous form
            }
            else
            {
                MessageBox.Show("Please Do Not Leave Any Empty Box");
            }
        }

        private void lblStockTable_Click(object sender, EventArgs e)
        {
            StockViewForm stockViewPage = new StockViewForm();
            this.Hide();
            stockViewPage.ShowDialog();
            this.Close();
        }

        private void txtStockCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal amount = 0;

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46;//8 is backspace ,46 is .

            if (e.KeyChar == (char)46 && txtStockCost.Text.IndexOf(".") > -1)
            {
                e.Handled = true;
            }

            // no dots in beginning
            if (txtStockCost.Text.StartsWith("."))
            {
                txtStockCost.Text = "";
            }
        }
    }
}