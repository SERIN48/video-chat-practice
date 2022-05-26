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
    public partial class CreateForm : UserControl
    {
        ViewInterface viewInterface;
        NetworkInterface networkInterface;
        LectureRoomInfoInterface lectureRoomInfoInterface;

        public CreateForm(ViewInterface viewInterface, NetworkInterface networkInterface, LectureRoomInfoInterface lectureRoomInfoInterface)
        {
            this.viewInterface = viewInterface;
            this.networkInterface = networkInterface;
            this.lectureRoomInfoInterface = lectureRoomInfoInterface;

            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
