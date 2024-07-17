using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using DevExpress.Persistent.BaseImpl.EF;

namespace OData.Server.BusinessObjects {
    public class OrderItem : BaseObject {
        public virtual string ProductName { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual float Discount { get; set; }
        public virtual DateTime OrderDate { get; set; }

        public static List<OrderItem> GetInitialData() {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("order_items.xml"));

            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<OrderItem>));
            using(Stream stream = assembly.GetManifestResourceStream(resourceName))
                return (List<OrderItem>)xsSubmit.Deserialize(stream);
        }
    }
}
