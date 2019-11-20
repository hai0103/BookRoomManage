using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookRoomManage;

namespace BookRoomGUI
{
    public partial class frmUcBookRoom : UserControl
    {
        private static frmUcBookRoom _instance;
        public static frmUcBookRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmUcBookRoom();
                return _instance;
            }
        }
        public frmUcBookRoom()
        {
            InitializeComponent();
            loadRoomList();
        }

        #region Method
        public void loadRoomList()
        {
            Room room = new Room();
            DataTable tblrooms = room.FilterRoomByType(1, new DateTime(2019, 11, 20), new DateTime(2019, 11, 24));
            foreach (DataRow row in tblrooms.Rows)
            {
                Button button = new Button();
                button.Width = 80;
                button.Height = 50;
                button.Text = row[1].ToString() + Environment.NewLine + row[0].ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                switch (row[3].ToString())
                {
                    case "0":
                        button.BackColor = ColorTranslator.FromHtml("#4ceb0b");
                        break;
                    default:
                        button.BackColor = ColorTranslator.FromHtml("#eb190b");
                        break;

                }
                flpRooms.Controls.Add(button);
            }
        }
        #endregion
    }
}
