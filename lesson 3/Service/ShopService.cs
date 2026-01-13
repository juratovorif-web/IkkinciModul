using lesson_3.Models;
namespace lesson_3.Service;

public class ShopService
{
    List<Shop> Shops = new List<Shop>();

    public Guid AddShop(Shop shop)   // Create
    {
        shop.ShopId = Guid.NewGuid();
        Shops.Add(shop);
        return shop.ShopId;
    }

    public Shop? GetByShopId(Guid shopId)    // Read
    {
        foreach (Shop shop in Shops)
        {
            if(shop.ShopId == shopId)
            {
                return shop;
            }
        }
        return null;
    }

    public bool DeleteShop(Guid shopId)   // Delete
    {
        var shop = GetByShopId(shopId);
        if(shop ==  null)
        {
            return false;
        }
        Shops.Remove(shop);
        return true;
    }

    public List<Shop> GetAllShops()
    {
        return Shops;
    }

    public bool UpdateShop(Guid shopId, Shop newShop)    // Update
    {
        var shop = GetByShopId(shopId);
        if(shop == null)
        {
            return false;
        }
        shop.NameShop = newShop.NameShop;
        shop.CountShop = newShop.CountShop;
        shop.AddressShop = newShop.AddressShop;
        shop.DescriptionShop = newShop.DescriptionShop;

        return true;

            
    }
}
