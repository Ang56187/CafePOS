namespace CafeSystem.Forms.Kitchen
{
    partial class KitchenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutHeader = new CafeSystem.Components.BorderFlowLayoutPane();
            this.SuspendLayout();
            // 
            // flowLayoutHeader
            // 
            this.flowLayoutHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutHeader.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutHeader.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutHeader.Name = "flowLayoutHeader";
            this.flowLayoutHeader.Size = new System.Drawing.Size(1924, 71);
            this.flowLayoutHeader.TabIndex = 8;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.flowLayoutHeader);
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Components.BorderFlowLayoutPane flowLayoutHeader;
    }
}