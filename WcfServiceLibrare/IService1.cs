using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrare
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
    }

    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "WcfServiceLibrare.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
//<? xml version = "1.0" encoding = "utf-8" ?>
//< configuration >

//  < appSettings >
//    < add key = "aspnet:UseTaskFriendlySynchronizationContext" value = "true" />
//  </ appSettings >
//  < system.web >
//    < compilation debug = "true" />
//  </ system.web >
//  < !--При развертывании проекта библиотеки службы содержимое файла конфигурации необходимо добавить в 
//  файл app.config компьютера размещения. Пространство имен System.Configuration не поддерживает файлы конфигурации для библиотек. -->
//  <system.serviceModel>
//    <services>
//      <service name="WcfServiceLibrare.Service1">
//        <host>
//          <baseAddresses>

//			  <add baseAddress = "http://localhost:8733/Design_Time_Addresses/WcfServiceLibrare/Service1/" />
//          </baseAddresses>
//        </host>
//        <!-- Service Endpoints -->
//        <!-- Если адрес не задан полностью, он является относительным к вышеуказанному базовому адресу -->
//        <endpoint address="" binding="basicHttpBinding"    bindingConfiguration="secureHttpBinding"
// contract="WcfServiceLibrare.IService1">
//          <!-- 
//              После развертывания необходимо удалить или заменить указанный ниже элемент удостоверения, чтобы отображалось
//              удостоверение, под которым выполняется развернутая служба. В случае удаления служба WCF автоматически определит соответствующее 
//              удостоверение.
//          -->
//          <identity>
//            <dns value="localhost"/>
//          </identity>
//        </endpoint>
//        <!-- Metadata Endpoints -->
//        <!-- Конечная точка Metadata Exchange используется службой, чтобы описать эту службу клиентам. --> 
//        <!-- Эта конечная точка не использует безопасную привязку и должна быть защищена или удалена перед развертыванием -->
//        <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange"/>
//      </service>
//    </services>
//    <behaviors>
//      <serviceBehaviors>
//        <behavior>
//          <!--Чтобы избежать раскрытия метаданных,
//          до развертывания задайте следующим параметрам значение "false". -->
//          <serviceMetadata httpGetEnabled="True" httpsGetEnabled="True"/>
//          <!-- Чтобы получить сведения об исключениях в ошибках для отладки,
//          установите ниже значение TRUE. Перед развертыванием установите значение FALSE,
//           чтобы избежать разглашения сведений об исключении -->
//          <serviceDebug includeExceptionDetailInFaults="False" />
//        </behavior>
//      </serviceBehaviors>
//	</behaviors>
//	  <bindings>
//		  <basicHttpBinding>
//			  <binding name="secureHttpBinding">
//				  <security mode="None" />
//			  </binding>
//		  </basicHttpBinding>
//	  </bindings>
//  </system.serviceModel>
//</configuration>
