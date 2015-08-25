using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace View
{
	public partial class PalestrantesPage : ContentPage
	{
		public PalestrantesPage ()
		{
			InitializeComponent ();

			BindingContext = new ViewModel.PalestrantesViewModel ();
		}
	}
}