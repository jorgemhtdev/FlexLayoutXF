namespace FlexLayoutXF
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExamplesView : TabbedPage
    {
        public ExamplesView()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginView());
        }
        private void Button_Form(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormView());
        }

        private void Button_AlignContent(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AlignContentView());
        }
    }
}