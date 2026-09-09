using FutureState.AppCore.Data;
using projectChurch.SesFolder;

namespace projectChurch
{
    public partial class App : Application
    {
        public static DataServ Database { get; private set; }
        public App()
        {
            InitializeComponent();
            CopyDatabaseIfNeededAsync(); // Start database setup
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "entries.db3");
            Database = new DataServ(dbPath);

            SetTheme(false);

        
        }

        private async Task CopyDatabaseIfNeededAsync()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "TextData.db");

            if (!File.Exists(dbPath))
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("TextData.db");
                using var newStream = File.Create(dbPath);
                await stream.CopyToAsync(newStream);
            }
        }

        public void SetTheme(bool isDark)
        {
            var resources = Current.Resources;

            if (resources.TryGetValue("LightGreen", out var _) &&
                resources.TryGetValue("White", out var _) &&
                resources.TryGetValue("Black", out var _) &&
                resources.TryGetValue("LightGray", out var _) &&
                resources.TryGetValue("LightGoldenrodYellow", out var _) &&
                resources.TryGetValue("HeadingWhite", out var _) &&
                resources.TryGetValue("Accent", out var _))
                {
                resources["LightGreen"] = isDark
                    ? resources["LightGreen_Dark"]
                    : resources["LightGreen_Light"];
                resources["White"] = isDark
                    ? resources["White_Dark"]
                    : resources["White_Light"];
                resources["Black"] = isDark
                    ? resources["Black_Dark"]
                    : resources["Black_Light"];
                resources["LightGray"] = isDark
                    ? resources["LightGray_Dark"]
                    : resources["LightGray_Light"];
                resources["LightGoldenrodYellow"] = isDark
                    ? resources["LightGoldenrodYellow_Dark"]
                    : resources["LightGoldenrodYellow_Light"];
                resources["Accent"] = isDark
                    ? resources["Accent_Dark"]
                    : resources["Accent_Light"];
                resources["HeadingWhite"] = isDark
                    ? resources["HeadingWhite_Dark"]
                    : resources["HeadingWhite_Light"];
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}