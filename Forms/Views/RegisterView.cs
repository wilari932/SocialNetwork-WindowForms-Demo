using SocialMedia.Forms.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Views
{
	public class RegisterView : BaseLoginFormBaseView
	{
		public RegisterView(Actions actions) : base(actions)
		{
			this.labelRegister.Text = "Login";
			this.btnLogin.Text = "Register";
			this.labelRegister.Click += (ev, ob) =>
			{
				actions.RenderLogin();
			};
			this.btnLogin.Click += async(ev, obj) =>
			{
				await actions.CreateUserAsync(txtUserName.Text, this.txtPassword.Text);
			};
	}
	}
}
