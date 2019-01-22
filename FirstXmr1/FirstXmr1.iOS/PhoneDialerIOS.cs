using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirstXmr1.iOS;
using FirstXmr1.Models;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialerIOS))]
namespace FirstXmr1.iOS
{
	class PhoneDialerIOS : IDialer
	{
		public bool MakeCall(string number)
		{
			if (string.IsNullOrEmpty(number))
			{
				return false;
			}
			else
			{
				// TODO : Call
				return true;
			}
		}
	}
}