using projectChurch.SesFolder;

namespace projectChurch.Views;

public partial class PageB : ContentPage
{
    public PageB()
    {
        InitializeComponent();
        EntriesCollView.ItemsSource = TextDataPreface.Entries;
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
    private void themeSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        bool isDark = e.Value;
        if (Application.Current is App app)
        {
            app.SetTheme(isDark);
        }
    }
}
 