using MauiApp1.Views;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnStudentsClicked(System.Object sender, System.EventArgs e)
         => Application.Current.MainPage = new NavigationPage(new Students());

        async void OnEventsClicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new Events());

    }

}
