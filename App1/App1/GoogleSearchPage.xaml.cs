using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GoogleSearchPage : ContentPage
    {
		public GoogleSearchPage ()
		{
			InitializeComponent ();
		}

        public void UpdateView()
        {
            GoogleSearchView.Source = string.Format(AppData.GoogleSearchUrl, AppData.SearchTextEncoded());
        }
    }
}