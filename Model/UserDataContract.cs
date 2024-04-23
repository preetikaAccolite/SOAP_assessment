using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SOAP_assessment.Model
{
    [DataContract]
    public class UserDataContract
    {
       
            //[DataMember]
            //public double Id { get; set; }
            [DataMember]
            public double firstnumber { get; set; }

            [DataMember]
            public double secondnumber { get; set; }
        [DataMember]
        public double  result { get; set; }


        
    }
}
