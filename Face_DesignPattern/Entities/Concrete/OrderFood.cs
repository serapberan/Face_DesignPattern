using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OrderFood   //YemekSiparişi
    {
        public int Id { get; set; }
        public string Breakfast { get; set; }        //Kahvaltı
        public string Brunch { get; set; }          //öğle yemeği
        public string Dinner { get; set; }          //Akşam yemeği
        public string Drink { get; set; }           //icekler
        public string OrderNumber { get; set; }     //Sipariş Numarası
    }
}
