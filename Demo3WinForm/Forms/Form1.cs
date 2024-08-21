using Demo3WinForm.Forms;
using Demo3WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomeContent();
        }
        private void ShowHomeContent()
        {
            var homeForm = new Home();
            homeForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void btnAddMockData_Click(object sender, EventArgs e)
        {
            var mockData = new MockDataService();
            MessageBox.Show(mockData.AddMockData());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowHomeContent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.TopLevel = false;   
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(productForm);
            productForm.Show();
        }

        private void btnProcesses_Click(object sender, EventArgs e)
        {
            var processForm = new ProcessForm();
            processForm.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(processForm);
            processForm.Show();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            var routeFrom = new ProcessRouteForm();
            routeFrom.TopLevel = false;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(routeFrom);
            routeFrom.Show();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Select a file to import";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show("Selected file: " + filePath);

                    var importService = new ImportService();
                    var extension = Path.GetExtension(filePath).ToLower();
                    var importedData = new List<Models.ProcessParameters>();
                    if( extension == ".xls" || extension == ".xlsx")
                    {
                        importedData = importService.ParseExcelFile(filePath);
                    }
                    else if(extension == ".csv")
                    {
                        importedData = importService.ParseCsvFile(filePath);

                    }
                    else
                    {
                        MessageBox.Show("wrong file");
                        return;
                    }
                    var isDataSaved = importService.SaveToData(importedData);
                    if(isDataSaved) {

                        MessageBox.Show("Data Successfuly saved");
                    }
                    else
                    {
                        MessageBox.Show("An error occured while saving data");
                    }
                    ShowHomeContent();
                }
            }
        }
    }
}
