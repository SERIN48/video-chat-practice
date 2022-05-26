using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabApp
{
    public partial class StartForm : Form
    {
        ViewInterface viewInterface;
        public StartForm(ViewInterface viewInterface)
        {
            this.viewInterface = viewInterface;
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            viewInterface.ViewCreateForm();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            viewInterface.ViewJoinForm();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
