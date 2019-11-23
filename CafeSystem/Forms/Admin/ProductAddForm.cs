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
        User user = new User("Rocky","Admin");
        
        MenuCatalogue menuItems = new MenuCatalogue();
        public ProductAddForm()
        {
            InitializeComponent();
        }




        //////////////////////////////////////////////////////events for components///////////////////////////////////////////////////////////////////

        private void treeViewAdminNav_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            
            TreeNode treeNode = tvAdminNav.SelectedNode;

            //if root node selected
            if (treeNode.Parent == null)
            {

            }
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafePOSDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cafePOSDataSet.product);

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
    }
}