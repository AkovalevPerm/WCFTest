using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Summator
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ISummator" в коде и файле конфигурации.
    // Можно указать имя контракта, тогда оно перекрывает имя интрефейса и в конфиге нужно указывать именоо его.
    // На клиентах используется старое название ISummator.
    // Такие трюки нужны для подмены реализации без изменения клиентов.
    [ServiceContract(Name = "ISummator")]
    public interface ISummatorOld
    {
        [OperationContract(Name = "GetSum")]
        int GetSumOld(int x, int y);
    }

    // Подмена суммы умножением
    //[ServiceContract(Name = "ISummator")]
    [ServiceContract]
    public interface ISummatorNew
    {
        //[OperationContract(Name = "GetSum")]
        [OperationContract]
        int GetMul(int x, int y);
    }

    [ServiceContract]
    public interface ISubtraction
    {
        [OperationContract]
        int GetSub(int x, int y);
    }
}
