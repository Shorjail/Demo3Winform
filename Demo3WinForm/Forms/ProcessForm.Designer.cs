﻿namespace Demo3WinForm.Forms
{
    partial class ProcessForm
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
            this.ProcessDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessDataGrid
            // 
            this.ProcessDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProcessDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessDataGrid.GridColor = System.Drawing.Color.White;
            this.ProcessDataGrid.Location = new System.Drawing.Point(16, 50);
            this.ProcessDataGrid.Name = "ProcessDataGrid";
            this.ProcessDataGrid.RowHeadersWidth = 51;
            this.ProcessDataGrid.RowTemplate.Height = 24;
            this.ProcessDataGrid.Size = new System.Drawing.Size(783, 388);
            this.ProcessDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processes";
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProcessDataGrid;
        private System.Windows.Forms.Label label1;
    }
}