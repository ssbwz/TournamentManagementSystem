using DuelSysDesktop.UserControlsEmployeesManagement;
using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.Admin
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.ucViewEmployees = new DuelSysDesktop.UserControlsEmployeesManagement.UCViewEmployees();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.ucCreateEmployee = new DuelSysDesktop.UserControlsEmployeesManagement.UCCreateEmployee();
            this.ucUpdateEmployee = new DuelSysDesktop.UserControlsEmployeesManagement.UCUpdateEmployee();
            this.SuspendLayout();
            // 
            // ucViewEmployees
            // 
            this.ucViewEmployees.Location = new System.Drawing.Point(-2, -5);
            this.ucViewEmployees.Name = "ucViewEmployees";
            this.ucViewEmployees.Size = new System.Drawing.Size(876, 387);
            this.ucViewEmployees.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(344, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(497, 442);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 44);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ucCreateEmployee
            // 
            this.ucCreateEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateEmployee.Location = new System.Drawing.Point(0, 0);
            this.ucCreateEmployee.Name = "ucCreateEmployee";
            this.ucCreateEmployee.Size = new System.Drawing.Size(872, 498);
            this.ucCreateEmployee.TabIndex = 4;
            this.ucCreateEmployee.Visible = false;
            // 
            // ucUpdateEmployee
            // 
            this.ucUpdateEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUpdateEmployee.Location = new System.Drawing.Point(0, 0);
            this.ucUpdateEmployee.Name = "ucUpdateEmployee";
            this.ucUpdateEmployee.Size = new System.Drawing.Size(872, 498);
            this.ucUpdateEmployee.TabIndex = 5;
            this.ucUpdateEmployee.Visible = false;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.ucUpdateEmployee);
            this.Controls.Add(this.ucCreateEmployee);
            this.Controls.Add(this.ucViewEmployees);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DuelSys inc.";
            this.ResumeLayout(false);
            DesignClass.AutoDesginerForForms(this.Controls, this);
        }

        #endregion

        private UCViewEmployees ucViewEmployees;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private UCCreateEmployee ucCreateEmployee;
        private UCUpdateEmployee ucUpdateEmployee;
    }
}