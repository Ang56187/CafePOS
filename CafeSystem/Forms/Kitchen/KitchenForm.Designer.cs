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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenForm));
            this.panelKitchenHeader = new System.Windows.Forms.Panel();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblKitchen = new System.Windows.Forms.Label();
            this.flowPanelKitchen = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.panelKitchenHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKitchenHeader
            // 
            this.panelKitchenHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKitchenHeader.Controls.Add(this.lblTotalOrder);
            this.panelKitchenHeader.Controls.Add(this.btnLogOut);
            this.panelKitchenHeader.Controls.Add(this.lblKitchen);
            this.panelKitchenHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKitchenHeader.Location = new System.Drawing.Point(0, 0);
            this.panelKitchenHeader.Name = "panelKitchenHeader";
            this.panelKitchenHeader.Size = new System.Drawing.Size(1924, 65);
            this.panelKitchenHeader.TabIndex = 9;
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Location = new System.Drawing.Point(901, -4);
            this.lblTotalOrder.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTotalOrder.MinimumSize = new System.Drawing.Size(100, 70);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTotalOrder.Size = new System.Drawing.Size(100, 70);
            this.lblTotalOrder.TabIndex = 6;
            this.lblTotalOrder.Text = "Total:";
            this.lblTotalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKitchen
            // 
            this.lblKitchen.AutoSize = true;
            this.lblKitchen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblKitchen.Location = new System.Drawing.Point(0, 0);
            this.lblKitchen.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKitchen.MinimumSize = new System.Drawing.Size(100, 70);
            this.lblKitchen.Name = "lblKitchen";
            this.lblKitchen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblKitchen.Size = new System.Drawing.Size(121, 70);
            this.lblKitchen.TabIndex = 0;
            this.lblKitchen.Text = "Kitchen page";
            this.lblKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowPanelKitchen
            // 
            this.flowPanelKitchen.AutoSize = true;
            this.flowPanelKitchen.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelKitchen.Location = new System.Drawing.Point(0, 23);
            this.flowPanelKitchen.MaximumSize = new System.Drawing.Size(2200, 2000);
            this.flowPanelKitchen.MinimumSize = new System.Drawing.Size(1940, 900);
            this.flowPanelKitchen.Name = "flowPanelKitchen";
            this.flowPanelKitchen.Size = new System.Drawing.Size(1940, 990);
            this.flowPanelKitchen.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowPanelKitchen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 990);
            this.panel1.TabIndex = 11;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1689, 9);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 12, 40, 4);
            this.btnLogOut.MaximumSize = new System.Drawing.Size(221, 55);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnLogOut.Size = new System.Drawing.Size(221, 45);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelKitchenHeader);
            this.Name = "KitchenForm";
            this.Text = StandardizedNames.FormName;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            this.panelKitchenHeader.ResumeLayout(false);
            this.panelKitchenHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchenHeader;
        private System.Windows.Forms.Label lblKitchen;
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.FlowLayoutPanel flowPanelKitchen;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Panel panel1;
    }
}