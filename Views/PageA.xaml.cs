using FutureState.AppCore.Data;
using Microsoft.Maui.Controls;
using projectChurch.SesFolder;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
namespace projectChurch.Views;

public partial class PageA : ContentPage
{
	public PageA()
	{
		InitializeComponent();

	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		var entries = await App.Database.GetEntriesAsync();
        EntryListView.ItemsSource = entries;

    }
    private async void LoadSavedTexts()
    {
        List<TextEntry> entry = await App.Database.GetEntriesAsync();
        EntryListView.ItemsSource = entry;
       
    }
    private async void OnEntrySelected(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is TextEntry selectedEntry)
		{
			await Navigation.PushAsync(new DetailPage(selectedEntry));
			EntryListView.SelectedItem = null;
		}
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var entry = button.BindingContext as TextEntry;
		if (entry != null)
		{
            bool confirm = await DisplayAlert("Delete", "Are you sure you want to delete this text?", "Yes", "No");
            if (confirm)
            {
                await App.Database.DeleteHighlightedTextAsync(entry);
                LoadSavedTexts();
            }
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        var button = sender as Button;
        var entry = button.BindingContext as TextEntry;
        if(entry != null)
        {
            await Navigation.PushAsync(new DetailPage(entry));
        }
    }
}