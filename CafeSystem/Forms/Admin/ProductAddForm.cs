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
    public partial class ProductAddForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        User user = new User("Rocky", "Admin");

        Database db = new Database();

        public ProductAddForm()
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

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

            picItem.AllowDrop = true;
        }

        private void lblProductTable_Click(object sender, EventArgs e)
        {
            ProductViewForm productViewPage = new ProductViewForm();
            this.Hide();
            productViewPage.ShowDialog();
            this.Close(); //close previous form
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal amount = 0;

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46;//8 is backspace ,46 is .

            if (e.KeyChar == (char)46 && txtPrice.Text.IndexOf(".") > -1)
            {
                e.Handled = true;
            }

            // no dots in beginning
            if (txtPrice.Text.StartsWith("."))
            {
                txtPrice.Text = "";
            }
        }

        private void picItem_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                effects = DragDropEffects.All;
            }

            e.Effect = effects;
        }

        private void picItem_DragDrop(object sender, DragEventArgs e)
        {
            //Take Droppped Items and Store in Array
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            //Loop through all dropped items and display them
            foreach(string file in droppedFiles)
            {
                //Set text
                string fileName = getFileName(file);
                lblFileName.Text = fileName.ToUpper();

                //Set Image
                picItem.BackgroundImage = Image.FromFile(file);
            }
        }
        //Get File name
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void picItem_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picItem.BackgroundImage = new Bitmap(open.FileName);
                // image file path  
                lblFileName.Text = open.SafeFileName;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal value = 0;

            //checks if entered value can be decimal or not
            if (decimal.TryParse(txtPrice.Text, out value))
            {
                txtPrice.Text = String.Format("{0:0.00}", value);
                //setting price amount
                //procduct.PaidAmt = value;
            }
        }

    }
}