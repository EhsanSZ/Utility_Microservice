﻿using BasketService.Infrastructure.Contexts;
using System;

namespace BasketService.Model.Services.ProductServices
{
    public interface IProductService
    {
        bool UpdateProductName(Guid ProductId, string productName);
    }
    public class ProductService : IProductService
    {
        private readonly BasketDataBaseContext context;

        public ProductService(BasketDataBaseContext context)
        {
            this.context = context;
        }

        public bool UpdateProductName(Guid ProductId, string productName)
        {
            var product = context.Products.Find(ProductId);
            if (product is not null)
            {
                product.ProductName = productName;
                context.SaveChanges();
                
            }
            return true;

        }
    }
}
