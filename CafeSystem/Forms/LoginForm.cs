﻿using CafeSystem.Backend;
using CafeSystem.Backend.Objects;
using CafeSystem.Forms.Cashier;
using CafeSystem.Forms.Kitchen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Forms
{
    public partial class LoginForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font btnFont;
        Font textBoxFont;
        Font errorFont;

        //testing, get user collection
        UserCollection userList = new UserCollection();

        //set counter for tries for loggin in
        private int loginCounter = 5;

        public LoginForm()
        {
            InitializeComponent();

        }


        private void login_Load(object sender, EventArgs e)
        {
            //set font
            byte[] fontData = Properties.Resources.Century_Gothic;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Century_Gothic.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Century_Gothic.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            btnFont = new Font(fonts.Families[0], 18.0F, FontStyle.Bold);
            textBoxFont = new Font(fonts.Families[0], 18.0F);
            errorFont = new Font(fonts.Families[0], 15.0F);


            //set font to components
            btnLogin.Font = btnFont;
            txtBoxPassword.Font = textBoxFont;
            txtBoxUsername.Font = textBoxFont;
            lblErrorInput.Font = errorFont;

            lblErrorInput.Hide();

            //center controls
            tablePaneLogin.Left = (this.ClientSize.Width - tablePaneLogin.Width) / 2;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            User lastUser = userList.UserList.Last();

            lblErrorInput.Hide();

            if (!txtBoxUsername.Text.Equals("") || !txtBoxPassword.Text.Equals(""))
            {
                foreach (User user in userList.UserList)
                {
                    if (txtBoxUsername.Text.Equals(user.Name) && txtBoxPassword.Text.Equals(user.Password))
                    {
                        switch (user.Position)
                        {
                            case "Cashier":
                                {
                                    CashierMenuForm menuPage = new CashierMenuForm(user);
                                    this.Hide();
                                    menuPage.ShowDialog();
                                    this.Close(); //close previous form
                                    break;
                                }
                            case "Kitchen":
                                {
                                    KitchenForm kitchenPage = new KitchenForm();
                                    this.Hide();
                                    kitchenPage.ShowDialog();
                                    this.Close(); //close previous form
                                    break;
                                }
                            default:
                                {
                                    lblErrorInput.Text = "User doesnt have a position. Please contact the admin.";
                                    lblErrorInput.Show();
                                    break;
                                }

                        }//end switch
                    }//end if

                    if (!txtBoxUsername.Text.Equals(user.Name) && (user.Equals(lastUser)))
                    {
                        loginCounter -= 1;
                        lblErrorInput.Text = "Please enter valid username . " + loginCounter+" tries left.";
                        lblErrorInput.Show();
                        break;
                    }//end if else
                    else if (!txtBoxPassword.Text.Equals(user.Name) && (user.Equals(lastUser)))
                    {
                        loginCounter -= 1;
                        lblErrorInput.Text = "Please enter valid password. " + loginCounter + " tries left.";
                        lblErrorInput.Show();
                        break;
                    }//end if else

                }//end foreach
            }//end if
            else
            {
                loginCounter -= 1;
                lblErrorInput.Text = "Please enter username or password. "+loginCounter+" tries left.";
                lblErrorInput.Show();
            }//end else

            //if 5 tries of logins failed
            if (loginCounter == 0)
            {
                MessageBox.Show("Invalid user. Closing application now.");
                this.Close();
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxPassword.Focus();
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender,e);
            }
        }
    }
}
