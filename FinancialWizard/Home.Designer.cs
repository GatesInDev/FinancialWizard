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
            this.GerenciarFinancasButton = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.btnToggleTheme = new MetroFramework.Controls.MetroToggle();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GerenciarFinancasButton
            // 
            this.GerenciarFinancasButton.Image = global::FinancialWizard.Properties.Resources.dolar_da_fatura_do_arquivo;
            this.GerenciarFinancasButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GerenciarFinancasButton.Location = new System.Drawing.Point(25, 5);
            this.GerenciarFinancasButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GerenciarFinancasButton.Name = "GerenciarFinancasButton";
            this.GerenciarFinancasButton.Size = new System.Drawing.Size(231, 136);
            this.GerenciarFinancasButton.TabIndex = 0;
            this.GerenciarFinancasButton.Text = "Manage Finances";
            this.GerenciarFinancasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GerenciarFinancasButton.UseVisualStyleBackColor = true;
            this.GerenciarFinancasButton.Click += new System.EventHandler(this.btnManageFinances_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnToggleTheme);
            this.pnlMenu.Controls.Add(this.GerenciarFinancasButton);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 48);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 672);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenu.Location = new System.Drawing.Point(265, 53);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 50);
            this.btnMenu.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "✖";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnToggleTheme
            // 
            this.btnToggleTheme.AutoSize = true;
            this.btnToggleTheme.DisplayStatus = false;
            this.btnToggleTheme.Location = new System.Drawing.Point(194, 606);
            this.btnToggleTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleTheme.Name = "btnToggleTheme";
            this.btnToggleTheme.Size = new System.Drawing.Size(50, 25);
            this.btnToggleTheme.TabIndex = 1;
            this.btnToggleTheme.Text = "Off";
            this.btnToggleTheme.UseVisualStyleBackColor = true;
            this.btnToggleTheme.Click += new System.EventHandler(this.btnToggleTheme_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pnlMenu);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Movable = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.HomeOnLoad);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GerenciarFinancasButton;
        private System.Windows.Forms.Panel pnlMenu;
        private MetroFramework.Controls.MetroButton btnMenu;
        private MetroFramework.Controls.MetroToggle btnToggleTheme;
    }
}

