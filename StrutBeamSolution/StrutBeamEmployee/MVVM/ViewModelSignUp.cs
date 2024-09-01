using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using StrutBeam.MVVM.ViewModels;
using StrutBeamEmployee.Models;
using StrutBeamEmployee.MVVM;

namespace StrutBeam.MVVM.ViewModels
{
    public class ViewModelSignUp
    {
        string uri = string.Empty;

        private readonly Employee _employee;
        public ViewModelSignUp(Employee employee, string _uri)
        {
            _employee = employee;
            uri = _uri;
        }

        public async Task<string> CreateEmployee() 
        {
            string response = string.Empty;
            try
            {
                using (var clientHttp = new HttpClient())
                {
                    var clientSerialized = JsonConvert.SerializeObject(_employee);
                    var content = new StringContent(clientSerialized, Encoding.UTF8, "application/json");
                    var result = await clientHttp.PostAsync($"https://{uri}.ngrok-free.app/register/employee", content);
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                response = ex + "\nUnavailable server. Try again or later";
            }        
            return response;    
        }

        public async Task<int> SelectEmployee() 
        {
            var employee = new Employee();
            try
            {
                using(HttpClient clientHttp = new HttpClient()) 
                {
                    using (var response = await clientHttp.GetAsync($"https://{uri}.ngrok-free.app/sign-in/employee?username={_employee.Username}&password={_employee.Password}"))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            var clientJsonString = await response.Content.ReadAsStringAsync();
                            employee = JsonConvert.DeserializeObject<Employee>(clientJsonString);
                            if (employee != null)
                            {
                                return employee.Id;
                            }                            
                        }
                    }
                }
            }
            catch(Exception e)
            {
                new View00ErrorMessage("Error",e.ToString());
            }
            return 0;
        }


    }
}
