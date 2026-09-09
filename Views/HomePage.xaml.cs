using Microsoft.Maui.Controls;
using projectChurch.SesFolder;
using System.Collections.ObjectModel;
namespace projectChurch.Views
{
    public partial class HomePage : ContentPage
    {
        private ObservableCollection<TextEntry> suggestions = new ObservableCollection<TextEntry>();
        public HomePage()
        {
            InitializeComponent(); // ? This goes inside the constructor
            EntriesCollView.ItemsSource = TextData.Entries;
            EntriesCollView.ItemsSource = TextDataCreed.Entries;
            
        }

        

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string input = e.NewTextValue?.Trim();
            suggestions.Clear();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var results = TextData.Entries.Where(entry => entry.Title.Contains(input, StringComparison.OrdinalIgnoreCase)).ToList();

                var resultsC = TextDataCreed.Entries.Where(entry => entry.Title.Contains(input, StringComparison.OrdinalIgnoreCase)).ToList();

                var allResults = results.Concat(resultsC).ToList();
                foreach (var item in allResults)
                {
                    suggestions.Add(item);
                }
            }
           
        }


        private async void OnSearchClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
        


        private async void OnPage2Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }

        private async void OnPage3Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page3));
        }

    }
}
