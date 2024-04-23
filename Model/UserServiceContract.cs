using System.ServiceModel;

namespace SOAP_assessment.Model
{
    public class UserServiceContract
    {
        [ServiceContract]
        public interface IUserService
        {
            [OperationContract]
            double Addition(double firstnumber,double secondnumber);
            [OperationContract]
            double Substraction(double firstnumber, double secondnumber);
            [OperationContract]
            double Multiplication(double firstnumber, double secondnumber);
            [OperationContract]
            double Division(double firstnumber, double secondnumber);



        }
    }
}
