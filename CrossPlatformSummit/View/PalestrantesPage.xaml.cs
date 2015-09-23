using System;
using System.Collections.Generic;
using CrossPlatformSummit.Core.ViewModels;
using Xamarin.Forms;

namespace View
{
	public partial class PalestrantesPage : ContentPage
	{
		public PalestrantesPage ()
		{
			InitializeComponent ();

			BindingContext = new PalestrantesViewModel ();
		}
	}
}