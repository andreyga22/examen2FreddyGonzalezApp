namespace examen2FreddyGonzalezApp.Views;
using examen2FreddyGonzalezApp.Models;
using examen2FreddyGonzalezApp.ViewModels;

public partial class BienvenidaPage : ContentPage
{
    UserViewModel? vm;
    public BienvenidaPage()
	{
		InitializeComponent();
        BindingContext = vm = new UserViewModel();
    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e) {
        User currUser = await vm.GetAllUserAsync(TxtUser.Text, TxtPassword.Text);
        if (currUser != null) {
            await Navigation.PushAsync(new PreguntaPage());
        }
        
    }

    private void BtnSignUp_Clicked_1(object sender, EventArgs e) {

    }
}