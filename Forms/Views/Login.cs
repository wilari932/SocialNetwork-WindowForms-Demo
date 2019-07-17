using ExtencionMethods.StringExtencions;
using Forms;
using Forms.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SocialMedia.Forms.Main
{
	public class Login : BaseLoginFormBaseView
	{
		public Login(Actions actions) : base(actions)
		{
			this.labelRegister.Text = "Register";
			this.btnLogin.Text = "Login";
			this.labelRegister.Click += (ev,ob) =>
			{
				actions.RenderRegisterUser();
			};
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			
		}
		private async void btnLogin_Click(object sender, EventArgs e)
		{
			await actions.LoginAsync(txtUserName.Text, txtPassword.Text);
		}
	}
}
