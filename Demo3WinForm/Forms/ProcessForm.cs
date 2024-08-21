using Demo3WinForm.Services;
using System;
using System.Windows.Forms;

namespace Demo3WinForm.Forms
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            var dataService = new LoadDataService();
            ProcessDataGrid.DataSource = dataService.LoadProcessData();

            

        }
    }
}
