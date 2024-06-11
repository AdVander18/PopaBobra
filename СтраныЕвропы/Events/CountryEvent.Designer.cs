namespace СтраныЕвропы.Events
{
    partial class CountryEvent
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
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.страныЕвропыDataSet = new СтраныЕвропы.СтраныЕвропыDataSet();
            this.страныСобытияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.страныСобытияTableAdapter = new СтраныЕвропы.СтраныЕвропыDataSetTableAdapters.СтраныСобытияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.страныЕвропыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныСобытияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(535, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // страныЕвропыDataSet
            // 
            this.страныЕвропыDataSet.DataSetName = "СтраныЕвропыDataSet";
            this.страныЕвропыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // страныСобытияBindingSource
            // 
            this.страныСобытияBindingSource.DataMember = "СтраныСобытия";
            this.страныСобытияBindingSource.DataSource = this.страныЕвропыDataSet;
            // 
            // страныСобытияTableAdapter
            // 
            this.страныСобытияTableAdapter.ClearBeforeFill = true;
            // 
            // CountryEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CountryEvent";
            this.Text = "CountryEvent";
            this.Load += new System.EventHandler(this.CountryEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.страныЕвропыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страныСобытияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private СтраныЕвропыDataSet страныЕвропыDataSet;
        private System.Windows.Forms.BindingSource страныСобытияBindingSource;
        private СтраныЕвропыDataSetTableAdapters.СтраныСобытияTableAdapter страныСобытияTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}