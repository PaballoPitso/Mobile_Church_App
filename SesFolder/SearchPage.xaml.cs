using System.Collections.ObjectModel;

namespace projectChurch.SesFolder;

public partial class SearchPage : ContentPage
{
    public static readonly BindableProperty IsLoadingProperty =
            BindableProperty.Create(nameof(IsLoading), typeof(bool), typeof(SearchPage), false);

    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    ObservableCollection<TextEntry> allData = new();

    public SearchPage()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        // Combine TextData + TextDataCreed without loading on main page
        foreach (var item in TextData.Entries)
            allData.Add(item);

        foreach (var item in TextDataCreed.Entries)
            allData.Add(item);
    }

    private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        string text = e.NewTextValue?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(text))
        {
            SearchResults.ItemsSource = null;
            return;
        }

        IsLoading = true;

        await Task.Delay(200); // tiny delay for smooth UI

        var filtered = allData
            .Where(x => x.Title.Contains(text, StringComparison.OrdinalIgnoreCase))
            .ToList();

        SearchResults.ItemsSource = filtered;

        IsLoading = false;
    }

    private async void SearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is TextEntry selected)
        {
            await Navigation.PushAsync(new displayPage(selected.Title, selected.Content));
        }

        // remove highlight
        SearchResults.SelectedItem = null;
    }
}
