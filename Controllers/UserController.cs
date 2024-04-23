using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace SOAP_assessment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet("Add: {firstnumber:double}, {secondnumber:double}")]
        public async Task<double> AdditionAsync(double firstnumber, double secondnumber)
        {
            IUserService userService = new UserServiceClient(UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService);
            return await userService.AdditionAsync(firstnumber, secondnumber);
        }

        [HttpGet("Subtract: {firstnumber:double}, {secondnumber:double}")]
        public async Task<double> SubstractionAsync(double firstnumber, double secondnumber)
        {
            IUserService userService = new UserServiceClient(UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService);
            return await userService.SubstractionAsync(firstnumber, secondnumber);
        }

        [HttpGet("Multiply: {firstnumber:double}, {secondnumber:double}")]
        public async Task<double> MultiplicationAsync(double firstnumber, double secondnumber)
        {
            IUserService userService = new UserServiceClient(UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService);
            return await userService.MultiplicationAsync(firstnumber, secondnumber);
        }

        [HttpGet("Divide: {firstnumber:double}, {secondnumber:double}")]
        public async Task<double> DivisionAsync(double firstnumber, double secondnumber)
        {
            IUserService userService = new UserServiceClient(UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService);
            return await userService.DivisionAsync(firstnumber, secondnumber);
        }   
    }
}
