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
using System.Drawing.Imaging;

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

        //add combobox to this list
        List<ComboBox> cboIngredientList = new List<ComboBox>();

        String itemImagePath = "";

        public ProductAddForm()
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

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            db.OpenDBConnection();

            picItem.AllowDrop = true;

            //add current combobox of ingredient to list
            cboIngredientList.Add(cboIngredient);
            getIngredient(cboIngredient);
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
                lblFileName.Text = fileName;

                //Set Image
                picItem.BackgroundImage = Image.FromFile(file);
                itemImagePath = fileName;
            }
        }
        //Get File name
        private string getFileName(string path)
        {
            return Path.GetFileName(path);
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
                itemImagePath = open.SafeFileName;
            }
        }

        private class ComboboxItem
        {
            public string text { get; set; }
            public int value { get; set; }

            public override string ToString()
            {
                return text;
            }
        }

        private void getIngredient(ComboBox comboBox)
        {
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT * FROM stock WHERE stock_quantity > 1";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database

            
            while (db.Sqlite_datareader.Read())
            {
                ComboboxItem ingredientItem = new ComboboxItem();
                ingredientItem.value = Convert.ToInt32(db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("id")));
                ingredientItem.text = db.Sqlite_datareader.GetValue(db.Sqlite_datareader.GetOrdinal("stock_name")).ToString();
                comboBox.Items.Add(ingredientItem);
            }
            db.Sqlite_cmd.Dispose();
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowPanelCbo = new FlowLayoutPanel();
            //flowPanelCbo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowPanelCbo.AutoSize = true;
            flowPanelCbo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowPanelCbo.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowPanelCbo.Margin = new Padding(3, 0, 0, 0);
            flowPanelCbo.MinimumSize = new Size(120, 55);
            
            //combobox
            ComboBox cboIngredientNew = new ComboBox();
            cboIngredientNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboIngredientNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboIngredientNew.MinimumSize = new System.Drawing.Size(250, 33);
            cboIngredientNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cboIngredientNew.Margin = new Padding(0, 0, 0, 0);
            getIngredient(cboIngredientNew);

            //remove button
            Button btnRemoveIngredient = new Button();
            btnRemoveIngredient.Text = "Remove";
            btnRemoveIngredient.Margin = new Padding(0, 0, 0, 0);
            //btnRemoveIngredient.BackColor = Color.FromArgb(248, 80, 80);
            btnRemoveIngredient.Click += (s, n) =>
            {
                flowPaneIngredientInner.Controls.Remove(flowPanelCbo);
                cboIngredientList.Remove(cboIngredientNew);

                if (cboIngredientList.Count() <= 2)
                {
                    btnAddIngredient.Show();
                }
            };

            cboIngredientList.Add(cboIngredientNew);

            //add to the combobox flow panel itself
            flowPanelCbo.Controls.Add(btnRemoveIngredient);
            flowPanelCbo.Controls.Add(cboIngredientNew);

            //add to the flow pane outside
            flowPaneIngredientInner.Controls.Add(flowPanelCbo);

            if (cboIngredientList.Count() == 3)
            {
                btnAddIngredient.Hide();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            decimal price = 0;
            string category = "Food";
            string type = cboCategory.Text;
            int ingredients = (cboIngredient.SelectedItem as ComboboxItem).value;
            string description = txtDescription.Text;

            if (rdoFood.Checked)
            {
                category = "Food";
            }else if (rdoBeverage.Checked)
            {
                category = "Beverage";
            }
            decimal value = 0;

            //checks if entered value can be decimal or not
            if (decimal.TryParse(txtPrice.Text, out value))
            {
                txtPrice.Text = String.Format("{0:0.00}", value);
                //setting price amount
                price = Math.Round(value, 2);
            }
            if ((itemName != "") && (price != 0) && (category != "") && (type != "") && (ingredients != 0) && (itemImagePath != ""))
            {
                try
                {
                    string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    picItem.BackgroundImage.Save(Path.GetFullPath(Path.Combine(RunningPath, @"..\..\Resource\Images\MenuItems\")) + itemImagePath, ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "INSERT INTO item (name, price, description, image, category, type) " +
                    "VALUES('" + itemName + "', '" + price + "', '" + description + "', '" + itemImagePath + "', '" + category + "', '" + type + "')";
                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database
                db.Sqlite_cmd.Dispose();
                db.CloseDBConnection();

                ProductViewForm viewProductPage = new ProductViewForm();
                this.Hide();
                viewProductPage.ShowDialog();
                this.Close(); //close previous form
            }
            else
            {
                if (itemName == "")
                {
                    MessageBox.Show("Please fill in item name");
                }
                if (price == 0)
                {
                    MessageBox.Show("Please fill in price");
                }
                if (category == "")
                {
                    MessageBox.Show("Please select a category");
                }
                if (type == "")
                {
                    MessageBox.Show("Please select a type");
                }
                if (ingredients == 0)
                {
                    MessageBox.Show("Please select an ingredients");
                }
                if (itemImagePath == "")
                {
                    MessageBox.Show("Please upload a picture");
                }
            }

}

        private void rdoBeverage_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
            "Coffee",
            "Tea"});
        }

        private void rdoFood_CheckedChanged(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
            "Pastry",
            "Sides"});
        }
    }
}