using System;


using Xamarin.Forms;

namespace SNUData2.Views
{
    public partial class NewItemPage : ContentPage
    {
       
        public WebView _WebView { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

           

            BindingContext = this;
            _WebView = Data_webView;
            _WebView.Source = "https://myaccount.snu.edu.in/login.php";
            _WebView.IsVisible = true;
            
            
        }

       

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void StartDate_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void EndDate_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string _StartDate = StartDate.Date.ToString("yyyy-MM-dd");
            string _EndDate = EndDate.Date.ToString("yyyy-MM-dd");
            string evaluate = "document.getElementById('startDate').value = '"+ _StartDate + "'";
            _WebView.Eval(evaluate);
            string evaluate2 = "document.getElementById('endDate').value = '" + _EndDate + "'";
            _WebView.Eval(evaluate2);
            string submit = "document.frmUsageDtls.submit.click()";
            _WebView.Eval(submit);


        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            string user = "Enter your user name";
            string password = "Enter Your Password";
            string evaluate = "document.getElementById('snuNetId').value = '" + user + "'";
            _WebView.Eval(evaluate);
            string evaluate2 = "document.getElementById('password').value = '" + password + "'";
            _WebView.Eval(evaluate2);
            string login = "document.frmUserLogin.submit.click()";
            _WebView.Eval(login);
        }

       
    }
}