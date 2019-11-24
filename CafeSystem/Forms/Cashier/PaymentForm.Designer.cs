namespace CafeSystem.Forms.Cashier
{
    partial class PaymentForm
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
            this.flowPanelPayment = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalAmtTxt = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.lblPaymentTxt = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnProceed = new CafeSystem.Components.RoundButton();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCashPayment = new System.Windows.Forms.Label();
            this.btnBack = new CafeSystem.Components.RoundButton();
            this.flowPanelCheckout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelPayment
            // 
            this.flowPanelPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelPayment.AutoScroll = true;
            this.flowPanelPayment.Controls.Add(this.lblTotalAmtTxt);
            this.flowPanelPayment.Controls.Add(this.lblTotalAmt);
            this.flowPanelPayment.Controls.Add(this.lblPaymentTxt);
            this.flowPanelPayment.Controls.Add(this.txtBoxAmount);
            this.flowPanelPayment.Controls.Add(this.lblError);
            this.flowPanelPayment.Controls.Add(this.btnProceed);
            this.flowPanelPayment.Location = new System.Drawing.Point(597, 73);
            this.flowPanelPayment.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelPayment.Name = "flowPanelPayment";
            this.flowPanelPayment.Size = new System.Drawing.Size(676, 578);
            this.flowPanelPayment.TabIndex = 6;
            // 
            // lblTotalAmtTxt
            // 
            this.lblTotalAmtTxt.AutoSize = true;
            this.lblTotalAmtTxt.Location = new System.Drawing.Point(3, 100);
            this.lblTotalAmtTxt.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.lblTotalAmtTxt.MinimumSize = new System.Drawing.Size(665, 62);
            this.lblTotalAmtTxt.Name = "lblTotalAmtTxt";
            this.lblTotalAmtTxt.Size = new System.Drawing.Size(665, 62);
            this.lblTotalAmtTxt.TabIndex = 8;
            this.lblTotalAmtTxt.Text = "Total amount:";
            this.lblTotalAmtTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Location = new System.Drawing.Point(3, 162);
            this.lblTotalAmt.MinimumSize = new System.Drawing.Size(665, 69);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(665, 69);
            this.lblTotalAmt.TabIndex = 9;
            this.lblTotalAmt.Text = "Leftover amount:";
            this.lblTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentTxt
            // 
            this.lblPaymentTxt.AutoSize = true;
            this.lblPaymentTxt.Location = new System.Drawing.Point(4, 266);
            this.lblPaymentTxt.Margin = new System.Windows.Forms.Padding(4, 35, 4, 0);
            this.lblPaymentTxt.MinimumSize = new System.Drawing.Size(665, 62);
            this.lblPaymentTxt.Name = "lblPaymentTxt";
            this.lblPaymentTxt.Size = new System.Drawing.Size(665, 62);
            this.lblPaymentTxt.TabIndex = 0;
            this.lblPaymentTxt.Text = "Enter payment amount:";
            this.lblPaymentTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(3, 331);
            this.txtBoxAmount.MinimumSize = new System.Drawing.Size(4, 40);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(665, 22);
            this.txtBoxAmount.TabIndex = 10;
            this.txtBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAmount_KeyDown);
            this.txtBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAmount_KeyPress);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 374);
            this.lblError.MinimumSize = new System.Drawing.Size(665, 40);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(665, 40);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Leftover amount:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = global::CafeSystem.Properties.Resources.arrow_right_white_48;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.Location = new System.Drawing.Point(4, 424);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(665, 55);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Silver;
            this.panelLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine1.Location = new System.Drawing.Point(4, 61);
            this.panelLine1.Margin = new System.Windows.Forms.Padding(4);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1863, 4);
            this.panelLine1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCashPayment);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1863, 49);
            this.panel1.TabIndex = 1;
            // 
            // lblCashPayment
            // 
            this.lblCashPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCashPayment.AutoSize = true;
            this.lblCashPayment.Location = new System.Drawing.Point(602, 0);
            this.lblCashPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashPayment.MinimumSize = new System.Drawing.Size(667, 49);
            this.lblCashPayment.Name = "lblCashPayment";
            this.lblCashPayment.Size = new System.Drawing.Size(667, 49);
            this.lblCashPayment.TabIndex = 0;
            this.lblCashPayment.Text = "Cash Payment";
            this.lblCashPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::CafeSystem.Properties.Resources.arrow_left_white_48;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnBack.Size = new System.Drawing.Size(289, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flowPanelCheckout
            // 
            this.flowPanelCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelCheckout.BackColor = System.Drawing.Color.White;
            this.flowPanelCheckout.Controls.Add(this.panel1);
            this.flowPanelCheckout.Controls.Add(this.panelLine1);
            this.flowPanelCheckout.Controls.Add(this.flowPanelPayment);
            this.flowPanelCheckout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCheckout.Location = new System.Drawing.Point(31, 18);
            this.flowPanelCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelCheckout.Name = "flowPanelCheckout";
            this.flowPanelCheckout.Size = new System.Drawing.Size(1863, 917);
            this.flowPanelCheckout.TabIndex = 1;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1015);
            this.Controls.Add(this.flowPanelCheckout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentForm";
            this.Text = StandardizedNames.FormName;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.flowPanelPayment.ResumeLayout(false);
            this.flowPanelPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanelCheckout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelPayment;
        private System.Windows.Forms.Label lblPaymentTxt;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCashPayment;
        private Components.RoundButton btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCheckout;
        private Components.RoundButton btnProceed;
        private System.Windows.Forms.Label lblTotalAmtTxt;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label lblError;
    }
}