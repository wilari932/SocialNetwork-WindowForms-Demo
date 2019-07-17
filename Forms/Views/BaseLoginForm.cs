using ExtencionMethods.StringExtencions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views
{
	public abstract class BaseLoginFormBaseView : BaseView
	{
		protected System.Windows.Forms.TextBox txtUserName;
		protected System.Windows.Forms.TextBox txtPassword;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Label labelRegister;
		protected System.Windows.Forms.Button btnLogin;

		public BaseLoginFormBaseView(Actions actions) : base(actions)
		{

			this.actions.ChangeSize(555, 594);
			initControls();

		}
		void initControls()
		{
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelRegister = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();

			// 
			// textBox1
			// 
			this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(130, 160);
			this.txtUserName.Name = "textBox1"; ;
			this.txtUserName.Size = new System.Drawing.Size(278, 42);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.TextChanged += (ev, ob) =>
			{
				this.btnLogin.Enabled = (!this.txtUserName.Text.IsBlanktOrNull()) && (!txtPassword.Text.IsBlanktOrNull());
			};
			// 
			// textBox2
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(130, 274);
			this.txtPassword.Name = "textBox2";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(278, 42);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.TextChanged += (ev, ob) =>
			{
				this.btnLogin.Enabled = (!this.txtUserName.Text.IsBlanktOrNull()) && (!txtPassword.Text.IsBlanktOrNull());
			};
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(120, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(247, 55);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(131, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(236, 55);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";

			// 
			// labelregister
			// 
			this.labelRegister.AutoSize = true;
			this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegister.ForeColor = System.Drawing.Color.White;
			this.labelRegister.Location = new System.Drawing.Point(130, 400);
			this.labelRegister.Name = "label2";
			this.labelRegister.Size = new System.Drawing.Size(100, 48);
			this.labelRegister.TabIndex = 3;
			this.labelRegister.MouseEnter += (ev, ob) =>
			{
				this.labelRegister.ForeColor = System.Drawing.Color.Blue;

			};
			this.labelRegister.MouseLeave += (ev, ob) =>
			{
				this.labelRegister.ForeColor = System.Drawing.Color.White;

			};

			// 
			// button1
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(130, 347);
			this.btnLogin.Name = "button1";
			this.btnLogin.Size = new System.Drawing.Size(278, 48);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;

			this.btnLogin.Enabled = false;
			// 
			// form
			// 

			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
			this.ClientSize = new System.Drawing.Size(539, 555);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelRegister);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "Login";
			this.Text = "Login";
			this.Dock = DockStyle.Fill;

		}
		
	}

}
