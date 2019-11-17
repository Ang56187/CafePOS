namespace CafeSystem.Forms.Cashier
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.flowPanelComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPayComplete = new System.Windows.Forms.Label();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.flowPanelOrderNo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrderTxt = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblReceivedTxt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblChangeTxt = new System.Windows.Forms.Label();
            this.lblNowWat = new System.Windows.Forms.Label();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.flowLayoutBtnOption = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocumentReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogReceipt = new System.Windows.Forms.PrintPreviewDialog();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.btnNextOrder = new CafeSystem.Components.RoundButton();
            this.btnEndDay = new CafeSystem.Components.RoundButton();
            this.btnPrintReceipt = new CafeSystem.Components.RoundButton();
            this.flowPanelComplete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelOrderNo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutBtnOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelComplete
            // 
            this.flowPanelComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelComplete.BackColor = System.Drawing.Color.White;
            this.flowPanelComplete.Controls.Add(this.panel1);
            this.flowPanelComplete.Controls.Add(this.panelLine1);
            this.flowPanelComplete.Controls.Add(this.flowPanelOrderNo);
            this.flowPanelComplete.Controls.Add(this.panel2);
            this.flowPanelComplete.Controls.Add(this.panel4);
            this.flowPanelComplete.Controls.Add(this.panel3);
            this.flowPanelComplete.Controls.Add(this.lblNowWat);
            this.flowPanelComplete.Controls.Add(this.panelLine2);
            this.flowPanelComplete.Controls.Add(this.flowLayoutBtnOption);
            this.flowPanelComplete.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelComplete.Location = new System.Drawing.Point(52, 13);
            this.flowPanelComplete.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanelComplete.Name = "flowPanelComplete";
            this.flowPanelComplete.Size = new System.Drawing.Size(1899, 900);
            this.flowPanelComplete.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPayComplete);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1891, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblPayComplete
            // 
            this.lblPayComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayComplete.AutoSize = true;
            this.lblPayComplete.Location = new System.Drawing.Point(662, 1);
            this.lblPayComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayComplete.MinimumSize = new System.Drawing.Size(667, 49);
            this.lblPayComplete.Name = "lblPayComplete";
            this.lblPayComplete.Size = new System.Drawing.Size(667, 49);
            this.lblPayComplete.TabIndex = 0;
            this.lblPayComplete.Text = "Payment completed!";
            this.lblPayComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.Silver;
            this.panelLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine1.Location = new System.Drawing.Point(4, 65);
            this.panelLine1.Margin = new System.Windows.Forms.Padding(4);
            this.panelLine1.MaximumSize = new System.Drawing.Size(1891, 2);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(1891, 2);
            this.panelLine1.TabIndex = 2;
            // 
            // flowPanelOrderNo
            // 
            this.flowPanelOrderNo.Controls.Add(this.lblOrderTxt);
            this.flowPanelOrderNo.Controls.Add(this.lblOrderNum);
            this.flowPanelOrderNo.Location = new System.Drawing.Point(4, 75);
            this.flowPanelOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelOrderNo.Name = "flowPanelOrderNo";
            this.flowPanelOrderNo.Size = new System.Drawing.Size(1987, 83);
            this.flowPanelOrderNo.TabIndex = 3;
            // 
            // lblOrderTxt
            // 
            this.lblOrderTxt.AutoSize = true;
            this.lblOrderTxt.Location = new System.Drawing.Point(4, 0);
            this.lblOrderTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTxt.MinimumSize = new System.Drawing.Size(400, 80);
            this.lblOrderTxt.Name = "lblOrderTxt";
            this.lblOrderTxt.Size = new System.Drawing.Size(400, 80);
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
            this.lblOrderNum.MinimumSize = new System.Drawing.Size(13, 80);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(56, 80);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "#54343";
            this.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblReceived);
            this.panel2.Controls.Add(this.lblReceivedTxt);
            this.panel2.Location = new System.Drawing.Point(4, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 25, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1891, 37);
            this.panel2.TabIndex = 8;
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblReceived.Location = new System.Drawing.Point(1624, 0);
            this.lblReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceived.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(267, 37);
            this.lblReceived.TabIndex = 1;
            this.lblReceived.Text = "RM32.00";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReceivedTxt
            // 
            this.lblReceivedTxt.AutoSize = true;
            this.lblReceivedTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReceivedTxt.Location = new System.Drawing.Point(0, 0);
            this.lblReceivedTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedTxt.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblReceivedTxt.Name = "lblReceivedTxt";
            this.lblReceivedTxt.Size = new System.Drawing.Size(267, 37);
            this.lblReceivedTxt.TabIndex = 0;
            this.lblReceivedTxt.Text = "Received amount:";
            this.lblReceivedTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.lblTotalTxt);
            this.panel4.Location = new System.Drawing.Point(4, 240);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1891, 37);
            this.panel4.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Location = new System.Drawing.Point(1624, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(267, 37);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "RM32.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTxt.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(267, 37);
            this.lblTotalTxt.TabIndex = 0;
            this.lblTotalTxt.Text = "Total Amount:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblChange);
            this.panel3.Controls.Add(this.lblChangeTxt);
            this.panel3.Location = new System.Drawing.Point(4, 293);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1891, 37);
            this.panel3.TabIndex = 8;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChange.Location = new System.Drawing.Point(1624, 0);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(267, 37);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "RM32.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeTxt
            // 
            this.lblChangeTxt.AutoSize = true;
            this.lblChangeTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChangeTxt.Location = new System.Drawing.Point(0, 0);
            this.lblChangeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeTxt.MinimumSize = new System.Drawing.Size(267, 37);
            this.lblChangeTxt.Name = "lblChangeTxt";
            this.lblChangeTxt.Size = new System.Drawing.Size(267, 37);
            this.lblChangeTxt.TabIndex = 0;
            this.lblChangeTxt.Text = "Change:";
            this.lblChangeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNowWat
            // 
            this.lblNowWat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNowWat.AutoSize = true;
            this.lblNowWat.Location = new System.Drawing.Point(4, 334);
            this.lblNowWat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNowWat.MinimumSize = new System.Drawing.Size(1891, 37);
            this.lblNowWat.Name = "lblNowWat";
            this.lblNowWat.Size = new System.Drawing.Size(1987, 37);
            this.lblNowWat.TabIndex = 13;
            this.lblNowWat.Text = "Now what?";
            this.lblNowWat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLine2
            // 
            this.panelLine2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLine2.BackColor = System.Drawing.Color.Silver;
            this.panelLine2.Location = new System.Drawing.Point(931, 375);
            this.panelLine2.Margin = new System.Windows.Forms.Padding(4);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(133, 4);
            this.panelLine2.TabIndex = 14;
            // 
            // flowLayoutBtnOption
            // 
            this.flowLayoutBtnOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutBtnOption.Controls.Add(this.btnNextOrder);
            this.flowLayoutBtnOption.Controls.Add(this.btnEndDay);
            this.flowLayoutBtnOption.Controls.Add(this.btnPrintReceipt);
            this.flowLayoutBtnOption.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBtnOption.Location = new System.Drawing.Point(710, 408);
            this.flowLayoutBtnOption.Margin = new System.Windows.Forms.Padding(4, 25, 4, 4);
            this.flowLayoutBtnOption.Name = "flowLayoutBtnOption";
            this.flowLayoutBtnOption.Size = new System.Drawing.Size(575, 200);
            this.flowLayoutBtnOption.TabIndex = 15;
            // 
            // printDocumentReceipt
            // 
            this.printDocumentReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentReceipt_PrintPage);
            // 
            // printPreviewDialogReceipt
            // 
            this.printPreviewDialogReceipt.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReceipt.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReceipt.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogReceipt.Enabled = true;
            this.printPreviewDialogReceipt.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogReceipt.Icon")));
            this.printPreviewDialogReceipt.Name = "printPreviewDialogReceipt";
            this.printPreviewDialogReceipt.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::CafeSystem.Properties.Resources.logout_24;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1650, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnLogOut.Size = new System.Drawing.Size(241, 53);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnNextOrder
            // 
            this.btnNextOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(80)))));
            this.btnNextOrder.FlatAppearance.BorderSize = 0;
            this.btnNextOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextOrder.ForeColor = System.Drawing.Color.White;
            this.btnNextOrder.Image = global::CafeSystem.Properties.Resources.create_48;
            this.btnNextOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextOrder.Location = new System.Drawing.Point(4, 4);
            this.btnNextOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextOrder.Name = "btnNextOrder";
            this.btnNextOrder.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnNextOrder.Size = new System.Drawing.Size(571, 50);
            this.btnNextOrder.TabIndex = 1;
            this.btnNextOrder.Text = "Next order";
            this.btnNextOrder.UseVisualStyleBackColor = false;
            this.btnNextOrder.Click += new System.EventHandler(this.btnNextOrder_Click);
            // 
            // btnEndDay
            // 
            this.btnEndDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnEndDay.FlatAppearance.BorderSize = 0;
            this.btnEndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndDay.ForeColor = System.Drawing.Color.White;
            this.btnEndDay.Image = global::CafeSystem.Properties.Resources.bill_48;
            this.btnEndDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndDay.Location = new System.Drawing.Point(4, 70);
            this.btnEndDay.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnEndDay.Size = new System.Drawing.Size(571, 50);
            this.btnEndDay.TabIndex = 2;
            this.btnEndDay.Text = "End business of the day";
            this.btnEndDay.UseVisualStyleBackColor = false;
            this.btnEndDay.Click += new System.EventHandler(this.btnEndDay_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Image = global::CafeSystem.Properties.Resources.printer_48;
            this.btnPrintReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReceipt.Location = new System.Drawing.Point(4, 136);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Padding = new System.Windows.Forms.Padding(13, 0, 19, 0);
            this.btnPrintReceipt.Size = new System.Drawing.Size(571, 50);
            this.btnPrintReceipt.TabIndex = 3;
            this.btnPrintReceipt.Text = "Print receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.flowPanelComplete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReceiptPage_Load);
            this.flowPanelComplete.ResumeLayout(false);
            this.flowPanelComplete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanelOrderNo.ResumeLayout(false);
            this.flowPanelOrderNo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutBtnOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelComplete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPayComplete;
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOrderNo;
        private System.Windows.Forms.Label lblOrderTxt;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblReceivedTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblChangeTxt;
        private System.Windows.Forms.Label lblNowWat;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBtnOption;
        private Components.RoundButton btnNextOrder;
        private Components.RoundButton btnEndDay;
        private Components.RoundButton btnPrintReceipt;
        private System.Drawing.Printing.PrintDocument printDocumentReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogReceipt;
    }
}