using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Forms
{
    public partial class LoginPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font btnFont;
        Font textBoxFont;

        public LoginPage()
        {
            InitializeComponent();

        }



        private void login_Load(object sender, EventArgs e)
        {
            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            btnFont = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            textBoxFont = new Font(fonts.Families[0], 20.0F);

            //set font to components
            btnLogin.Font = btnFont;
            txtBoxPassword.Font = textBoxFont;
            txtBoxUsername.Font = textBoxFont;

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            SelectionPage select_page = new SelectionPage();
            this.Hide();
            select_page.ShowDialog();
            this.Close(); //close previous form
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
