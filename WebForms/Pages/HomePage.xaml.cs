using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebForms.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
            var homeViewModel = new HomeViewModel();
            BindingContext = homeViewModel;
            InitializeComponent();
        }
    }
}