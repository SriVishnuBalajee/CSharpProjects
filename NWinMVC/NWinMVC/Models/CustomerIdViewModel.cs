using Microsoft.AspNetCore.Mvc.Rendering;



namespace NWinMVC.Models
{
    public class CustomerIdViewModel
    {
        public int id { get; set; }
        public List<SelectListItem> orderList;



        public CustomerIdViewModel(List<string> order)
        {



            orderList = new List<SelectListItem>();



            foreach (var item in order)
            {
                orderList.Add(new SelectListItem { Text = item, Value = item });
            }
        }
        
    }
}