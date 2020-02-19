using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProps
{
 public    class ItemProps
    {

        private int id;
        private String name;
        private Double saleprice;
        private Double purcahseprice;
        private int stock;
        private String manufacturer;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Saleprice
        {
            get
            {
                return saleprice;
            }

            set
            {
                saleprice = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public double Purcahseprice
        {
            get
            {
                return purcahseprice;
            }

            set
            {
                purcahseprice = value;
            }
        }
    }
}
