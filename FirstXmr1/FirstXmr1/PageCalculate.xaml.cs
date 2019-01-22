using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXmr1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageCalculate : ContentPage
	{
		public PageCalculate ()
		{
			InitializeComponent ();
		}

	
		private void Button_Clicked_num(object sender, EventArgs e)
		{
			var myButton = (Button)sender;
			this.num.Text += myButton.Text;

			//return int.Parse(this.num.Text);
		}

		private void Button_Clicked_operator(object sender, EventArgs e)
		{
			var myButton = (Button)sender;
			this.num.Text += myButton.Text;

		}
		private void Button_Clicked_calculate(object sender, EventArgs e)
		{
			var result = new DataTable().Compute(this.num.Text, "");
			this.num.Text = result.ToString();

			//if (this.num.Text[this.num.Text.Length - 1].IsDigit())
			//{
			//	var result = new DataTable().Compute(this.num.Text, "");
			//	this.num.Text = result.ToString();
			//}
		}

		private void Button_Clicked_clear(object sender, EventArgs e)
		{
			this.num.Text = "0";
		}

		//private void Button_Clicked_pourcent(object sender, EventArgs e)
		//{
		//	var myButton = (Button)sender;
		//	this.num.Text= (int.Parse(this.num.Text)/100).ToString();
		//}

		private void Button_Clicked_plusMinus(object sender, EventArgs e)
		{
			if (int.TryParse(this.num.Text, out int result))
			{
				if (result > 0)
					this.num.Text = "-" + result;
				else
					this.num.Text = "" + result;
			}
		}

		private void Button_Clicked_pourcent(object sender, EventArgs e)
		{
			if (int.TryParse(this.num.Text, out int result))
			{
				this.num.Text = "" + result / 100;

			}
		}

		//private void Button_Clicked_comma(object sender, EventArgs e)
		//{
		//	if (this.num.Text[this.num.Text.Length - 1].IsDigit())
		//		this.num.Text += ".";

		//}
	}
}