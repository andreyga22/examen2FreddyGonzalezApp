using examen2FreddyGonzalezApp.Views;

namespace examen2FreddyGonzalezApp {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new BienvenidaPage());
        }
    }
}
