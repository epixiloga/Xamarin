using FirstXmr1.Models;
using FirstXmr1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXmr1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			List<Personne> users = new List<Personne>()
			{
				new Personne("Hafida", "Elkorchi", 28),
				new Personne("calven", "Klein", 27),
				new Personne("Hugo", "Boss", 18),

			};
			MyPageVM vm = new MyPageVM();
			vm.Users = users;

			BindingContext = vm;
			InitializeComponent ();
			//Adresse adresse1 = new Adresse("France", "Strasbourg");
			//Personne person = new Personne("Hafida", "Elkorchi", 28);
		
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
		//	DisplayAlert("toto","Firstname: " + this.Firstname.Text.ToUpper() +
		//										"\nLastname: "+ this.Lastame.Text.ToUpper()+
		//										"\nAge: " + this.age.Text, "Valider");
		}

		//private void Label_Unfocused(object sender, FocusEventArgs e)
		//{
		//	if (this.Firstname.Text != "")
		//		this.Resources["couleur"] = Color.LightSeaGreen;
		//	else
		//		this.Resources["couleur"] = Color.Transparent;
		//}
	}
}
