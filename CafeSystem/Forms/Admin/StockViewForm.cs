﻿using System;
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
    public partial class StockViewForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky","Admin");
        
        MenuCatalogue menuItems = new MenuCatalogue();

        Database db = new Database();

        public StockViewForm()
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
            }else if (treeNode.Name.Equals("nodeUser") && !(this.Name.Equals("UserViewForm")))
            {
                UserViewForm viewUserPage = new UserViewForm();
                this.Hide();
                viewUserPage .ShowDialog();
                this.Close(); //close previous form
            }else if (treeNode.Name.Equals("nodeStock") && !(this.Name.Equals("StockViewFor")))
                {
                StockViewForm viewStockPage = new StockViewForm();
                this.Hide();
                viewStockPage.ShowDialog();
                this.Close(); //close previous form
            }
        }

        private void StockViewForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT * FROM stock";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database

            while (db.Sqlite_datareader.Read())
            {
                dtgStock.Rows.Add(new object[] {
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("id")),
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("stock_name")), 
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("stock_quantity")),  
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("stock_cost")),
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("supplier_link")),
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("last_restock_date")),
                });
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            StockAddForm addStockPage = new StockAddForm();
            this.Hide();
            addStockPage.ShowDialog();
            this.Close(); //close previous form
        }

        private void dtgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var buttonGrid = (DataGridView)sender;

            if (buttonGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6) //When selected edit button
            {
                int selectedrowindex = dtgStock.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dtgStock.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ID"].Value);
                string name  =Convert.ToString(selectedRow.Cells["stock_name"].Value);
                int qty = Convert.ToInt32(selectedRow.Cells["stock_quantity"].Value);
                decimal cost = Convert.ToDecimal(selectedRow.Cells["stock_cost"].Value);
                string supplierLink = Convert.ToString(selectedRow.Cells["supplier_link"].Value);

                StockEditForm stockEditPage = new StockEditForm(id,name,qty,cost,supplierLink);
                this.Hide();
                stockEditPage.ShowDialog();
                this.Close();
            }
        }
    }
}