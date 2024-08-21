namespace Demo3WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcesses = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnAddMockData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnProcesses);
            this.groupBox1.Controls.Add(this.btnRoutes);
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnProcesses
            // 
            this.btnProcesses.BackColor = System.Drawing.Color.White;
            this.btnProcesses.Location = new System.Drawing.Point(6, 194);
            this.btnProcesses.Name = "btnProcesses";
            this.btnProcesses.Size = new System.Drawing.Size(152, 48);
            this.btnProcesses.TabIndex = 3;
            this.btnProcesses.Text = "Processes";
            this.btnProcesses.UseVisualStyleBackColor = false;
            this.btnProcesses.Click += new System.EventHandler(this.btnProcesses_Click);
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.White;
            this.btnRoutes.Location = new System.Drawing.Point(6, 140);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(152, 48);
            this.btnRoutes.TabIndex = 2;
            this.btnRoutes.Text = "Routes";
            this.btnRoutes.UseVisualStyleBackColor = false;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(6, 86);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(152, 48);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(6, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(152, 48);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Process Parameters (Home)";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(192, 21);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1113, 459);
            this.MainPanel.TabIndex = 1;
            // 
            // btnAddMockData
            // 
            this.btnAddMockData.Location = new System.Drawing.Point(12, 378);
            this.btnAddMockData.Name = "btnAddMockData";
            this.btnAddMockData.Size = new System.Drawing.Size(164, 90);
            this.btnAddMockData.TabIndex = 2;
            this.btnAddMockData.Text = "Add Mock Data";
            this.btnAddMockData.UseVisualStyleBackColor = true;
            this.btnAddMockData.Click += new System.EventHandler(this.btnAddMockData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(12, 282);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(164, 90);
            this.btnImportData.TabIndex = 3;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 492);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.btnAddMockData);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcesses;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnAddMockData;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

