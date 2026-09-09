using projectChurch.SesFolder;

namespace projectChurch.Views;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        EntriesCollView.ItemsSource = TextDataCreed.Entries;
    }

    private async void EntriesCollView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is TextEntry selectedEntry)
        {
            await Navigation.PushAsync(new displayPage(selectedEntry.Title, selectedEntry.Content));
            EntriesCollView.SelectedItem = null;
        }

    }
    private async void OnSearchClicked(object sender, EventArgs e)
    {
        string input = await DisplayPromptAsync("Search", "Enter the title:", "OK", "Cancel", keyboard: Keyboard.Text);

        if (!string.IsNullOrWhiteSpace(input))
        {
            var matchedEntry = TextDataCreed.Entries.FirstOrDefault(entry => entry.Title.Contains(input.Trim(),StringComparison.OrdinalIgnoreCase) );

            if (matchedEntry != null)
            {
                await Navigation.PushAsync(new displayPage(matchedEntry.Title, matchedEntry.Content));
            }
            else
            {
                await DisplayAlert("Not Found", $"No Title as '{input}' found. ", "OK");
            }
        }
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var selectedEntry = button.BindingContext as TextEntry;
        if (selectedEntry != null)
        {
            await Navigation.PushAsync(new displayPage(selectedEntry.Title, selectedEntry.Content));
        }
    }
}