using System.Windows.Forms;

namespace kGlow.Client
{
    public partial class frmDSEWarn : Form
    {
        public frmDSEWarn()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
        }

        private void btnAbort_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
