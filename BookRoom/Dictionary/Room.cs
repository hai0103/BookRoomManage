using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRoomManage
{
    public class Room
    {
        #region property
        public Guid RoomID { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public int RoomState { get; set; }
        public Guid TypeRoomID { get; set; }
        #endregion

        #region constructor
        public Room()
        {

        }
        public Room(string roomNo, string roomName, int roomState, Guid typeRoomID)
        {
            RoomID = Guid.NewGuid();
            RoomNo = roomNo;
            RoomName = roomName;
            RoomState = roomState;
            TypeRoomID = typeRoomID;
        }
        #endregion

        #region method
        /// <summary>
        /// Lấy danh sách phòng 
        /// </summary>
        /// <returns>Danh sách phòng</returns>
        public DataTable GetRooms()
        {
            return Provider.Instance.ExcuteQuery("PROC_GetRooms");
        }

        /// <summary>
        /// Lấy thông tin chi tiết phòng theo id
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns>Danh sách phòng</returns>
        public object GetRoom(Guid roomID)
        {
            DataRow row = Provider.Instance.ExcuteQuery("PROC_GetRoom", new { RoomID = roomID }).Rows[0];
            return new
            {
                RoomNo = row[0].ToString(),
                RoomName = row[1].ToString(),
                RoomState = int.Parse(row[2].ToString()),
                TypeRoomPrice = decimal.Parse(row[3].ToString()),
                TypeRoomName = row[4].ToString()
            };

        }

        /// <summary>
        /// Lấy giá tiền của phòng
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns>Tiền</returns>
        public decimal GetPrice(Guid roomID)
        {
            decimal price = (decimal)Provider.Instance.ExcuteScalar("PROC_GetRoomPrice", new { RoomID = roomID });
            return price;
        }

        /// <summary>
        /// Cập nhật trạng thái phòng
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public int UpdateStatus(int state)
        {
            return Provider.Instance.ExcuteNonQuery("PROC_UpdateRoomState", new { RoomID = this.RoomID, RoomState = state });
        }

        /// <summary>
        /// Lọc phòng theo giá phòng
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public DataTable FilterRoomByPrice(decimal price, DateTime start, DateTime end)
        {
            if (price == 0)
            {
                return Provider.Instance.ExcuteQuery("PROC_GetRooms");
            }

            return Provider.Instance.ExcuteQuery("PROC_FilterRoomByPrice", new { TypeRoomPrice = price });
        }

        /// <summary>
        /// Lấy danh sách phòng theo loại phòng
        /// </summary>
        /// <param name="typeRoomID"></param>
        /// <returns></returns>
        public DataTable FilterRoomByType(int typeRoomID, DateTime start, DateTime end)
        {
            
            return Provider.Instance.ExcuteQuery("PROC_FilterRoomsByType", new { TypeRoomID = typeRoomID, StartDate = start, EndDate = end });
        }
        #endregion
    }
}
