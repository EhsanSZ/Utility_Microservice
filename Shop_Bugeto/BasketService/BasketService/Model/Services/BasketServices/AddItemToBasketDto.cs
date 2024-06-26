﻿using System;

namespace BasketService.Model.Services
{
    public class AddItemToBasketDto
    {
        public Guid basketId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}
