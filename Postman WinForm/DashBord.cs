using PostmanLib;

namespace Postman_WinForm
{
    public partial class DashBord : Form
    {
        private IApi_Access _api = new Api_Access();
        public DashBord()
        {
            InitializeComponent();
        }

        private async void CallApi_Click(object sender, EventArgs e)
        {
            SystemStatus.Text = "Calling API...";
            ResultsText.Text="";
            if (_api.IsValidUrl(UrlText.Text) == false)
            {
                SystemStatus.Text = "Invalid URL";
                ResultsText.Text = "Please enter a valid URL.";
                return;
            }
            try
            {
                
             ResultsText.Text= await _api.CallApi(UrlText.Text);
                
                SystemStatus.Text="API Called Successfully";
                

            }
            catch (Exception ex)
            {

                ResultsText.Text = "An Error Happened" + ex;
                SystemStatus.Text = "Error";
            }
        }
    }
}
