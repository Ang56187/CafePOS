namespace CafeSystem.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.logo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblErrorInput = new System.Windows.Forms.Label();
            this.tablePaneLogin = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new CafeSystem.Components.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.tablePaneLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Controls.Add(this.lblLogo);
            this.logo.Controls.Add(this.picBoxLogo);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(328, 24);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.MaximumSize = new System.Drawing.Size(345, 319);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(345, 263);
            this.logo.TabIndex = 0;
            this.logo.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(52, 186);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(88, 17);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Sunway cafe";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxLogo.Image = global::CafeSystem.Properties.Resources.coffee_white_128;
            this.picBoxLogo.Location = new System.Drawing.Point(109, 42);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(130, 119);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPassword.Location = new System.Drawing.Point(329, 407);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPassword.MaximumSize = new System.Drawing.Size(344, 40);
            this.txtBoxPassword.MinimumSize = new System.Drawing.Size(344, 40);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(344, 40);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            this.txtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPassword_KeyDown);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.BackColor = System.Drawing.Color.White;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsername.Location = new System.Drawing.Point(329, 319);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsername.MaximumSize = new System.Drawing.Size(344, 40);
            this.txtBoxUsername.MinimumSize = new System.Drawing.Size(344, 40);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(344, 40);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            this.txtBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUsername_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblErrorInput
            // 
            this.lblErrorInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorInput.AutoSize = true;
            this.lblErrorInput.BackColor = System.Drawing.SystemColors.Window;
            this.lblErrorInput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInput.Location = new System.Drawing.Point(151, 493);
            this.lblErrorInput.MinimumSize = new System.Drawing.Size(700, 40);
            this.lblErrorInput.Name = "lblErrorInput";
            this.lblErrorInput.Size = new System.Drawing.Size(700, 40);
            this.lblErrorInput.TabIndex = 5;
            this.lblErrorInput.Text = "label1";
            this.lblErrorInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePaneLogin
            // 
            this.tablePaneLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tablePaneLogin.ColumnCount = 1;
            this.tablePaneLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePaneLogin.Controls.Add(this.lblErrorInput, 0, 3);
            this.tablePaneLogin.Controls.Add(this.txtBoxPassword, 0, 2);
            this.tablePaneLogin.Controls.Add(this.btnLogin, 0, 4);
            this.tablePaneLogin.Controls.Add(this.logo, 0, 0);
            this.tablePaneLogin.Controls.Add(this.txtBoxUsername, 0, 1);
            this.tablePaneLogin.Location = new System.Drawing.Point(395, 160);
            this.tablePaneLogin.Name = "tablePaneLogin";
            this.tablePaneLogin.RowCount = 5;
            this.tablePaneLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.37801F));
            this.tablePaneLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.62198F));
            this.tablePaneLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tablePaneLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tablePaneLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tablePaneLogin.Size = new System.Drawing.Size(1002, 621);
            this.tablePaneLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(328, 552);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.MaximumSize = new System.Drawing.Size(345, 55);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(345, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePaneLogin);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1798, 1015);
            this.panel1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1797, 1015);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunway Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.tablePaneLogin.ResumeLayout(false);
            this.tablePaneLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CafeSystem.Components.RoundButton btnLogin;
        private System.Windows.Forms.Label lblErrorInput;
        private System.Windows.Forms.TableLayoutPanel tablePaneLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
    }
}

