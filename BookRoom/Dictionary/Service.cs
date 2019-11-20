using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRoomManage
{
    public class Service
    {
        #region property
        public Guid ServiceID { get; set; }

        public string ServiceNo { get; set; }

        public string ServiceName { get; set; }

        public decimal ServicePrice { get; set; }

        public string Description { get; set; }

        public string ServiceType { get; set; }
        #endregion

        #region constructor
        public Service()
        {

        }
        #endregion

        #region method
        public List<Service> GetServices()
        {
            //Lấy dữ liệu từ datbase
            DataTable dataTable = Provider.Instance.ExcuteQuery("PROC_GetServices");

            // Tạo 1 danh sách các service 
            List<Service> services = new List<Service>();
            foreach(DataRow row in dataTable.Rows)
            {
                Service service = new Service();
                service.ServiceID = new Guid(row[0].ToString());
                service.ServiceNo = row[1].ToString();
                service.ServiceName = row[2].ToString();
                service.ServicePrice = decimal.Parse(row[3].ToString());
                service.Description = row[4].ToString();
                service.ServiceType = row[5].ToString();

                services.Add(service);
            }

            return services;
        }

        public Service GetService(Guid serviceID)
        {
            // Lấy dữ liệu từ database
            DataRow row = Provider.Instance.ExcuteQuery("PROC_GetService", new { ServiceID = serviceID }).Rows[0];

            //Tạo đối tượng service 
            Service service = new Service();
            service.ServiceID = new Guid(row[0].ToString());
            service.ServiceNo = row[1].ToString();
            service.ServiceName = row[2].ToString();
            service.ServicePrice = decimal.Parse(row[3].ToString());
            service.Description = row[4].ToString();
            service.ServiceType = row[5].ToString();

            return service;
        }
        #endregion
    }
}
