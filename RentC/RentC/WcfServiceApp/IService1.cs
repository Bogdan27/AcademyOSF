using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        GetListData getData();

    }

    [DataContract]
    public class GetListData
    {
        [DataMember]
        public DataTable userTable
        { get; set; }
    }
}
