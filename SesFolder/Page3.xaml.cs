


using projectChurch.SesFolder;


namespace projectChurch.Views
{

    public partial class Page3 : ContentPage
    {
       
        public Page3()
        {
            InitializeComponent();
            
            EntriesCollView.ItemsSource = TextData.Entries;
        }
      

        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string input = await DisplayPromptAsync("Search" , "Enter Song Number:","OK","Cancel", keyboard: Keyboard.Numeric);

            if(!string.IsNullOrWhiteSpace(input) )
            {
                var matchedEntry = TextData.Entries.FirstOrDefault(entry => entry.Title.Contains(input.Trim(), StringComparison.OrdinalIgnoreCase));

                if (matchedEntry != null)
                {
                    await Navigation.PushAsync(new displayPage(matchedEntry.Title, matchedEntry.Content));
                }
                else
                {
                    await DisplayAlert("Not Found", $"No Entry with Song number '{input}' found. ", "OK");
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
 
}