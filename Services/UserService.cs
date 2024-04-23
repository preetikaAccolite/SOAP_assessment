using SOAP_assessment.Model;
using static SOAP_assessment.Model.UserServiceContract;

namespace SOAP_assessment.Services
{
    public class UserService : IUserService
    {

        public double Addition(double firstnumber, double secondnumber)
        {
            return firstnumber + secondnumber;
        }

        public double Division(double firstnumber, double secondnumber)
        {
            return firstnumber/secondnumber;
        }

        public double Multiplication(double firstnumber, double secondnumber)
        {
            return firstnumber * secondnumber;
        }

        public double Substraction(double firstnumber, double secondnumber)
        {
            return firstnumber - secondnumber;
        }
    }
}
