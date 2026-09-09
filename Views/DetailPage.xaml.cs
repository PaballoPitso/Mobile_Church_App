using projectChurch.SesFolder;

namespace projectChurch.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(TextEntry entry)
	{
		InitializeComponent();
		BindingContext = entry;
	}
}