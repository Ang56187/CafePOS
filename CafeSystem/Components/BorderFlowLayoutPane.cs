using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CafeSystem.Components
{
    class BorderFlowLayoutPane:FlowLayoutPanel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen customPen = new Pen(Color.FromArgb(190, 190, 190), 1.75f);

            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(customPen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }
    }
}
