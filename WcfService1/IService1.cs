using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertUserDetails (UserDetails userInfo);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserDetails
    {
        string name = String.Empty;
        string address = String.Empty;
        string pin= String.Empty;
        string phone = String.Empty;
        string email = String.Empty;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name= value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DataMember]
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        [DataMember]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
