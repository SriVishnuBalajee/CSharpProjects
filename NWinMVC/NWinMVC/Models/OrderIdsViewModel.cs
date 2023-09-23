using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Policy;

namespace NWinMVC.Models
{
    public class OrderIdsViewModel
    {
        public int ID { get; set; }
        public  List<SelectListItem> selectListItems;


        public OrderIdsViewModel()
        {

        }
        public OrderIdsViewModel (List<int> orderIds)
        {
            selectListItems = new List<SelectListItem>();
            foreach (var obj in orderIds)
            {
                selectListItems.Add(new SelectListItem { Text = $"{obj}", Value = $"{obj}" });

            }
        }

       
    }
}
