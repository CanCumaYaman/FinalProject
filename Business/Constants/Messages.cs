using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string CategoryLimitExceded = "Categories already more than 15";
    }
}
