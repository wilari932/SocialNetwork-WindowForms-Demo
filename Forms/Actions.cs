using DataBaseLayer.Services;
using Forms.Views;
using SocialMedia.Forms.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public static class MainFormExtensions
	{
		public static void ClearAndAddControl(this MainForm mainForm, Control control )
		{
			if(mainForm.Controls.Count > 0)
			mainForm.Controls.Clear();
			mainForm.Controls.Add(control);
		}
	}
	public class Actions
    {
		protected readonly MainForm mainForm;
		public void ChangeSize(int with, int height)
		{
			mainForm.Size = new System.Drawing.Size(with, height);
		}
		public Actions(MainForm mainForm)
		{
			this.mainForm = mainForm;
		
			this.mainForm.Load += (ev, ob) =>
			{
				MainPoint();

			};
		}
		private void MainPoint()
		{
			RenderLogin();
		}
		public void RenderLogin()
		{
			mainForm.ClearAndAddControl(new Login(this));
		}
		public void RenderRegisterUser()
		{
			mainForm.ClearAndAddControl(new RegisterView(this));
		}
		public async Task CreateUserAsync(string userName, string password)
		{
			IUserManager userManager = new UserManager();
			try
			{
				await userManager.CreateUserAsync(userName,password);
				RenderLogin();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			
			
		}

		public async Task LoginAsync(string userName, string password)
		{
			IUserManager userManager = new UserManager();
			try
			{
				var  reuslt = await userManager.LoginAsyc(userName, password);
				if (reuslt)
					mainForm.ClearAndAddControl(new HomeView(this));
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}


		}
	}
}
