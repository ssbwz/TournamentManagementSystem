using MediaBazaar.Design;

namespace DuelSysDesktop.UserControlsEmployeesManagement
{
    partial class UCViewEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DGVViewEmployess = new System.Windows.Forms.DataGridView();
            this.NUDPages = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewEmployess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // DGVViewEmployess
            // 
            this.DGVViewEmployess.AllowUserToAddRows = false;
            this.DGVViewEmployess.AllowUserToDeleteRows = false;
            this.DGVViewEmployess.AllowUserToResizeColumns = false;
            this.DGVViewEmployess.AllowUserToResizeRows = false;
            this.DGVViewEmployess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVViewEmployess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVViewEmployess.ColumnHeadersHeight = 29;
            this.DGVViewEmployess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVViewEmployess.Location = new System.Drawing.Point(13, 64);
            this.DGVViewEmployess.MultiSelect = false;
            this.DGVViewEmployess.Name = "DGVViewEmployess";
            this.DGVViewEmployess.ReadOnly = true;
            this.DGVViewEmployess.RowHeadersVisible = false;
            this.DGVViewEmployess.RowHeadersWidth = 51;
            this.DGVViewEmployess.RowTemplate.Height = 29;
            this.DGVViewEmployess.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVViewEmployess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVViewEmployess.Size = new System.Drawing.Size(857, 221);
            this.DGVViewEmployess.TabIndex = 13;
            this.DGVViewEmployess.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViewEmployess_CellDoubleClick);
            // 
            // NUDPages
            // 
            this.NUDPages.Location = new System.Drawing.Point(404, 347);
            this.NUDPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.Name = "NUDPages";
            this.NUDPages.Size = new System.Drawing.Size(69, 27);
            this.NUDPages.TabIndex = 14;
            this.NUDPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.ValueChanged += new System.EventHandler(this.NUDPages_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Page number : ";
            // 
            // UCViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDPages);
            this.Controls.Add(this.DGVViewEmployess);
            this.Controls.Add(this.label1);
            this.Name = "UCViewEmployees";
            this.Size = new System.Drawing.Size(876, 393);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewEmployess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            DesignClass.AutoDesginerForUserControl(this.Controls, this);
        }

        #endregion
        private Label label1;
        private DataGridView DGVViewEmployess;
        private NumericUpDown NUDPages;
        private Label label2;
    }
}
