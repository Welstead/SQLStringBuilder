using System.Text;

namespace SQLStringBuilder
{
    public partial class Form1 : Form
    {
        bool sqlToSB = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSQL.Text = string.Empty;
            txtStringBuilder.Text = string.Empty;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStringBuilder.Text))
            {
                return;
            }
            Clipboard.SetText(txtStringBuilder.Text);
            txtStringBuilder.SelectAll();
            txtStringBuilder.Focus();
        }

        private void txtSQL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sqlToSB)
                {
                    var sql = txtSQL.Text.Trim();
                    var sb = new StringBuilder();
                    sb.AppendLine("var sql = new StringBuilder();");
                    foreach (var line in sql.Split("\r\n"))
                    {
                        sb.AppendLine("sql.AppendLine(\"" + line + " \");");
                    }
                    txtStringBuilder.Text = sb.ToString();
                }
                else
                {
                    var text = txtSQL.Text.Trim();
                    var sb = new StringBuilder();
                    foreach (var line in text.Split("\r\n"))
                    {
                        var splitString = line.Split('\"');
                        if (splitString.Length != 3)
                        {
                            continue;
                        }
                        sb.AppendLine(splitString[1].Trim());
                    }
                    txtStringBuilder.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            sqlToSB = !sqlToSB;
            lblTextBox1.Text = sqlToSB ? "SQL" : "StringBuilder";
            lblTextBox2.Text = !sqlToSB ? "SQL" : "StringBuilder";
        }
    }
}