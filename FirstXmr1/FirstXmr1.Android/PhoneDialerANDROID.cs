using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirstXmr1.Droid;
using FirstXmr1.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialerANDROID))]
namespace FirstXmr1.Droid
{	
	class PhoneDialerANDROID : IDialer
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