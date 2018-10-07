using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            CurrentPageChanged += MainPage_CurrentPageChanged;
        }

        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            Type currentType = CurrentPage.Navigation.NavigationStack.First().GetType();

            if(currentType == typeof(AmazonSearchPage))
            {
                var tempAmazon = (AmazonSearchPage)CurrentPage.Navigation.NavigationStack.First();
                tempAmazon.UpdateView();
            }
            else if(currentType == typeof(GoogleSearchPage))
            {
                var tempGoogle = CurrentPage.Navigation.NavigationStack.First() as GoogleSearchPage;
                tempGoogle.UpdateView();
            }
            else if(currentType == typeof(EbaySearchPage))
            {
                var tempEbay = CurrentPage.Navigation.NavigationStack.First() as EbaySearchPage;
                tempEbay.UpdateView();
            }
            else if(currentType == typeof(CustomSearchPage))
            {
                var tempCustom = CurrentPage.Navigation.NavigationStack.First() as CustomSearchPage;
                tempCustom.UpdateView();
            }
            
        }
    }
}
