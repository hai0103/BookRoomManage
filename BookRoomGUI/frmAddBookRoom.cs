﻿using BookRoomManage;
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
            bookRoom.StartDate = Convert.ToDateTime(dtStartDate.Value.ToString("MM/dd/yyyy"));
            bookRoom.EndDate = Convert.ToDateTime(dtEndDate.Value.ToString("MM/dd/yyyy"));
            
        }
    }
}
