﻿namespace AuthServer.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
