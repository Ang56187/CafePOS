using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Forms
{
    public partial class CashierMenuPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font treeViewFont;
        Font btnFont;
        Font txtBoxFont;

        public CashierMenuPage()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            treeViewFont = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            btnFont = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);
            txtBoxFont = btnFont = new Font(fonts.Families[0], 15.0F);

        }

        private void CashierMenuPage_Load(object sender, EventArgs e)
        {
            treeViewMenu.Font = treeViewFont;
            btnLogOut.Font = btnFont;
            txtBoxSearch.Font = txtBoxFont;
        }

    }
}
