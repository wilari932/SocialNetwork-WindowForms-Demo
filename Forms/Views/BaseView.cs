using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Views
{
	public class BaseView<T> : Control where T : class
	{
		public T Model { get; set; }
		private readonly Actions actions;
		public BaseView(Actions actions):this(actions,null)
		{
			
		}
		public BaseView(Actions actions,T model)
		{
			this.actions = actions;
			this.Model = model;
		}
	}
	public class BaseView : Control 
	{
		public object Model { get; set; }
		
		public readonly Actions actions;
		public BaseView(Actions actions) : this(actions, null)
		{

		}
		public BaseView(Actions actions, object model)
		{
			this.actions = actions;
			this.Model = model;
		}
	}
}
