using Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SocialMedia.Forms.Main
{
	public class MainForm:Form
	{
		private FlowLayoutPanel flowLayoutPanel1;

		public MainForm()
		{
			new Actions(this);
		}

		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 805);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(698, 805);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "MainForm";
			this.ResumeLayout(false);

		}

		
	}
}
