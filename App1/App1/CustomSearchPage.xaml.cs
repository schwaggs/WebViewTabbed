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
	public partial class CustomSearchPage : ContentPage
	{
        public CustomSearchPage ()
		{
			InitializeComponent ();
		}

        public void UpdateView()
        {
            CustomSearchView.Source = string.Format(AppData.CustomSearchUrl, AppData.SearchTextEncoded());
        }
    }
}