using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace WebApplication1.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public String DoWork()
        {
            return "Hello REST WCS Service! :)";
        }

        public int DoSquare(int value)
        {
            return value * value;
        }

        public int DoAddValues(AddValues addValues)
        {
            return addValues.Value1 + addValues.Value2;
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int Value1 { get; set; }
        [DataMember]
        public int Value2 { get; set; }

        public AddValues()
        {
            Value1 = 0;
            Value2 = 0;
        }

    }

}
