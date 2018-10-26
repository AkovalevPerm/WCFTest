using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ICarService" в коде и файле конфигурации.
    // App.config удалён так как будет использоваться CarHost и данные будут браться из него.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void SetCar(Car c);

        [OperationContract]
        Car GetCar(int id);
    }
}
