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
    public partial class UserAddForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky", "Admin");

        Database db = new Database();

        public UserAddForm()
        {
            InitializeComponent();
        }




        //////////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////////////

        private void treeViewAdminNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeViewAdminNav.SelectedNode;

            if (treeNode.Name.Equals("nodeProduct"))
            {
                ProductViewForm viewProductPage = new ProductViewForm();
                this.Hide();
                viewProductPage.ShowDialog();
                this.Close(); //close previous form
            }
            else if (treeNode.Name.Equals("nodeUser"))
            {
                UserViewForm viewUserPage = new UserViewForm();
                this.Hide();
                viewUserPage.ShowDialog();
                this.Close(); //close previous form
            }
        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

        }

        private void lblUserTable_Click(object sender, EventArgs e)
        {
            UserViewForm userViewPage = new UserViewForm();
            this.Hide();
            userViewPage.ShowDialog();
            this.Close(); //close previous form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}