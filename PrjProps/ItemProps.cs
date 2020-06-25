using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
  public  class ItemProps
    {

        private int id;
        private string name;
        private string barcode;
        private double purchase_price;
        private double sale_price;
        private int status;
        private string supplier;
        private string manufacturer;
        private string profile_img;
        private string created_at;
        private string updated_at;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public double Purchase_price { get => purchase_price; set => purchase_price = value; }
        public double Sale_price { get => sale_price; set => sale_price = value; }
        public int Status { get => status; set => status = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Profile_img { get => profile_img; set => profile_img = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }
    }
}
