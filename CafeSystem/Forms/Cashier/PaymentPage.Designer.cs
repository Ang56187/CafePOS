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
            this.flowPanelOrderNo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderTxt = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCashPayment = new System.Windows.Forms.Label();
            this.flowPanelCheckout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new CafeSystem.Components.RoundButton();
            this.btnProceed = new CafeSystem.Components.RoundButton();
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
            this.flowPanelPayment.Controls.Add(this.lblPaymentTxt);
            this.flowPanelPayment.Controls.Add(this.txtBoxAmount);
            this.flowPanelPayment.Controls.Add(this.btnProceed);
            this.flowPanelPayment.Location = new System.Drawing.Point(481, 131);
            this.flowPanelPayment.Name = "flowPanelPayment";
            this.flowPanelPayment.Size = new System.Drawing.Size(507, 306);
            this.flowPanelPayment.TabIndex = 6;
            // 
            // lblPaymentTxt
            // 
            this.lblPaymentTxt.AutoSize = true;
            this.lblPaymentTxt.Location = new System.Drawing.Point(3, 40);
            this.lblPaymentTxt.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.lblPaymentTxt.MinimumSize = new System.Drawing.Size(499, 50);
            this.lblPaymentTxt.Name = "lblPaymentTxt";
            this.lblPaymentTxt.Size = new System.Drawing.Size(499, 50);
            this.lblPaymentTxt.TabIndex = 0;
            this.lblPaymentTxt.Text = "Enter payment amount:";
            this.lblPaymentTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.BackColor = System.Drawing.Color.White;
            this.txtBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAmount.Location = new System.Drawing.Point(3, 130);
            this.txtBoxAmount.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtBoxAmount.MinimumSize = new System.Drawing.Size(499, 40);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(499, 40);
            this.txtBoxAmount.TabIndex = 7;
            this.txtBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowPanelOrderNo
            // 
            this.flowPanelOrderNo.Controls.Add(this.lblOrderTxt);
            this.flowPanelOrderNo.Controls.Add(this.lblOrderNum);
            this.flowPanelOrderNo.Location = new System.Drawing.Point(3, 58);
            this.flowPanelOrderNo.Name = "flowPanelOrderNo";
            this.flowPanelOrderNo.Size = new System.Drawing.Size(855, 67);
            this.flowPanelOrderNo.TabIndex = 3;
            // 
            // lblOrderTxt
            // 
            this.lblOrderTxt.AutoSize = true;
            this.lblOrderTxt.Location = new System.Drawing.Point(3, 0);
            this.lblOrderTxt.MinimumSize = new System.Drawing.Size(300, 74);
            this.lblOrderTxt.Name = "lblOrderTxt";
            this.lblOrderTxt.Size = new System.Drawing.Size(300, 74);
            this.lblOrderTxt.TabIndex = 0;
            this.lblOrderTxt.Text = "Order number:";
            this.lblOrderTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.BackColor = System.Drawing.Color.White;
            this.lblOrderNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOrderNum.Location = new System.Drawing.Point(309, 0);
            this.lblOrderNum.MinimumSize = new System.Drawing.Size(10, 74);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(44, 74);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "#54343";
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Silver;
            this.panelLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine1.Location = new System.Drawing.Point(3, 49);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1464, 3);
            this.panelLine1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCashPayment);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblCashPayment
            // 
            this.lblCashPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCashPayment.AutoSize = true;
            this.lblCashPayment.Location = new System.Drawing.Point(485, 0);
            this.lblCashPayment.MinimumSize = new System.Drawing.Size(500, 40);
            this.lblCashPayment.Name = "lblCashPayment";
            this.lblCashPayment.Size = new System.Drawing.Size(400, 32);
            this.lblCashPayment.TabIndex = 0;
            this.lblCashPayment.Text = "Cash Payment";
            this.lblCashPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowPanelCheckout.Location = new System.Drawing.Point(23, 15);
            this.flowPanelCheckout.Name = "flowPanelCheckout";
            this.flowPanelCheckout.Size = new System.Drawing.Size(1474, 745);
            this.flowPanelCheckout.TabIndex = 1;
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
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(10, 0, 14, 0);
            this.btnBack.Size = new System.Drawing.Size(217, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = global::CafeSystem.Properties.Resources.arrow_right_white_48;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.Location = new System.Drawing.Point(3, 213);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(499, 45);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 825);
            this.Controls.Add(this.flowPanelCheckout);
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
    }
}