namespace CafeSystem.Forms
{
    partial class CashierMenuPage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeViewMenu = new CafeSystem.Components.CustomTreeView();
            this.borderFlowLayoutPane1 = new CafeSystem.Components.BorderFlowLayoutPane();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.borderFlowLayoutPane1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.AlternateBackColor = System.Drawing.Color.White;
            this.treeViewMenu.BackColor = System.Drawing.Color.White;
            this.treeViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeViewMenu.HideSelection = false;
            this.treeViewMenu.ItemHeight = 40;
            this.treeViewMenu.LineColor = System.Drawing.Color.White;
            this.treeViewMenu.Location = new System.Drawing.Point(12, 88);
            this.treeViewMenu.MinimumSize = new System.Drawing.Size(100, 100);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeViewMenu.ShowLines = false;
            this.treeViewMenu.Size = new System.Drawing.Size(295, 711);
            this.treeViewMenu.TabIndex = 3;
            // 
            // borderFlowLayoutPane1
            // 
            this.borderFlowLayoutPane1.Controls.Add(this.button1);
            this.borderFlowLayoutPane1.Controls.Add(this.btnLogOut);
            this.borderFlowLayoutPane1.Controls.Add(this.panelSearch);
            this.borderFlowLayoutPane1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.borderFlowLayoutPane1.Location = new System.Drawing.Point(0, 0);
            this.borderFlowLayoutPane1.Name = "borderFlowLayoutPane1";
            this.borderFlowLayoutPane1.Size = new System.Drawing.Size(1604, 48);
            this.borderFlowLayoutPane1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CafeSystem.Properties.Resources.cart_48;
            this.button1.Location = new System.Drawing.Point(1515, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::CafeSystem.Properties.Resources.logout_24;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1355, 3);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 14, 0);
            this.btnLogOut.Size = new System.Drawing.Size(147, 40);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(1000, 3);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(322, 43);
            this.panelSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::CafeSystem.Properties.Resources.search_24;
            this.btnSearch.Location = new System.Drawing.Point(279, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(9, 6);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(270, 30);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // CashierMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.borderFlowLayoutPane1);
            this.Name = "CashierMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierMenuPage_Load);
            this.borderFlowLayoutPane1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Components.BorderFlowLayoutPane borderFlowLayoutPane1;
        private System.Windows.Forms.Button button1;
        private Components.CustomTreeView treeViewMenu;
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}