using System;
using System.Collections.Generic;
using CrossPlatformSummit.Core.ViewModel;
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