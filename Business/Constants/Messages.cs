using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Invalid product name";
        public static string MaintenanceTime = "Maintenance time";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "Count of category error.Exceded 10 products.";
        public static string ProductNameAlreadyExists = "Product Name Already Exists";
        public static string CategoryLimitExceded = "Category Limit Exceded";
        public static string AuthorizationDenied = "Authorization Denied";
    }
}
