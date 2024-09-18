using Aula_MVVM_HTTPClient.ViewModels;

namespace Aula_MVVM_HTTPClient.Views;
public partial class PostView : ContentPage
{
	public PostView()
	{
		BindingContext = new PostViewModel();
		InitializeComponent();
	}
}