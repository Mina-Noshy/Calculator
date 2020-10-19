using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MyApp
{
    public partial class CalculatorForm : MetroForm
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                var resualt = new DataTable().Compute(txtProcess.Text, string.Empty);
                txtResualt.Text = resualt.ToString();
            }
            catch
            {
                txtResualt.Text = string.Empty;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "1";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "2";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "3";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "4";
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "5";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "6";
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "7";
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "8";
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "9";
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "0";
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "00";
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            txtProcess.Text += ".";
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "(";
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            txtProcess.Text += ")";
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "+";
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "-";
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "*";
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "/";
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            txtProcess.Text = string.Empty;
            txtResualt.Text = string.Empty;
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            try
            {
                txtProcess.Text = txtProcess.Text.Substring(0, txtProcess.Text.Count() - 1);
            }
            catch
            {

            }
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            txtProcess.Text += "000";
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked)
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;

                metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton10.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton11.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton12.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton13.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton14.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton15.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton16.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton17.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton18.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton19.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton20.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton21.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroButton22.Theme = MetroFramework.MetroThemeStyle.Dark;

                txtProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
                txtResualt.Theme = MetroFramework.MetroThemeStyle.Dark;

                metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;

                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Text = "dark mode";
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;

                metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton7.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton8.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton9.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton10.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton11.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton12.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton13.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton14.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton15.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton16.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton17.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton18.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton19.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton20.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton21.Theme = MetroFramework.MetroThemeStyle.Light;
                metroButton22.Theme = MetroFramework.MetroThemeStyle.Light;

                txtProcess.Theme = MetroFramework.MetroThemeStyle.Light;
                txtResualt.Theme = MetroFramework.MetroThemeStyle.Light;

                metroToggle1.Theme = MetroFramework.MetroThemeStyle.Light;

                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel1.Text = "light mode";
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void txtProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtProcess_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
