using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarService
{
    //http://localhost:8080/?xsd=xsd2 - дата контракт этого типа, по умолчанию, если не указывать что класс сериализуем, то сериализуются только паблик поля.
    [DataContract]
    public class Car
    {
        //Если задать  [DataMember(Order = 3)] в другом порядке, то поля не смогут правильно десериализоваться на клиенте(другой порядок), пока не будет обновлена ссылка на сервис.
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Vendor { get; set; }
        [DataMember]
        public string Model { get; set; }
        //Если при указании [DataContract] и [DataMember], один из атрибутов не пометить как сериализуемый, то его не будет и в http://localhost:8080/?xsd=xsd2
        public int Year { get; set; }
    }
}
