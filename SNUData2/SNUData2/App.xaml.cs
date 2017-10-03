using SNUData2.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SNUData2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Current.MainPage = new NewItemPage();

            //SetMainPage();
        }

      
    }
}
