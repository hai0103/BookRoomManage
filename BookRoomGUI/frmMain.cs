using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRoomGUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(frmUcBookRoom.Instance))
            {
                panelMain.Controls.Add(frmUcBookRoom.Instance);
                frmUcBookRoom.Instance.Dock = DockStyle.Fill;
                frmUcBookRoom.Instance.BringToFront();
            }
            else
                frmUcBookRoom.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Add(frmUcBookRoom.Instance);
            frmUcBookRoom.Instance.Dock = DockStyle.Fill;
            frmUcBookRoom.Instance.BringToFront();
        }
    }
}
