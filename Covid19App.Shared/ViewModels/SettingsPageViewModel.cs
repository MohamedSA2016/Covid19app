using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Covid19App.Shared.ViewModels
{
    public class SettingsPageViewModel : BaseViewModel
    {
        public SettingsPageViewModel(INavigation navigation)
        {
            Title = "Settings";
            Navigation = navigation;
        }

        public ICommand GithubCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var url = "https://github.com/MohamedSA2016";
                    await Browser.OpenAsync(url, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show
                    });
                });
            }
        }

        public ICommand LinkedInCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var url = "https://www.linkedin.com/in/mohamed-sayed-0922599b/";
                    await Browser.OpenAsync(url, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show
                    });
                });
            }
        }

        public ICommand TwitterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var url = "https://twitter.com/gifted_byte";
                    await Browser.OpenAsync(url, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show
                    });
                });
            }
        }
    }
}