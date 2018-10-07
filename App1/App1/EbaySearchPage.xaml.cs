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
	public partial class EbaySearchPage : ContentPage
	{
        public EbaySearchPage ()
		{
			InitializeComponent ();
		}

        public void UpdateView()
        {
            EbaySearchView.Source = string.Format(AppData.EbaySearchUrl, AppData.SearchTextEncoded());
        }
    }
}