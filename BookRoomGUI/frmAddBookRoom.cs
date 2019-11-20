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
    public partial class frmAddBookRoom : Form
    {
        public frmAddBookRoom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            this.ActiveControl=txtCustomerNo;
        }

        private void button2_Focus(object sender, EventArgs e)
        {
            this.ActiveControl = txtCustomerNo;
        }
    }
}
