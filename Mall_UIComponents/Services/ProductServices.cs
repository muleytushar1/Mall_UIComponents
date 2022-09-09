using Mall_UIComponents.Models;
using Newtonsoft.Json;

namespace Mall_UIComponents.Services
{
    public class ProductServices
    {
        public IEnumerable<Tushar> GetAllProducts()
        {
            List<Tushar> list = new List<Tushar>();

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage responseMessage = httpClient.GetAsync($"https://localhost:7052/api/Home/GetAll").Result;
            if (responseMessage.IsSuccessStatusCode)
            {

                //var response = responseMessage.Content.ReadAsStringAsync().Result.Replace("\\", "")
                //         .Trim(new char[1] { '"' })); ;

                //list = JsonConvert.DeserializeObject<List<Tushar>>(response).ToList();

                var response = JsonConvert.DeserializeObject<List<Tushar>>(responseMessage.Content.ReadAsStringAsync()
                                               .Result
                                               .Replace("\\", "")
                                               .Trim(new char[1] { '"' }));

              var list1 = string.Join(", ", response);


                foreach (var item in response)
                { 
                    list.Add(item);
                } 

            }

            return list;
        }

        public Products PostProducts(int CategoryId, Products products)
        {
            List<Products> list = new List<Products>();
            Products productresult = new Products();
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage responseMessage = httpClient.PostAsJsonAsync($"https://localhost:7052/api/Home/PostbyCategoryId?CategoryId={CategoryId}", products).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var response = responseMessage.Content.ReadAsStringAsync().Result;
                
                productresult= JsonConvert.DeserializeObject<Products>(response);

            }
            return productresult;

               
        }
    }
}
