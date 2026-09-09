using Microsoft.Maui.Controls;
using projectChurch.Views;
namespace projectChurch.SesFolder
{

	public partial class displayPage : ContentPage
	{
		
		public displayPage(string title, string content)
		{
            InitializeComponent();



            BindingContext = new displayViewModel
			{
				Title = title,
				Content = content
			};


		}

	private async void OnSaveClicked(object sender ,EventArgs e)
		{
			if (BindingContext is  displayViewModel vm)
			{
				var entry = new TextEntry
				{
					Title = vm.Title,
					Content = vm.Content
				};
				await App.Database.SaveEntryAsync(entry);
				await DisplayAlert("Saved", "Entry saved Successfully", "OK");
			}
		}

		
		
	}

	
}