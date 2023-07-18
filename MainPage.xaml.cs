namespace Maui_IssueLabel2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtTest_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTest.Text = txtTest.Text;
        }
    }
}