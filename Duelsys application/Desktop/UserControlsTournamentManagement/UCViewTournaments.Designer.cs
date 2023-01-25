using MediaBazaar.Design;

namespace DuelSysDesktop.UserControlsTournamentManagement
{
    partial class UCViewTournaments
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
            this.label2 = new System.Windows.Forms.Label();
            this.NUDPages = new System.Windows.Forms.NumericUpDown();
            this.DGVViewTournaments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(384, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Page number : ";
            // 
            // NUDPages
            // 
            this.NUDPages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUDPages.Location = new System.Drawing.Point(565, 361);
            this.NUDPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.Name = "NUDPages";
            this.NUDPages.Size = new System.Drawing.Size(76, 39);
            this.NUDPages.TabIndex = 19;
            this.NUDPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.ValueChanged += new System.EventHandler(this.NUDPages_ValueChanged);
            // 
            // DGVViewTournaments
            // 
            this.DGVViewTournaments.AllowUserToAddRows = false;
            this.DGVViewTournaments.AllowUserToDeleteRows = false;
            this.DGVViewTournaments.AllowUserToResizeColumns = false;
            this.DGVViewTournaments.AllowUserToResizeRows = false;
            this.DGVViewTournaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVViewTournaments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVViewTournaments.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVViewTournaments.ColumnHeadersHeight = 29;
            this.DGVViewTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVViewTournaments.Location = new System.Drawing.Point(3, 120);
            this.DGVViewTournaments.MultiSelect = false;
            this.DGVViewTournaments.Name = "DGVViewTournaments";
            this.DGVViewTournaments.ReadOnly = true;
            this.DGVViewTournaments.RowHeadersVisible = false;
            this.DGVViewTournaments.RowHeadersWidth = 51;
            this.DGVViewTournaments.RowTemplate.Height = 29;
            this.DGVViewTournaments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVViewTournaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVViewTournaments.Size = new System.Drawing.Size(1221, 221);
            this.DGVViewTournaments.TabIndex = 18;
            this.DGVViewTournaments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViewTournaments_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tournaments";
            // 
            // UCViewTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDPages);
            this.Controls.Add(this.DGVViewTournaments);
            this.Name = "UCViewTournaments";
            this.Size = new System.Drawing.Size(1230, 451);
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private NumericUpDown NUDPages;
        private DataGridView DGVViewTournaments;
        private Label label1;
    }
}
