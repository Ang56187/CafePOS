namespace CafeSystem.Forms.Cashier
{
    partial class CheckoutPage
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
            this.flowPanelCheckout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.flowPanelOrderNo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderTxt = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.flowPanelOrderItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalTxt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSerCharge = new System.Windows.Forms.Label();
            this.lblSerChargeTxt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSerTax = new System.Windows.Forms.Label();
            this.lblSerTaxTxt = new System.Windows.Forms.Label();
            this.panelLine3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblRoundTxt = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.lblPaymentOption = new System.Windows.Forms.Label();
            this.panelLine4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new CafeSystem.Components.RoundButton();
            this.btnCash = new CafeSystem.Components.RoundButton();
            this.btnCreditCard = new CafeSystem.Components.RoundButton();
            this.flowPanelCheckout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelOrderNo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelCheckout
            // 
            this.flowPanelCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelCheckout.BackColor = System.Drawing.Color.White;
            this.flowPanelCheckout.Controls.Add(this.panel1);
            this.flowPanelCheckout.Controls.Add(this.panelLine1);
            this.flowPanelCheckout.Controls.Add(this.flowPanelOrderNo);
            this.flowPanelCheckout.Controls.Add(this.flowPanelOrderItem);
            this.flowPanelCheckout.Controls.Add(this.panelLine2);
            this.flowPanelCheckout.Controls.Add(this.panel2);
            this.flowPanelCheckout.Controls.Add(this.panel3);
            this.flowPanelCheckout.Controls.Add(this.panel4);
            this.flowPanelCheckout.Controls.Add(this.panelLine3);
            this.flowPanelCheckout.Controls.Add(this.panel5);
            this.flowPanelCheckout.Controls.Add(this.panel6);
            this.flowPanelCheckout.Controls.Add(this.lblPaymentOption);
            this.flowPanelCheckout.Controls.Add(this.panelLine4);
            this.flowPanelCheckout.Controls.Add(this.flowLayoutPanel1);
            this.flowPanelCheckout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCheckout.Location = new System.Drawing.Point(65, 11);
            this.flowPanelCheckout.Name = "flowPanelCheckout";
            this.flowPanelCheckout.Size = new System.Drawing.Size(1474, 795);
            this.flowPanelCheckout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCheckout);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(516, 0);
            this.lblCheckout.MinimumSize = new System.Drawing.Size(500, 40);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(500, 40);
            this.lblCheckout.TabIndex = 0;
            this.lblCheckout.Text = "Payment checkout";
            this.lblCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // flowPanelOrderItem
            // 
            this.flowPanelOrderItem.AutoScroll = true;
            this.flowPanelOrderItem.Location = new System.Drawing.Point(3, 131);
            this.flowPanelOrderItem.Name = "flowPanelOrderItem";
            this.flowPanelOrderItem.Size = new System.Drawing.Size(1464, 306);
            this.flowPanelOrderItem.TabIndex = 6;
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.Silver;
            this.panelLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine2.Location = new System.Drawing.Point(3, 443);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(1464, 3);
            this.panelLine2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.lblSubTotalTxt);
            this.panel2.Location = new System.Drawing.Point(3, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 30);
            this.panel2.TabIndex = 7;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubTotal.Location = new System.Drawing.Point(1264, 0);
            this.lblSubTotal.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(200, 30);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "RM32.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalTxt
            // 
            this.lblSubTotalTxt.AutoSize = true;
            this.lblSubTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotalTxt.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSubTotalTxt.Name = "lblSubTotalTxt";
            this.lblSubTotalTxt.Size = new System.Drawing.Size(200, 30);
            this.lblSubTotalTxt.TabIndex = 0;
            this.lblSubTotalTxt.Text = "Sub-total:";
            this.lblSubTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSerCharge);
            this.panel3.Controls.Add(this.lblSerChargeTxt);
            this.panel3.Location = new System.Drawing.Point(3, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1464, 30);
            this.panel3.TabIndex = 8;
            // 
            // lblSerCharge
            // 
            this.lblSerCharge.AutoSize = true;
            this.lblSerCharge.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSerCharge.Location = new System.Drawing.Point(1264, 0);
            this.lblSerCharge.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSerCharge.Name = "lblSerCharge";
            this.lblSerCharge.Size = new System.Drawing.Size(200, 30);
            this.lblSerCharge.TabIndex = 1;
            this.lblSerCharge.Text = "RM32.00";
            this.lblSerCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSerChargeTxt
            // 
            this.lblSerChargeTxt.AutoSize = true;
            this.lblSerChargeTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSerChargeTxt.Location = new System.Drawing.Point(0, 0);
            this.lblSerChargeTxt.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSerChargeTxt.Name = "lblSerChargeTxt";
            this.lblSerChargeTxt.Size = new System.Drawing.Size(200, 30);
            this.lblSerChargeTxt.TabIndex = 0;
            this.lblSerChargeTxt.Text = "Service charge(10%):";
            this.lblSerChargeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSerTax);
            this.panel4.Controls.Add(this.lblSerTaxTxt);
            this.panel4.Location = new System.Drawing.Point(3, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1464, 30);
            this.panel4.TabIndex = 8;
            // 
            // lblSerTax
            // 
            this.lblSerTax.AutoSize = true;
            this.lblSerTax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSerTax.Location = new System.Drawing.Point(1264, 0);
            this.lblSerTax.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSerTax.Name = "lblSerTax";
            this.lblSerTax.Size = new System.Drawing.Size(200, 30);
            this.lblSerTax.TabIndex = 1;
            this.lblSerTax.Text = "RM32.00";
            this.lblSerTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSerTaxTxt
            // 
            this.lblSerTaxTxt.AutoSize = true;
            this.lblSerTaxTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSerTaxTxt.Location = new System.Drawing.Point(0, 0);
            this.lblSerTaxTxt.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSerTaxTxt.Name = "lblSerTaxTxt";
            this.lblSerTaxTxt.Size = new System.Drawing.Size(200, 30);
            this.lblSerTaxTxt.TabIndex = 0;
            this.lblSerTaxTxt.Text = "Service tax(6%):";
            this.lblSerTaxTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLine3
            // 
            this.panelLine3.BackColor = System.Drawing.Color.Silver;
            this.panelLine3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine3.Location = new System.Drawing.Point(3, 560);
            this.panelLine3.Name = "panelLine3";
            this.panelLine3.Size = new System.Drawing.Size(1464, 3);
            this.panelLine3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblRound);
            this.panel5.Controls.Add(this.lblRoundTxt);
            this.panel5.Location = new System.Drawing.Point(3, 569);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1464, 40);
            this.panel5.TabIndex = 9;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRound.Location = new System.Drawing.Point(1264, 0);
            this.lblRound.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(200, 40);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "RM32.00";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoundTxt
            // 
            this.lblRoundTxt.AutoSize = true;
            this.lblRoundTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRoundTxt.Location = new System.Drawing.Point(0, 0);
            this.lblRoundTxt.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblRoundTxt.Name = "lblRoundTxt";
            this.lblRoundTxt.Size = new System.Drawing.Size(200, 40);
            this.lblRoundTxt.TabIndex = 0;
            this.lblRoundTxt.Text = "Rounding:";
            this.lblRoundTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.lblTotalTxt);
            this.panel6.Location = new System.Drawing.Point(3, 615);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1464, 40);
            this.panel6.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Location = new System.Drawing.Point(1264, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 40);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "RM32.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTxt.MinimumSize = new System.Drawing.Size(200, 40);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(200, 40);
            this.lblTotalTxt.TabIndex = 0;
            this.lblTotalTxt.Text = "Total:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentOption
            // 
            this.lblPaymentOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentOption.AutoSize = true;
            this.lblPaymentOption.Location = new System.Drawing.Point(3, 658);
            this.lblPaymentOption.MinimumSize = new System.Drawing.Size(0, 30);
            this.lblPaymentOption.Name = "lblPaymentOption";
            this.lblPaymentOption.Size = new System.Drawing.Size(1464, 30);
            this.lblPaymentOption.TabIndex = 11;
            this.lblPaymentOption.Text = "Payment option";
            this.lblPaymentOption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLine4
            // 
            this.panelLine4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLine4.BackColor = System.Drawing.Color.Silver;
            this.panelLine4.Location = new System.Drawing.Point(685, 691);
            this.panelLine4.Name = "panelLine4";
            this.panelLine4.Size = new System.Drawing.Size(100, 3);
            this.panelLine4.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnCash);
            this.flowLayoutPanel1.Controls.Add(this.btnCreditCard);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(419, 700);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 45);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CafeSystem.Properties.Resources.logout_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1241, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 14, 0);
            this.btnCancel.Size = new System.Drawing.Size(223, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(80)))));
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Image = global::CafeSystem.Properties.Resources.cash_48;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.Location = new System.Drawing.Point(3, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.Padding = new System.Windows.Forms.Padding(10, 0, 14, 0);
            this.btnCash.Size = new System.Drawing.Size(296, 40);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(80)))));
            this.btnCreditCard.FlatAppearance.BorderSize = 0;
            this.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCard.ForeColor = System.Drawing.Color.White;
            this.btnCreditCard.Image = global::CafeSystem.Properties.Resources.card_48;
            this.btnCreditCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCard.Location = new System.Drawing.Point(332, 3);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.btnCreditCard.Size = new System.Drawing.Size(296, 40);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "Credit card";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 831);
            this.Controls.Add(this.flowPanelCheckout);
            this.Name = "CheckoutPage";
            this.Text = "Sunway Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckoutPage_Load);
            this.flowPanelCheckout.ResumeLayout(false);
            this.flowPanelCheckout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanelOrderNo.ResumeLayout(false);
            this.flowPanelOrderNo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelCheckout;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panel1;
        private Components.RoundButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOrderNo;
        private System.Windows.Forms.Label lblOrderTxt;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOrderItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTotalTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSerCharge;
        private System.Windows.Forms.Label lblSerChargeTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSerTax;
        private System.Windows.Forms.Label lblSerTaxTxt;
        private System.Windows.Forms.Panel panelLine3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblRoundTxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Label lblPaymentOption;
        private System.Windows.Forms.Panel panelLine4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Components.RoundButton btnCash;
        private Components.RoundButton btnCreditCard;
    }
}