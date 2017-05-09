using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CultureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        { 
            var sb = new StringBuilder();
            var culture = Thread.CurrentThread.CurrentCulture;
            sb.AppendLine("CurrentCulture");
            AppendCulture(sb, culture);

            sb.AppendLine();
            var uiculture = Thread.CurrentThread.CurrentUICulture;
            sb.AppendLine("CurrentUICulture");
            AppendCulture(sb, uiculture);
            textBox1.Text = sb.ToString();
        }

        private void AppendCulture(StringBuilder sb, CultureInfo cultureInfo)
        {
            sb.AppendLine($"LCID = {cultureInfo.LCID}");
            sb.AppendLine($"LCID Hexadecimal = 0x{cultureInfo.LCID.ToString("x4")}");
            sb.AppendLine($"Name = {cultureInfo.Name}");
            sb.AppendLine($"NativeName = {cultureInfo.NativeName}");
            sb.AppendLine($"DisplayName = {cultureInfo.DisplayName}");
            sb.AppendLine($"EnglishName = {cultureInfo.EnglishName}");
            sb.AppendLine($"Name = {cultureInfo.Name}");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(txtLcid.Text.Trim(), 16);
                var cultureInfo = new CultureInfo(id);
                var sb = new StringBuilder();
                AppendCulture(sb, cultureInfo);
                textBox1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK);
            }
        }
    }
}
