namespace ModalPageIssueRepo;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}