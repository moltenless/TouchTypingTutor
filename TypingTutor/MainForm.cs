using System;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using System.IO;

namespace TypingTutor
{
    public partial class MainForm : Form
    {
        Tutor tutor;
        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists("RussianText.txt"))
                File.Create("RussianText.txt");
            if (!File.Exists("EnglishText.txt"))
                File.Create("EnglishText.txt");
        }

        private void butStart_MouseDown(object sender, MouseEventArgs e)
        {
            tutor = new Tutor(Convert.ToInt32(numericCount.Value));
            Language lang = Language.Russian;
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            if (rdEng.Checked)
            {
                lang = Language.English;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            }
            lblText.Text = tutor.GetMixText(lang);
            lblText.ForeColor = Color.Black;
            tutor.Start();
        }

        private void butStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lblText.Text.Length == 0) return;
            if (e.KeyChar == lblText.Text[0])
            {
                lblText.Text = lblText.Text.Substring(1);
                lblText.ForeColor = Color.Green;
            }
            else
            {
                lblText.ForeColor = Color.Red;
                tutor.CountErrors++;
            }
            if (lblText.Text.Length == 0)
            {
                tutor.Stop();
            }
        }
    }
}
