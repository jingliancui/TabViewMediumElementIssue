namespace SampleApp;

public partial class CustomizeView : ContentView
{
	public CustomizeView()
	{
		InitializeComponent();

		BindingContext = new CustomizeViewViewModel();
	}
}