
namespace ShoppingList
{
    partial class ShoppingListForm
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
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.bttn_Find = new System.Windows.Forms.Button();
            this.bttn_ShowCurrentData = new System.Windows.Forms.Button();
            this.bttn_ImportFile = new System.Windows.Forms.Button();
            this.bttn_ExportData = new System.Windows.Forms.Button();
            this.bttn_ShowResult = new System.Windows.Forms.Button();
            this.bttn_AddRow = new System.Windows.Forms.Button();
            this.bttn_DeleteRow = new System.Windows.Forms.Button();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.txtBx_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.Size = new System.Drawing.Size(1060, 387);
            this.dtGrdVw.TabIndex = 0;
            this.dtGrdVw.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVw_CellValueChanged);
            // 
            // bttn_Find
            // 
            this.bttn_Find.Location = new System.Drawing.Point(549, 421);
            this.bttn_Find.Name = "bttn_Find";
            this.bttn_Find.Size = new System.Drawing.Size(172, 86);
            this.bttn_Find.TabIndex = 2;
            this.bttn_Find.Text = "Find";
            this.bttn_Find.UseVisualStyleBackColor = true;
            this.bttn_Find.Click += new System.EventHandler(this.bttn_Find_Click);
            // 
            // bttn_ShowCurrentData
            // 
            this.bttn_ShowCurrentData.Location = new System.Drawing.Point(15, 421);
            this.bttn_ShowCurrentData.Name = "bttn_ShowCurrentData";
            this.bttn_ShowCurrentData.Size = new System.Drawing.Size(172, 86);
            this.bttn_ShowCurrentData.TabIndex = 3;
            this.bttn_ShowCurrentData.Text = "Show Current Data";
            this.bttn_ShowCurrentData.UseVisualStyleBackColor = true;
            this.bttn_ShowCurrentData.Click += new System.EventHandler(this.bttn_ShowCurrentData_Click);
            // 
            // bttn_ImportFile
            // 
            this.bttn_ImportFile.Location = new System.Drawing.Point(193, 421);
            this.bttn_ImportFile.Name = "bttn_ImportFile";
            this.bttn_ImportFile.Size = new System.Drawing.Size(172, 86);
            this.bttn_ImportFile.TabIndex = 5;
            this.bttn_ImportFile.Text = "Import From File";
            this.bttn_ImportFile.UseVisualStyleBackColor = true;
            this.bttn_ImportFile.Click += new System.EventHandler(this.bttn_ImportFile_Click);
            // 
            // bttn_ExportData
            // 
            this.bttn_ExportData.Location = new System.Drawing.Point(193, 513);
            this.bttn_ExportData.Name = "bttn_ExportData";
            this.bttn_ExportData.Size = new System.Drawing.Size(172, 86);
            this.bttn_ExportData.TabIndex = 6;
            this.bttn_ExportData.Text = "Export From Database";
            this.bttn_ExportData.UseVisualStyleBackColor = true;
            this.bttn_ExportData.Click += new System.EventHandler(this.bttn_ExportData_Click);
            // 
            // bttn_ShowResult
            // 
            this.bttn_ShowResult.Location = new System.Drawing.Point(15, 513);
            this.bttn_ShowResult.Name = "bttn_ShowResult";
            this.bttn_ShowResult.Size = new System.Drawing.Size(172, 86);
            this.bttn_ShowResult.TabIndex = 7;
            this.bttn_ShowResult.Text = "Show resulrt of your shopping";
            this.bttn_ShowResult.UseVisualStyleBackColor = true;
            this.bttn_ShowResult.Click += new System.EventHandler(this.bttn_ShowResult_Click);
            // 
            // bttn_AddRow
            // 
            this.bttn_AddRow.Location = new System.Drawing.Point(371, 421);
            this.bttn_AddRow.Name = "bttn_AddRow";
            this.bttn_AddRow.Size = new System.Drawing.Size(172, 86);
            this.bttn_AddRow.TabIndex = 8;
            this.bttn_AddRow.Text = "Add Row";
            this.bttn_AddRow.UseVisualStyleBackColor = true;
            this.bttn_AddRow.Click += new System.EventHandler(this.bttn_AddRow_Click);
            // 
            // bttn_DeleteRow
            // 
            this.bttn_DeleteRow.Location = new System.Drawing.Point(371, 513);
            this.bttn_DeleteRow.Name = "bttn_DeleteRow";
            this.bttn_DeleteRow.Size = new System.Drawing.Size(172, 86);
            this.bttn_DeleteRow.TabIndex = 9;
            this.bttn_DeleteRow.Text = "Delete Row";
            this.bttn_DeleteRow.UseVisualStyleBackColor = true;
            this.bttn_DeleteRow.Click += new System.EventHandler(this.bttn_DeleteRow_Click);
            // 
            // bttn_Close
            // 
            this.bttn_Close.Location = new System.Drawing.Point(549, 513);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(172, 86);
            this.bttn_Close.TabIndex = 10;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // txtBx_Search
            // 
            this.txtBx_Search.Location = new System.Drawing.Point(15, 631);
            this.txtBx_Search.Name = "txtBx_Search";
            this.txtBx_Search.Size = new System.Drawing.Size(272, 20);
            this.txtBx_Search.TabIndex = 11;
            this.txtBx_Search.Text = "Search";
            // 
            // ShoppingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 851);
            this.Controls.Add(this.txtBx_Search);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.bttn_DeleteRow);
            this.Controls.Add(this.bttn_AddRow);
            this.Controls.Add(this.bttn_ShowResult);
            this.Controls.Add(this.bttn_ExportData);
            this.Controls.Add(this.bttn_ImportFile);
            this.Controls.Add(this.bttn_ShowCurrentData);
            this.Controls.Add(this.bttn_Find);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "ShoppingListForm";
            this.Text = "Shopping List ";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.Button bttn_Find;
        private System.Windows.Forms.Button bttn_ShowCurrentData;
        private System.Windows.Forms.Button bttn_ImportFile;
        private System.Windows.Forms.Button bttn_ExportData;
        private System.Windows.Forms.Button bttn_ShowResult;
        private System.Windows.Forms.Button bttn_AddRow;
        private System.Windows.Forms.Button bttn_DeleteRow;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.TextBox txtBx_Search;
    }
}

