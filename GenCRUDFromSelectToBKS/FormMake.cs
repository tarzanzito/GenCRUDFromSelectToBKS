using System;
using System.Windows.Forms;

namespace MakeCRUDFromSelect
{
    public partial class FormMake : Form
    {
        public FormMake()
        {
            InitializeComponent();
        }

        private void buttonGenerateCRUD_Click(object sender, EventArgs e)
        {
            textBoxRight.Clear();

            textBoxRight.Text = GenerateCRUDFromSelect(textBoxLeft.Text);
        }

        private string GenerateCRUDFromSelect(string text)
        {
            SQLGenerate sqlGen = new SQLGenerate();
            sqlGen.MountFromSelectStatement(text);

            string sel = sqlGen.GenerateSelect();
            string ins = sqlGen.GenerateInsert();
            string upd = sqlGen.GenerateUpdate();
            string del = sqlGen.GenerateDelete();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(sel);
            sb.AppendLine("-------------------------------------");
            sb.AppendLine(ins);
            sb.AppendLine("-------------------------------------");
            sb.AppendLine(upd);
            sb.AppendLine("-------------------------------------");
            sb.AppendLine(del);

            return sb.ToString();
        }

        private void FormMake_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - Version: " + System.Windows.Forms.Application.ProductVersion.ToString();
        }
    }
}
