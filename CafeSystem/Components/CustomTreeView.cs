using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

//caveat: When re-expand list, highlighted node will be gone

namespace CafeSystem.Components
{
    class CustomTreeView : TreeView
    {
        public CustomTreeView()
        {
                DrawMode = TreeViewDrawMode.OwnerDrawText;
                ShowLines = false;
                AlternateBackColor = BackColor;
                HideSelection = false;
                Invalidate();
        }

        public Color AlternateBackColor { get; set; }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            // background
            Color backColor = (GetTopNodeIndex(e.Node) & 1) == 0 ? BackColor : AlternateBackColor;
            using (Brush b = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(b, new Rectangle(0, e.Bounds.Top, ClientSize.Width, e.Bounds.Height));
            }

            // icon
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded)
                {
                    Image icon = global::CafeSystem.Properties.Resources.arrow_down_24; // if expanded, arrow direct to downwards
                    e.Graphics.DrawImage(icon, e.Bounds.Left - icon.Width+5, e.Bounds.Top+10);
                }
                else
                {
                    Image icon = global::CafeSystem.Properties.Resources.arrow_right_24; // if not selected, arrow direct to right
                    e.Graphics.DrawImage(icon, e.Bounds.Left - icon.Width+5, e.Bounds.Top+10);
                }
            }

            // text
            TextRenderer.DrawText(e.Graphics, e.Node.Text, Font, e.Bounds, ForeColor);

            // indicate selection (if not by backColor):
            if ((e.State & TreeNodeStates.Selected) != 0 && e.Node.Parent!=null)
            {
                //ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);
                e.Graphics.DrawImage(global::CafeSystem.Properties.Resources.finger_24, e.Bounds.Left - 35, e.Bounds.Top+10);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, Font, e.Bounds, Color.White,Color.FromArgb(180,180,180));

            }
        }

        private int GetTopNodeIndex(TreeNode node)
        {
            while (node.Parent != null)
                node = node.Parent;

            return Nodes.IndexOf(node);
        }
    }
}
   
