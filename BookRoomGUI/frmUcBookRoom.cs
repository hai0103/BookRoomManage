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
            loadAllRoom();
        }

        #region Method

        public void loadAllRoom()
        {
            Room room = new Room();
            DataTable allRoom = room.GetRooms();
            loadRoomList(allRoom);
        }

        public void loadRoomList(DataTable dataTable)
        {

            Room room = new Room();
            DataTable tblrooms = dataTable;
            flpRooms.Controls.Clear();
            foreach (DataRow row in tblrooms.Rows)
            {
                Button button = new Button();
                button.Name = "btn" + row[1].ToString();
                button.Width = 80;
                button.Height = 50;
                button.Text = row[1].ToString() + Environment.NewLine + row[4].ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                //
                button.Click += click_Room;
                button.Tag = row[0].ToString();
                //
                switch (row[3].ToString())
                {
                    case "0":
                        button.BackColor = ColorTranslator.FromHtml("#a8e6cf");
                        break;
                    default:
                        button.BackColor = ColorTranslator.FromHtml("#ff6f69");
                        break;

                }
                flpRooms.Controls.Add(button);
            }
        }
        #endregion

        void showAddBookRoom(Guid id)
        {
            frmAddBookRoom add = new frmAddBookRoom();
            Room room = new Room();
            var roomDetail =  room.GetRoom(id);
            
            add.Show();
        }

        void click_Room(object sender, EventArgs e)
        {
            Button row = (sender as Button);
            Guid id = new Guid(row.Tag.ToString());
            showAddBookRoom(id);
        }

        private void btnFilterRoom_Click(object sender, EventArgs e)
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
