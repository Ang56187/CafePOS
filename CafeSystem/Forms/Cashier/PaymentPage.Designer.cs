namespace CafeSystem.Forms.Cashier
{
    partial class PaymentPage
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
            this.lblPaymentTxt = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnProceed = new CafeSystem.Components.RoundButton();
            this.flowPanelOrderNo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderTxt = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCashPayment = new System.Windows.Forms.Label();
            this.btnBack = new CafeSystem.Components.RoundButton();
            this.flowPanelCheckout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLeftAmountTxt = new System.Windows.Forms.Label();
            this.lblLeftAmount = new System.Windows.Forms.Label();
            this.flowPanelPayment.SuspendLayout();
            this.flowPanelOrderNo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelPayment
            // 
            this.flowPanelPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelPayment.AutoScroll = true;
            this.flowPanelPayment.Controls.Add(this.lblLeftAmountTxt);
            this.flowPanelPayment.Controls.Add(this.lblLeftAmount);
            this.flowPanelPayment.Controls.Add(this.lblPaymentTxt);
            this.flowPanelPayment.Controls.Add(this.txtBoxAmount);
            this.flowPanelPayment.Controls.Add(this.btnProceed);
            this.flowPanelPayment.Location = new System.Drawing.Point(642, 163);
            this.flowPanelPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowPanelPayment.Name = "flowPanelPayment";
            this.flowPanelPayment.Size = new System.Drawing.Size(676, 462);
            this.flowPanelPayment.TabIndex = 6;
            // 
            // lblPaymentTxt
            // 
            this.lblPaymentTxt.AutoSize = true;
            this.lblPaymentTxt.Location = new System.Drawing.Point(4, 159);
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
            this.txtBoxAmount.BackColor = System.Drawing.Color.White;
            this.txtBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAmount.Location = new System.Drawing.Point(4, 270);
            this.txtBoxAmount.Margin = new System.Windows.Forms.Padding(4, 49, 4, 4);
            this.txtBoxAmount.MinimumSize = new System.Drawing.Size(665, 40);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(665, 40);
            this.txtBoxAmount.TabIndex = 7;
            this.txtBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = global::CafeSystem.Properties.Resources.arrow_right_white_48;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.Location = new System.Drawing.Point(4, 349);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4, 35, 4, 4);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(665, 55);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            // 
            // flowPanelOrderNo
            // 
            this.flowPanelOrderNo.Controls.Add(this.lblOrderTxt);
            this.flowPanelOrderNo.Controls.Add(this.lblOrderNum);
            this.flowPanelOrderNo.Location = new System.Drawing.Point(4, 73);
            this.flowPanelOrderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowPanelOrderNo.Name = "flowPanelOrderNo";
            this.flowPanelOrderNo.Size = new System.Drawing.Size(1140, 82);
            this.flowPanelOrderNo.TabIndex = 3;
            // 
            // lblOrderTxt
            // 
            this.lblOrderTxt.AutoSize = true;
            this.lblOrderTxt.Location = new System.Drawing.Point(4, 0);
            this.lblOrderTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTxt.MinimumSize = new System.Drawing.Size(400, 91);
            this.lblOrderTxt.Name = "lblOrderTxt";
            this.lblOrderTxt.Size = new System.Drawing.Size(400, 91);
            this.lblOrderTxt.TabIndex = 0;
            this.lblOrderTxt.Text = "Order number:";
            this.lblOrderTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.BackColor = System.Drawing.Color.White;
            this.lblOrderNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOrderNum.Location = new System.Drawing.Point(412, 0);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNum.MinimumSize = new System.Drawing.Size(13, 91);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(56, 91);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "#54343";
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Silver;
            this.panelLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine1.Location = new System.Drawing.Point(4, 61);
            this.panelLine1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1952, 4);
            this.panelLine1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCashPayment);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1952, 49);
            this.panel1.TabIndex = 1;
            // 
            // lblCashPayment
            // 
            this.lblCashPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCashPayment.AutoSize = true;
            this.lblCashPayment.Location = new System.Drawing.Point(647, 0);
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnBack.Size = new System.Drawing.Size(289, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // flowPanelCheckout
            // 
            this.flowPanelCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelCheckout.BackColor = System.Drawing.Color.White;
            this.flowPanelCheckout.Controls.Add(this.panel1);
            this.flowPanelCheckout.Controls.Add(this.panelLine1);
            this.flowPanelCheckout.Controls.Add(this.flowPanelOrderNo);
            this.flowPanelCheckout.Controls.Add(this.flowPanelPayment);
            this.flowPanelCheckout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCheckout.Location = new System.Drawing.Point(31, 18);
            this.flowPanelCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowPanelCheckout.Name = "flowPanelCheckout";
            this.flowPanelCheckout.Size = new System.Drawing.Size(1965, 917);
            this.flowPanelCheckout.TabIndex = 1;
            // 
            // lblLeftAmountTxt
            // 
            this.lblLeftAmountTxt.AutoSize = true;
            this.lblLeftAmountTxt.Location = new System.Drawing.Point(3, 0);
            this.lblLeftAmountTxt.MinimumSize = new System.Drawing.Size(665, 62);
            this.lblLeftAmountTxt.Name = "lblLeftAmountTxt";
            this.lblLeftAmountTxt.Size = new System.Drawing.Size(665, 62);
            this.lblLeftAmountTxt.TabIndex = 8;
            this.lblLeftAmountTxt.Text = "Leftover amount:";
            this.lblLeftAmountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftAmount
            // 
            this.lblLeftAmount.AutoSize = true;
            this.lblLeftAmount.Location = new System.Drawing.Point(3, 62);
            this.lblLeftAmount.MinimumSize = new System.Drawing.Size(665, 62);
            this.lblLeftAmount.Name = "lblLeftAmount";
            this.lblLeftAmount.Size = new System.Drawing.Size(665, 62);
            this.lblLeftAmount.TabIndex = 9;
            this.lblLeftAmount.Text = "Leftover amount:";
            this.lblLeftAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1015);
            this.Controls.Add(this.flowPanelCheckout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentPage";
            this.Text = "Sunway Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.flowPanelPayment.ResumeLayout(false);
            this.flowPanelPayment.PerformLayout();
            this.flowPanelOrderNo.ResumeLayout(false);
            this.flowPanelOrderNo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanelCheckout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelPayment;
        private System.Windows.Forms.Label lblPaymentTxt;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOrderNo;
        private System.Windows.Forms.Label lblOrderTxt;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCashPayment;
        private Components.RoundButton btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCheckout;
        private Components.RoundButton btnProceed;
        private System.Windows.Forms.MaskedTextBox txtBoxAmount;
        private System.Windows.Forms.Label lblLeftAmountTxt;
        private System.Windows.Forms.Label lblLeftAmount;
    }
}