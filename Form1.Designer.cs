namespace A2_Binod_Shrestha
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHrlWage = new System.Windows.Forms.Label();
            this.lblHrsWorked = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.ckBoxManager = new System.Windows.Forms.CheckBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNetEarnings = new System.Windows.Forms.TextBox();
            this.lblGEarnings = new System.Windows.Forms.Label();
            this.txtFWT = new System.Windows.Forms.TextBox();
            this.lblFWT = new System.Windows.Forms.Label();
            this.txtGrossEarnings = new System.Windows.Forms.TextBox();
            this.lblNEarnings = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblHrlWage
            // 
            this.lblHrlWage.AutoSize = true;
            this.lblHrlWage.Location = new System.Drawing.Point(7, 61);
            this.lblHrlWage.Name = "lblHrlWage";
            this.lblHrlWage.Size = new System.Drawing.Size(94, 17);
            this.lblHrlWage.TabIndex = 2;
            this.lblHrlWage.Text = "Hourly Wage:";
            // 
            // lblHrsWorked
            // 
            this.lblHrsWorked.AutoSize = true;
            this.lblHrsWorked.Location = new System.Drawing.Point(7, 92);
            this.lblHrsWorked.Name = "lblHrsWorked";
            this.lblHrsWorked.Size = new System.Drawing.Size(103, 17);
            this.lblHrsWorked.TabIndex = 3;
            this.lblHrsWorked.Text = "Hours Worked:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(108, 57);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(267, 23);
            this.txtWage.TabIndex = 2;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(108, 90);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(267, 23);
            this.txtHours.TabIndex = 3;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.ckBoxManager);
            this.grpBox1.Controls.Add(this.txtHours);
            this.grpBox1.Controls.Add(this.lblName);
            this.grpBox1.Controls.Add(this.txtWage);
            this.grpBox1.Controls.Add(this.lblHrlWage);
            this.grpBox1.Controls.Add(this.txtName);
            this.grpBox1.Controls.Add(this.lblManager);
            this.grpBox1.Controls.Add(this.lblHrsWorked);
            this.grpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(12, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(379, 148);
            this.grpBox1.TabIndex = 1;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Please enter the employee information:";
            // 
            // ckBoxManager
            // 
            this.ckBoxManager.AutoSize = true;
            this.ckBoxManager.Location = new System.Drawing.Point(108, 124);
            this.ckBoxManager.Name = "ckBoxManager";
            this.ckBoxManager.Size = new System.Drawing.Size(15, 14);
            this.ckBoxManager.TabIndex = 4;
            this.ckBoxManager.UseVisualStyleBackColor = true;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(8, 120);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(64, 17);
            this.lblManager.TabIndex = 3;
            this.lblManager.Text = "Manager";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 27);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetEarnings);
            this.groupBox1.Controls.Add(this.lblGEarnings);
            this.groupBox1.Controls.Add(this.txtFWT);
            this.groupBox1.Controls.Add(this.lblFWT);
            this.groupBox1.Controls.Add(this.txtGrossEarnings);
            this.groupBox1.Controls.Add(this.lblNEarnings);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculated Wage";
            // 
            // txtNetEarnings
            // 
            this.txtNetEarnings.Location = new System.Drawing.Point(120, 90);
            this.txtNetEarnings.Name = "txtNetEarnings";
            this.txtNetEarnings.ReadOnly = true;
            this.txtNetEarnings.Size = new System.Drawing.Size(255, 23);
            this.txtNetEarnings.TabIndex = 9;
            // 
            // lblGEarnings
            // 
            this.lblGEarnings.AutoSize = true;
            this.lblGEarnings.Location = new System.Drawing.Point(4, 27);
            this.lblGEarnings.Name = "lblGEarnings";
            this.lblGEarnings.Size = new System.Drawing.Size(110, 17);
            this.lblGEarnings.TabIndex = 1;
            this.lblGEarnings.Text = "Gross Earnings:";
            // 
            // txtFWT
            // 
            this.txtFWT.Location = new System.Drawing.Point(120, 57);
            this.txtFWT.Name = "txtFWT";
            this.txtFWT.ReadOnly = true;
            this.txtFWT.Size = new System.Drawing.Size(255, 23);
            this.txtFWT.TabIndex = 8;
            // 
            // lblFWT
            // 
            this.lblFWT.AutoSize = true;
            this.lblFWT.Location = new System.Drawing.Point(7, 60);
            this.lblFWT.Name = "lblFWT";
            this.lblFWT.Size = new System.Drawing.Size(76, 17);
            this.lblFWT.TabIndex = 2;
            this.lblFWT.Text = "Less FWT:";
            // 
            // txtGrossEarnings
            // 
            this.txtGrossEarnings.Location = new System.Drawing.Point(120, 24);
            this.txtGrossEarnings.Name = "txtGrossEarnings";
            this.txtGrossEarnings.ReadOnly = true;
            this.txtGrossEarnings.Size = new System.Drawing.Size(255, 23);
            this.txtGrossEarnings.TabIndex = 7;
            // 
            // lblNEarnings
            // 
            this.lblNEarnings.AutoSize = true;
            this.lblNEarnings.Location = new System.Drawing.Point(7, 95);
            this.lblNEarnings.Name = "lblNEarnings";
            this.lblNEarnings.Size = new System.Drawing.Size(94, 17);
            this.lblNEarnings.TabIndex = 3;
            this.lblNEarnings.Text = "Net Earnings:";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(19, 340);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(77, 17);
            this.lblEmployees.TabIndex = 7;
            this.lblEmployees.Text = "Employees";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(132, 337);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(252, 21);
            this.cmbEmployees.TabIndex = 10;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(308, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 429);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculater";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHrlWage;
        private System.Windows.Forms.Label lblHrsWorked;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.CheckBox ckBoxManager;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNetEarnings;
        private System.Windows.Forms.Label lblGEarnings;
        private System.Windows.Forms.TextBox txtFWT;
        private System.Windows.Forms.Label lblFWT;
        private System.Windows.Forms.TextBox txtGrossEarnings;
        private System.Windows.Forms.Label lblNEarnings;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Button btnClose;
    }
}

