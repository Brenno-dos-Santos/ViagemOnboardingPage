using ViagemOnboardingPage.ViewModels;

namespace ViagemOnboardingPage.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemItemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}