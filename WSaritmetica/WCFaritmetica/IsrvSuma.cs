using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFaritmetica
{
   
    [ServiceContract]
    public interface IsrvSuma
    {

        [OperationContract]
        clsSuma suma(int numero1, int numero2);
    }

     [DataContract]
     public class clsSuma:baseResultado 
    {
        [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numerob { get; set; }
        [DataMember]
        public int resultado { get; set; }
    }

    public class baseResultado
    {
        public string mensaje { get; set; }
        public string error { get; set; }
    }
}
