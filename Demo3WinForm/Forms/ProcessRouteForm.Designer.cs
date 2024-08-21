namespace Demo3WinForm.Forms
{
    partial class ProcessRouteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RouteDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Routes";
            // 
            // RouteDataGrid
            // 
            this.RouteDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RouteDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RouteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteDataGrid.Location = new System.Drawing.Point(15, 51);
            this.RouteDataGrid.Name = "RouteDataGrid";
            this.RouteDataGrid.RowHeadersWidth = 51;
            this.RouteDataGrid.RowTemplate.Height = 24;
            this.RouteDataGrid.Size = new System.Drawing.Size(755, 333);
            this.RouteDataGrid.TabIndex = 1;
            // 
            // ProcessRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RouteDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessRouteForm";
            this.Text = "ProcessRouteForm";
            this.Load += new System.EventHandler(this.ProcessRouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RouteDataGrid;
    }
}