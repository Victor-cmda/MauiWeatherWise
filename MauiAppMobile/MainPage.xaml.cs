namespace MauiAppMobile
{
    public partial class MainPage : ContentPage
    {
        WebView webView;

        public MainPage()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
            Shell.SetNavBarIsVisible(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            webView = new WebView();
            Content = webView;


            string url = "https://www.praticaeinovacao.dev.br/victorHugo";
            webView.Source = new UrlWebViewSource { Url = url };
        }
    }
}