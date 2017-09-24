using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test99.Services;
using test99.ViewModel;
using Xamarin.Forms;

namespace test99
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {

            
            InitializeComponent();
            BindingContext = new audioPlayerVM(DependencyService.Get<IAudioPlayerService>());
        }

        
    }
}
