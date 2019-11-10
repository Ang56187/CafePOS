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

namespace CafeSystem.Forms.Cashier
{

    public partial class ReceiptPage : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fontLbl;
        Font fontHeaderLbl;
        Font fontBtn;

        public ReceiptPage()
        {
            InitializeComponent();

            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontLbl = new Font(fonts.Families[0], 15.0F);
            fontHeaderLbl = new Font(fonts.Families[0], 25.0F, FontStyle.Bold);
            fontBtn = new Font(fonts.Families[0], 15.0F, FontStyle.Bold);


        }

        private void ReceiptPage_Load(object sender, EventArgs e)
        {
            lblPayComplete.Font = lblOrderTxt.Font = lblOrderNum.Font = fontHeaderLbl;
            btnLogOut.Font = btnNextOrder.Font = btnEndDay.Font =  fontBtn;
            lblReceivedTxt.Font = lblReceived.Font = lblTotalTxt.Font = lblTotal.Font =
                lblChangeTxt.Font = lblChange.Font = fontLbl;
            lblNowWat.Font =  new Font(fonts.Families[0], 20.0F);

            btnNextOrder.Image = resizeImage(global::CafeSystem.Properties.Resources.create_48, new Size(35, 33));
            btnEndDay.Image = resizeImage(global::CafeSystem.Properties.Resources.bill_48, new Size(35, 33));


        }

        //for resizing images that are too big
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
