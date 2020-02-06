using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYSForms
{
    public partial class DialogResultButtons : UserControl
    {
        public DialogResultButtons()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Form form = (Form)SearchParent(this.Parent);
            form.DialogResult = DialogResult.Cancel;
            form.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form form = (Form)SearchParent(this.Parent);
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        private Object SearchParent(Object obj)
        {
            if (obj.GetType() == typeof(Form) || obj.GetType() == typeof(DetailsForm) || obj.GetType() == typeof(BaseForm))
                return obj;
            else
                return SearchParent(((Control)obj).Parent);
        }
    }
}
