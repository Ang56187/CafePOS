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


namespace CafeSystem.Forms.Admin
{
    public partial class ProductViewForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky","Admin");

        Database db = new Database();

        public ProductViewForm()
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

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT item.name, item.price, min(stock.stock_quantity) FROM item " +
                "JOIN stock_item ON item.id = stock_item.item_id " +
                "JOIN stock ON stock_item.stock_id = stock.id " +
                "GROUP BY item.id, item.name";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database
            dtgProduct.Columns[1].DefaultCellStyle.Format = "c";

            while (db.Sqlite_datareader.Read())
            {
                dtgProduct.Rows.Add(new object[] {
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("name")),  // column name
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("price")),
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("min(stock.stock_quantity)"))
                });
            }


            //set autosize mode
            dtgProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dtgProduct.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dtgProduct.Columns[i].Width;
                //remove autosizing
                dtgProduct.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dtgProduct.Columns[i].Width = colw;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAddForm addProductPage = new ProductAddForm();
            this.Hide();
            addProductPage.ShowDialog();
            this.Close(); //close previous form
        }
    }
}