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

        //for password decryption
        public string GenerateEncryptionKey()
        {
            string EncryptionKey = string.Empty;

            Random Robj = new Random();
            int Rnumber = Robj.Next();
            EncryptionKey = "LetMeIn";

            return EncryptionKey;
        }

        public string Encrypt(string clearText, string EncryptionKey)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = Encrypt(txtPassword.Text, GenerateEncryptionKey());
            string position = cboPosition.Text;

            if ((username != "") && (password != "") && (position != "")){
                db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
                db.Sqlite_cmd.CommandText = "INSERT INTO user (user_name, user_password, user_role) " +
                    "VALUES('"+ username + "', '" + password + "', '" + position + "')";
                db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database
                db.Sqlite_cmd.Dispose();
                db.CloseDBConnection();

                UserViewForm viewUserPage = new UserViewForm();
                this.Hide();
                viewUserPage.ShowDialog();
                this.Close(); //close previous form
            }
            else
            {
                MessageBox.Show("Please Do Not Leave Any Empty Box");
            }

            

        }
    }
}