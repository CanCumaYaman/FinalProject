using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied = "You have no authorization";
        public static string UserRegistered = "Successfully registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Invalid password";
        public static string SuccessfulLogin = "Login successfull";
        public static string UserAlreadyExists = "This user already exist";
        public static string AccessTokenCreated = "Access token created";
    }
}
