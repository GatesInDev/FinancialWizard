namespace FinancialWizard
{
    partial class Home
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GerenciarFinancasButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GerenciarFinancasButton);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 260);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GerenciarFinancasButton
            // 
            this.GerenciarFinancasButton.Image = global::FinancialWizard.Properties.Resources.dolar_da_fatura_do_arquivo;
            this.GerenciarFinancasButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GerenciarFinancasButton.Location = new System.Drawing.Point(3, 3);
            this.GerenciarFinancasButton.Name = "GerenciarFinancasButton";
            this.GerenciarFinancasButton.Size = new System.Drawing.Size(115, 84);
            this.GerenciarFinancasButton.TabIndex = 0;
            this.GerenciarFinancasButton.Text = "Manage Finances";
            this.GerenciarFinancasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GerenciarFinancasButton.UseVisualStyleBackColor = true;
            this.GerenciarFinancasButton.Click += new System.EventHandler(this.btnManageFinances_Click);
            // 
            // button5
            // 
            this.button5.Image = global::FinancialWizard.Properties.Resources.download_de_pasta;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(124, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 84);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gerenciar Finanças";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FinancialWizard.Properties.Resources.download_de_pasta;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(245, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exportar Planilhas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Financial Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GerenciarFinancasButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}

