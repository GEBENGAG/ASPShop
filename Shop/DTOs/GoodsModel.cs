﻿namespace Shop.Models
{
    public class GoodsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        
        public CategoryModel Category { get; set; }

    }
}
