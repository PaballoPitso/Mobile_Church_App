 using projectChurch.Views;

namespace projectChurch
   
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

     
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
            Routing.RegisterRoute(nameof(Page3), typeof(Page3));
        }
    }
}
