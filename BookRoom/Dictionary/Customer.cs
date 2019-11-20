using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace BookRoomManage
{
    public class Customer
    {
        #region property
        public Guid CustomerID { get; set; }

        public string CustomerNo { get; set; }

        public string CustomerName { get; set; }

        public DateTime Birthday { get; set; }

        public bool Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string IdentityCard { get; set; }

        public string Email { get; set; }

        public string Nationality { get; set; }
        #endregion

        #region constructor
        public Customer()
        {

        }


        public Customer(Guid customerID,string customerNo, string customerName, DateTime birthday, bool gender, string phoneNumber, string identityCard, string email, string nationality)
        {
            CustomerID = customerID;
            CustomerNo = customerNo;
            CustomerName = customerName;
            Birthday = birthday;
            Gender = gender;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
            Email = email;
            Nationality = nationality;
        }

        public Customer(string customerNo,string customerName,string phoneNumber, string identityCard)
        {
            CustomerID = Guid.NewGuid();
            CustomerNo = customerNo;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
        }

        public Customer(string customerNo, string customerName, DateTime birthday, bool gender, string phoneNumber, string identityCard, string email, string nationality)
        {
            CustomerID = Guid.NewGuid();
            CustomerNo = customerNo;
            CustomerName = customerName;
            Birthday = birthday;
            Gender = gender;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
            Email = email;
            Nationality = nationality;
        }
        #endregion

        #region method
        /// <summary>
        /// Lấy dang sách khachs hàng
        /// </summary>
        /// <returns></returns>
        public DataTable GetCustomers()
        {
            return Provider.Instance.ExcuteQuery("PROC_GetCustomers");
        } 

        /// <summary>
        /// Thêm mới Khách hàng
        /// </summary>
        public int InsertCustomer()
        {
            int result = Provider.Instance.ExcuteNonQuery("PROC_InsertCustomer", this);
            return result;
        }

        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        public int UpdateCustomer()
        {
            int result = Provider.Instance.ExcuteNonQuery("PROC_UpdateCustomer", this);
            return result;
        }

        /// <summary>
        /// Tìm kiếm khách hàng theo số CMT
        /// </summary>
        /// <returns>Thông tin chi tiết khách hàng</returns>
        public Customer FindCustomerByCMT(string cmt)
        {
            DataRow row=Provider.Instance.ExcuteQuery("PROC_GetCustomerByCMT",new { IdentityCard = cmt }).Rows[0];

            Customer customer = new Customer();
            customer.CustomerID = new Guid(row[0].ToString());
            customer.CustomerNo = row[1].ToString();
            customer.CustomerName = row[2].ToString();
            customer.Birthday =  DateTime.Parse(row[3].ToString());
            customer.Gender = bool.Parse(row[4].ToString());
            customer.PhoneNumber = row[5].ToString();
            customer.IdentityCard = row[6].ToString();
            customer.Email = row[7].ToString();
            customer.Nationality = row[8].ToString();

            return customer;
        }

        /// <summary>
        /// Tìm kiếm khách hàng theo tên
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns>customers</returns>
        public List<Customer> FindCustomerByName(string customerName)
        {
            List<Customer> customers = new List<Customer>();

            DataTable dataTable = Provider.Instance.ExcuteQuery("PROC_GetCustomerByName", new { CustomerName = customerName });
            foreach(DataRow row in dataTable.Rows)
            {
                Customer cust = new Customer();

                cust.CustomerID = new Guid(row[0].ToString());
                cust.CustomerNo = row[1].ToString();
                cust.CustomerName = row[2].ToString();
                cust.Birthday = DateTime.Parse(row[3].ToString());
                cust.Gender = bool.Parse(row[4].ToString());
                cust.PhoneNumber = row[5].ToString();
                cust.IdentityCard = row[6].ToString();
                cust.Email = row[7].ToString();
                cust.Nationality = row[8].ToString();

                customers.Add(cust);
            }

            return customers;
        }
        #endregion
    }
}
