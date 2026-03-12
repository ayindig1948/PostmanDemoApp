using PostmanLib;
using HttpAction = PostmanLib.HttpAction;

namespace Postman_WinForm
{
    public partial class DashBord : Form
    {
        private IApi_Access _api = new Api_Access();
        public DashBord()
        {
            InitializeComponent();
            MethodNav.SelectedItem = "GET";
        }

        private async void CallApi_Click(object sender, EventArgs e)
        {
            SystemStatus.Text = "Calling API...";
            ResultsText.Text="";
            if (_api.IsValidUrl(UrlText.Text) == false)
            {
                SystemStatus.Text = "Invalid URL";
                ResultsText.Text = "Please enter a valid URL.";
             
            }
            HttpAction method;
            if (Enum.TryParse(MethodNav.SelectedItem!.ToString(), out method) == false)
            {
                SystemStatus.Text = "Invalid HTTP Method";
                ResultsText.Text = "Please select a valid HTTP method.";
                return;
            }
            try
            {
                
             ResultsText.Text= await _api.CallApi(UrlText.Text,BodyText.Text,true,method);
                
                SystemStatus.Text="API Called Successfully";
                CallData.SelectedTab = tabResults;
                tabResults.Focus();
                return;


            }
            catch (Exception ex)
            {

                ResultsText.Text = "An Error Happened" + ex;
                SystemStatus.Text = "Error";
                CallData.SelectedTab = tabResults;
                return;
            }
        }
    }
}
