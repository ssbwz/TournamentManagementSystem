using DuelSysDesktop.ParentForms.Admin;
using static System.Windows.Forms.Control;

namespace MediaBazaar.Design
{
    internal class DesignClass
    {
        public static void AutoDesginerForForms(ControlCollection controls, Form? form)
        {
            //it is geting the icons from Administration form
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDuelSysAdmin));

            foreach (Control control in controls)
            {
                if (form != null)
                {

                    form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
                    form.MaximizeBox = false;
                    form.MdiChildrenMinimizedAnchorBottom = false;
                    form.MinimizeBox = false;
                    form.ShowInTaskbar = false;
                    form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    form.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

                    if (control is TabControl tabControl)
                    {
                        foreach (Control tabControlChildControl in tabControl.Controls)
                        {
                            if (tabControlChildControl is TabPage tabPage)
                            {

                                tabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
                                tabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

                                foreach (Control control1 in tabPage.Controls)
                                {
                                    if (control1 is Button button)
                                    {
                                        button.Font = new System.Drawing.Font("Segoe UI Semibold", 9, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                                    }
                                }
                            }

                        }
                    }

                }
                else if (control is Button button)
                {
                    button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


                    button.BackColor = System.Drawing.Color.White;
                    button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    button.FlatAppearance.BorderSize = 0;

                }
                else if (control is ListBox listBox)
                {
                    listBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
                else if (control is TextBox textBox)
                {
                    textBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
                else if (control is DataGridView dataGridView)
                {
                    dataGridView.AllowUserToAddRows = false;
                    dataGridView.AllowUserToDeleteRows = false;
                    dataGridView.AllowUserToResizeColumns = false;
                    dataGridView.AllowUserToResizeRows = false;
                    dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView.BorderStyle = BorderStyle.None;
                    dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Semilight", 9, GraphicsUnit.Point);
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#62929E");
                    dataGridView.EnableHeadersVisualStyles = false;

                    dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B6C3CD");
                    dataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#CFD7DE");
                    dataGridView.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#393D3F");
                    dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
                }
            }
        }


        public static void AutoDesginerForUserControl(ControlCollection controls, UserControl? userControl)
        {
            foreach (Control control in controls)
            {
                if (userControl != null)
                {
                    userControl.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
                    userControl.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    userControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
                }


                else if (control is TextBox textBox)
                {
                    textBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = System.Drawing.Color.White;
                    comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    comboBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    comboBox.FormattingEnabled = true;
                }
                else if (control is ListBox listBox)
                {
                    listBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
                else if (control is Button button)
                {
                    button.BackColor = System.Drawing.Color.White;
                    button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    button.FlatAppearance.BorderSize = 0;
                }
                else if (control is DataGridView dataGridView)
                {
                    dataGridView.AllowUserToAddRows = false;
                    dataGridView.AllowUserToDeleteRows = false;
                    dataGridView.AllowUserToResizeColumns = false;
                    dataGridView.AllowUserToResizeRows = false;
                    dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView.BorderStyle = BorderStyle.None;
                    dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Semilight", 9, GraphicsUnit.Point);
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#62929E");
                    dataGridView.EnableHeadersVisualStyles = false;

                    dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#B6C3CD");
                    dataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#CFD7DE");
                    dataGridView.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#393D3F");
                    dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
                }
            }
        }


    }
}
