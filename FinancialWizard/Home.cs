using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;

namespace FinancialWizard
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        private bool menuExpandido = true;
        public Home()
        {
            InitializeComponent();
            this.Theme = MetroThemeStyle.Dark;
            this.Style = MetroColorStyle.Blue;
        }

        public static bool IsWindowsInDarkMode()
        {
            var registryKey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", 1);
            return registryKey != null && (int)registryKey == 0;
        }

        private void btnManageFinances_Click(object sender, EventArgs e)
        {
            ManageFinancesForm managefinancesform = new ManageFinancesForm();
            managefinancesform.Show();
            managefinancesform.LoadFinances();
            this.Hide();
        }

        private async void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                await EsconderMenu();
            }
            else
            {
                await MostrarMenu();
            }

            if (menuExpandido)
            {
                btnMenu.Text = "☰"; // Ícone de menu fechado
                await EsconderMenu();
            }
            else
            {
                btnMenu.Text = "✖"; // Ícone de menu aberto
                await MostrarMenu();
            }
            menuExpandido = !menuExpandido;
        }

        private async Task EsconderMenu()
        {
            for (int i = pnlMenu.Width; i > 0; i -= 10)
            {
                pnlMenu.Width = i;
                btnMenu.Left = pnlMenu.Width + 5;
                await Task.Delay(5); // Pequena pausa para suavizar a animação
            }
        }

        private async Task MostrarMenu()
        {
            for (int i = pnlMenu.Width; i < 260; i += 10)
            {
                pnlMenu.Width = i;
                btnMenu.Left = pnlMenu.Width + 5;
                await Task.Delay(5);
            }
        }

        private void HomeOnLoad(object sender, EventArgs e)
        {
            MetroFramework.MetroThemeStyle theme = IsWindowsInDarkMode()
        ? MetroFramework.MetroThemeStyle.Dark
        : MetroFramework.MetroThemeStyle.Light;

            ApplyThemeToControls(theme);
        }
        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroThemeStyle newTheme = this.Theme == MetroFramework.MetroThemeStyle.Dark
        ? MetroFramework.MetroThemeStyle.Light
        : MetroFramework.MetroThemeStyle.Dark;

            ApplyThemeToControls(newTheme); // Atualiza a interface
        }

        private void ApplyThemeToControls(MetroFramework.MetroThemeStyle theme)
        {
            this.Theme = theme; // Aplica o tema ao formulário

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MetroFramework.Controls.MetroButton btn)
                {
                    btn.Theme = theme;
                }
                else if (ctrl is MetroFramework.Controls.MetroToggle toggle)
                {
                    toggle.Theme = theme;
                }
                else if (ctrl is MetroFramework.Controls.MetroLabel label)
                {
                    label.Theme = theme;
                }
                else if (ctrl is MetroFramework.Controls.MetroTextBox textBox)
                {
                    textBox.Theme = theme;
                }
            }

            this.Refresh(); // Atualiza a interface
        }

    }
}
