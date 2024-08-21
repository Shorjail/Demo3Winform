using Demo3WinForm.Services;
using System;
using System.Windows.Forms;

namespace Demo3WinForm.Forms
{
    public partial class ProcessRouteForm : Form
    {
        public ProcessRouteForm()
        {
            InitializeComponent();
        }

        private void ProcessRouteForm_Load(object sender, EventArgs e)
        {
            var dataService = new LoadDataService();
            RouteDataGrid.DataSource = dataService.LoadProcessRouteData();
        }
    }
}
