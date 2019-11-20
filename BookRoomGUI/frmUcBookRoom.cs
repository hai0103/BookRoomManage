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
        }

        #region Method
        public void loadRoomList(DataTable dataTable)
        {

            Room room = new Room();
            DataTable tblrooms = dataTable;
            flpRooms.Controls.Clear();
            foreach (DataRow row in tblrooms.Rows)
            {
                Button button = new Button();
                button.Width = 80;
                button.Height = 50;
                button.Text = row[1].ToString() + Environment.NewLine + row[4].ToString();
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

        private void btnAddBookRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            int typeRoom = 0;
            DateTime startDate = new DateTime(dtStartDate.Value.Year, dtStartDate.Value.Month, dtStartDate.Value.Day);
            DateTime endDate = new DateTime(dtEndDate.Value.Year, dtEndDate.Value.Month, dtEndDate.Value.Day);
            switch (comboBox1.Text)
            {
                case "Phòng phổ thông đơn":
                    typeRoom = 1;
                    loadRoomList (room.FilterRoomByType(typeRoom,startDate,endDate));
                    break;
                case "Phòng phổ thông đôi":
                    typeRoom = 2;
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;
                case "Phòng thương gia đơn":
                    typeRoom = 3;
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;
                case "Phòng thương gia đôi":
                    typeRoom = 4;
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;
                case "Phòng cao cấp đơn":
                    typeRoom = 5;
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;
                case "Phòng cao cấp đôi":
                    typeRoom = 6;
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;
                default:
                    loadRoomList(room.FilterRoomByType(typeRoom, startDate, endDate));
                    break;

            }
            
        }
    }
}
