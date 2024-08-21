using Demo3WinForm.Services;
using System;
using System.Windows.Forms;

namespace Demo3WinForm
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            var dataService = new LoadDataService();
            ProductDataGrid.DataSource = dataService.LoadProductData();
        }
    }
}
