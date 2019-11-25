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
    public partial class UserViewForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky","Admin");
        
        MenuCatalogue menuItems = new MenuCatalogue();

        Database db = new Database();

        public UserViewForm()
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
            }
        }

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT * FROM user";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database

            while (db.Sqlite_datareader.Read())
            {
                dtgUser.Rows.Add(new object[] {
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("user_name")),  // column name
                db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("user_role"))
                });
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            UserAddForm addUserPage = new UserAddForm();
            this.Hide();
            addUserPage.ShowDialog();
            this.Close(); //close previous form
        }
    }
}