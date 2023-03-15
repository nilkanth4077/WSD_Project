using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceApp
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Item> GetItems();
        [OperationContract]
        void InsertItem(Item iobj);
        [OperationContract]
        void UpdateItem(Item iobj);
        [OperationContract]
        void DeleteItem(int id);
    }
    [ServiceContract]
    public interface ICashierService1
    {
        [OperationContract]
        IEnumerable<Cashier> GetCashiers();
        [OperationContract]
        void InsertCashier(Cashier cobj);
        [OperationContract]
        void UpdateCashier(Cashier cobj);
        [OperationContract]
        void DeleteCashier(int id);
    }
    [DataContract]
    public class Cashier
    {
        [DataMember]
        [Key]
        [Required]
        public int cid { get; set; }
        [DataMember]
        [Required]
        public string cName { get; set; }
        [DataMember]
        [Required]
        public string cRole { get; set; }

    }
    [DataContract]
    public class Item
    {
        [DataMember]
        [Key]
        [Required]
        public int iid { get; set; }
        [DataMember]
        [Required]
        public string iName { get; set; }
        [DataMember]
        [Required]
        public int iQuantity { get; set; }
        [DataMember]
        [Required]
        public string iDesc { get; set; }

    }
}
