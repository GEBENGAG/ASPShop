namespace Shop.Models
{
    public class GoodsViewModel
    {
       
    
      public   List<GoodsModel> Goods = new List<GoodsModel> {
            new GoodsModel { Name ="Chocolate", Id=1, Price = 100, Category = new CategoryModel{ Name ="Sweets", Id = 1 }   },
            new GoodsModel { Name ="Biscuits", Id=2, Price = 150, Category = new CategoryModel {  Name ="Sweets", Id = 1 }  },
            new GoodsModel { Name ="Rice", Id=3, Price = 70, Category = new CategoryModel { Name = "Grains", Id = 2 } },
            new GoodsModel { Name ="Buckwheat", Id=4, Price = 30, Category = new CategoryModel { Name = "Grains", Id = 2 } },
            new GoodsModel { Name ="Banana", Id=5, Price = 100, Category = new CategoryModel { Name = "Fruits", Id=3 } },
            new GoodsModel { Name ="Apple", Id=6, Price = 150, Category = new CategoryModel { Name = "Fruits", Id=3 }  }
        };
    }
}
