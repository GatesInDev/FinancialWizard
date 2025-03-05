namespace FinancialWizard
{
    partial class ManageFinancesForm
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnExpense = new System.Windows.Forms.RadioButton();
            this.dgvFinances = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 351);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(269, 351);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.AutoSize = true;
            this.rbtnIncome.Location = new System.Drawing.Point(437, 354);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(60, 17);
            this.rbtnIncome.TabIndex = 3;
            this.rbtnIncome.TabStop = true;
            this.rbtnIncome.Text = "Income";
            this.rbtnIncome.UseVisualStyleBackColor = true;
            this.rbtnIncome.CheckedChanged += new System.EventHandler(this.rbtnIncome_CheckedChanged);
            // 
            // rbtnExpense
            // 
            this.rbtnExpense.AutoSize = true;
            this.rbtnExpense.Location = new System.Drawing.Point(437, 378);
            this.rbtnExpense.Name = "rbtnExpense";
            this.rbtnExpense.Size = new System.Drawing.Size(66, 17);
            this.rbtnExpense.TabIndex = 4;
            this.rbtnExpense.TabStop = true;
            this.rbtnExpense.Text = "Expense";
            this.rbtnExpense.UseVisualStyleBackColor = true;
            // 
            // dgvFinances
            // 
            this.dgvFinances.AllowUserToAddRows = false;
            this.dgvFinances.AllowUserToDeleteRows = false;
            this.dgvFinances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinances.Location = new System.Drawing.Point(22, 12);
            this.dgvFinances.Name = "dgvFinances";
            this.dgvFinances.ReadOnly = true;
            this.dgvFinances.Size = new System.Drawing.Size(753, 243);
            this.dgvFinances.TabIndex = 5;
            this.dgvFinances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManageFinancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFinances);
            this.Controls.Add(this.rbtnExpense);
            this.Controls.Add(this.rbtnIncome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtDescription);
            this.Name = "ManageFinancesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Finances";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageFinancesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.RadioButton rbtnExpense;
        private System.Windows.Forms.DataGridView dgvFinances;
    }
}