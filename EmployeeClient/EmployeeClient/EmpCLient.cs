using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeClient;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;

namespace EmployeeClient
{
    internal class EmpCLient
    {
        static Uri uri = new Uri("http://localhost:5031");

        public static async Task CallGetEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                HttpResponseMessage response = await client.GetAsync("Get");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String x = await response.Content.ReadAsStringAsync();
                    await Console.Out.WriteLineAsync(x);
                }
            }
        }
        public static async Task CallGetEmployeeObj()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                List<EmpViewModel> employees = new List<EmpViewModel>();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("Get");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String json = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<EmpViewModel>>(json);

                    foreach (var emp in employees)
                    {
                        await Console.Out.WriteLineAsync($"{emp.EmpId},{emp.FirstName},{emp.LastName},{emp.Title},{emp.City},{emp.HireDate},{emp.BirthDate},{emp.ReportTo}");
                    }

                }
            }




        }
        public static async Task AddEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                EmpViewModel empViewModel = new EmpViewModel();
                empViewModel.EmpId = 13;
                empViewModel.FirstName = "Test";
                empViewModel.LastName = "Kumar";
                empViewModel.BirthDate = DateTime.Now;
                empViewModel.HireDate = DateTime.Now;
                empViewModel.Title = "Test";
                empViewModel.ReportTo = 1;
                empViewModel.City = "Thanjavur";
                var myContent = JsonConvert.SerializeObject(empViewModel);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage httpResponseMessage = await client.PostAsync("Add", byteContent);
                httpResponseMessage.EnsureSuccessStatusCode();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(httpResponseMessage.StatusCode.ToString());
                }



            }
        }
        public static async Task ModifyEmployee()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                EmpViewModel empViewModel = new EmpViewModel();
                empViewModel.EmpId = 13;
                empViewModel.FirstName = "Test";
                empViewModel.LastName = "Kumar";
                empViewModel.BirthDate = DateTime.Now;
                empViewModel.HireDate = DateTime.Now;
                empViewModel.Title = "Test";
                empViewModel.ReportTo = 1;
                empViewModel.City = "Thanjavur";
                var myContent = JsonConvert.SerializeObject(empViewModel);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage httpResponseMessage = await client.PutAsync("/Modify", byteContent);
                httpResponseMessage.EnsureSuccessStatusCode();
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(httpResponseMessage.StatusCode.ToString());
                }



            }


        }
        public static async Task DeleteEmployee()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/jason"));
                Console.Out.WriteLine("Enter the id to be Deletged");
                string temp = Console.ReadLine();
                int id = int.Parse(temp);
                var jason = JsonConvert.SerializeObject(id);
                var bytes = Encoding.UTF8.GetBytes(jason);
                var byteHttpClient = new ByteArrayContent(bytes);
                byteHttpClient.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/jason");
                var Uri = uri + $"Delete?id={id}";
                HttpResponseMessage response = await client.DeleteAsync(Uri);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync(response.StatusCode.ToString());
                }



            }


        }
    }
}

