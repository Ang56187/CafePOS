using System.Drawing;

namespace CafeSystem.Forms
{
    partial class SelectionPage
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
            this.line1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.btnEndBusiness = new CafeSystem.Components.RoundButton();
            this.btnMenu = new CafeSystem.Components.RoundButton();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(928, 410);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(345, 4);
            this.line1.TabIndex = 1;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Silver;
            this.line2.Location = new System.Drawing.Point(757, 517);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(687, 4);
            this.line2.TabIndex = 2;
            // 
            // btnEndBusiness
            // 
            this.btnEndBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnEndBusiness.FlatAppearance.BorderSize = 0;
            this.btnEndBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndBusiness.ForeColor = System.Drawing.Color.White;
            this.btnEndBusiness.Image = global::CafeSystem.Properties.Resources.bill_48;
            this.btnEndBusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndBusiness.Location = new System.Drawing.Point(757, 546);
            this.btnEndBusiness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndBusiness.Name = "btnEndBusiness";
            this.btnEndBusiness.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEndBusiness.Size = new System.Drawing.Size(687, 74);
            this.btnEndBusiness.TabIndex = 4;
            this.btnEndBusiness.Text = "End business of the day";
            this.btnEndBusiness.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::CafeSystem.Properties.Resources.restaurant_128;
            this.btnMenu.Location = new System.Drawing.Point(894, 160);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.btnMenu.Size = new System.Drawing.Size(412, 335);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Cashier menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // SelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1875, 823);
            this.Controls.Add(this.btnEndBusiness);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.btnMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectionPage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelectionPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CafeSystem.Components.RoundButton btnMenu;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line2;
        private CafeSystem.Components.RoundButton btnEndBusiness;
    }
}