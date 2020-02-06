using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYSForms
{
    public partial class DetailsForm : BaseForm
    {
        DialogResultButtons dialogResultButtons = new DialogResultButtons();

        public DetailsForm()
        {
            InitializeComponent();

            this.tableLayoutPanel.Controls.Add(dialogResultButtons, 0, 1);

            dialogResultButtons.Anchor = AnchorStyles.Right;
        }
    }
}
