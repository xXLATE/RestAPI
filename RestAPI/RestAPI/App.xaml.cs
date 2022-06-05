using Xamarin.Forms;
using RestAPI.Views;
using RestAPI.Servies;

namespace RestAPI
{
    public partial class App : Application
    {
        public static RestManager restManager { get;private set; }
        public App()
        {
            restManager = new RestManager(new RestService());
            MainPage = new NavigationPage(new ToDoEntry());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
