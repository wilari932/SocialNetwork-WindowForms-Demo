using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Views
{
	public class HomeView : BaseView
	{
		public HomeView(Actions actions) : base(actions)
		{
			this.actions.ChangeSize(714, 844);
		}
	}
}
