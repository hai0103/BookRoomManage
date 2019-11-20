using BookRoomManage;
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

        public void fillContentRoom(Guid id)
        {
            Room room = new Room();
            var roomDetail = room.GetRoom(id);
            System.Reflection.PropertyInfo pi = roomDetail.GetType().GetProperty("RoomNo");
            String text = (String)(pi.GetValue(roomDetail, null));
            txtRoomNo.Text = text;
            pi = roomDetail.GetType().GetProperty("RoomName");
            text = (String)(pi.GetValue(roomDetail, null));
            txtRoomName.Text = text;
            pi = roomDetail.GetType().GetProperty("TypeRoomPrice");
            text = (pi.GetValue(roomDetail, null)).ToString();
            txtPrice.Text = text;
            pi = roomDetail.GetType().GetProperty("RoomID");
            text = (pi.GetValue(roomDetail, null)).ToString();
            txtRoomID.Text = text;
            
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
            dtCreateDate.Value = DateTime.Now;
            txtBookRoomNo.Text = Provider.Instance.ExcuteScalar("PROC_AutoGenerateBookRoomNo").ToString();
        }

        private void button2_Focus(object sender, EventArgs e)
        {
            this.ActiveControl = txtCustomerNo;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string cmt = txtCustomerNo.Text;
            Customer customer = new Customer();
            Customer cus = customer.FindCustomerByCMT(cmt);
            txtCustomerID.Text = cus.CustomerID.ToString();
            txtCustomerNo.Text = cus.CustomerNo;
            txtCustomerName.Text = cus.CustomerName;
            txtGender.Text = cus.Gender.ToString();
            txtBirthday.Text = cus.Birthday.ToString();
            txtPhone.Text = cus.PhoneNumber;
            txtCMT.Text = cus.IdentityCard;
            txtEmail.Text = cus.Email;
            txtNationality.Text = cus.Nationality;
        }

        private void btnCalcDeposit_Click(object sender, EventArgs e)
        {
            BookRoom bookRoom = new BookRoom();
            DateTime startDate = new DateTime(dtStartDate.Value.Year, dtStartDate.Value.Month, dtStartDate.Value.Day);
            DateTime endDate = new DateTime(dtEndDate.Value.Year, dtEndDate.Value.Month, dtEndDate.Value.Day);
            Guid roomID = new Guid(txtRoomID.Text);
            txtDeposit.Text = bookRoom.CalculateDeposit(roomID, startDate, endDate).ToString();
        }

        private void btnCalcCost_Click(object sender, EventArgs e)
        {
            BookRoom bookRoom = new BookRoom();
            DateTime startDate = new DateTime(dtStartDate.Value.Year, dtStartDate.Value.Month, dtStartDate.Value.Day);
            DateTime endDate = new DateTime(dtEndDate.Value.Year, dtEndDate.Value.Month, dtEndDate.Value.Day);
            Guid roomID = new Guid(txtRoomID.Text);
            txtCost.Text = bookRoom.CalculateCost(roomID, startDate, endDate).ToString();
        }

        private void btnAddBookRoom_Click(object sender, EventArgs e)
        {
            string bookRoomNo = txtBookRoomNo.Text;
            DateTime createDate = new DateTime(dtCreateDate.Value.Year, dtCreateDate.Value.Month, dtCreateDate.Value.Day);
            DateTime startDate = new DateTime(dtStartDate.Value.Year, dtStartDate.Value.Month, dtStartDate.Value.Day);
            DateTime endDate = new DateTime(dtEndDate.Value.Year, dtEndDate.Value.Month, dtEndDate.Value.Day);
            decimal deposit = decimal.Parse(txtDeposit.Text);
            Guid roomID = new Guid(txtRoomID.Text);
            Guid customerID = new Guid(txtCustomerID.Text);
            BookRoom bookRoom = new BookRoom(bookRoomNo, createDate, startDate, endDate, deposit, roomID, customerID,null);

            int result = bookRoom.Create();
            if (result < 0)
            {
                MessageBox.Show("Thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            DialogResult msg = MessageBox.Show("Thành công!");
            if (msg == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
