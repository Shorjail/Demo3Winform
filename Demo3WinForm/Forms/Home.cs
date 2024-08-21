using Demo3WinForm.Services;
using System;

using System.Windows.Forms;

namespace Demo3WinForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var dataService = new LoadDataService();
            HomeDataGrid.DataSource = dataService.LoadHomeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                var searchService = new SearchService();
                var result = searchService.Search(SearchTextBox.Text);
                if(result != null)
                {
                    HomeDataGrid.DataSource = searchService.Search(SearchTextBox.Text);
                }
                else
                {
                    MessageBox.Show("No Results found");
                    HomeDataGrid.DataSource = null;
                }
                
            }
            else
            {
                MessageBox.Show("Enter Search parameters");
            }
          
        }
    }
}
