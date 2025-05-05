using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PBL3_CofffeeShop.DTO;

namespace PBL3_CofffeeShop.DAL
{
    public class InventoryDAL
    {
        private CoffeeDbContext _db;
        private static InventoryDAL _instance;

        private InventoryDAL()
        {
            _db = new CoffeeDbContext();
        }

        public static InventoryDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryDAL();
                return _instance;
            }
        }



    // Xử lý
        // Lấy tất cả nguyên liệu
        public List<Inventory> GetAllInventory()
        {
            return _db.Inventory.ToList();
        }
        // Lấy nguyên liệu theo ID
        public Inventory GetInventoryByID(string itemID)
        {
            return _db.Inventory.Find(itemID);
        }
        // Lấy nguyên liệu theo tên
        public Inventory GetInventoryByName(string name)
        {
            return _db.Inventory.FirstOrDefault(i => i.Name == name);
        }
        // Lấy nguyên liệu theo danh mục
        public List<Inventory> GetInventoryByCategory(string category)
        {
            if (string.IsNullOrEmpty(category) || category == "Tất cả")
                return GetAllInventory();

            return _db.Inventory.Where(i => i.Category == category).ToList();
        }
        // Lấy các nguyên liệu sắp hết
        public List<Inventory> GetLowStockItems()
        {
            return _db.Inventory.Where(i => i.Quantity <= i.MinimumQuantity).ToList();
        }
        // Lấy các nguyên liệu sắp hết hạn
        public List<Inventory> GetExpiringItems(int days)
        {
            DateTime expiryDate = DateTime.Now.AddDays(days);
            return _db.Inventory
                .Where(i => i.ExpirationDate <= expiryDate && i.ExpirationDate >= DateTime.Now)
                .OrderBy(i => i.ExpirationDate)
                .ToList();
        }
        // Tìm kiếm nguyên liệu
        public List<Inventory> SearchInventory(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return GetAllInventory();

            keyword = keyword.ToLower();
            return _db.Inventory
                .Where(i => i.Name.ToLower().Contains(keyword) ||
                           i.ItemID.ToLower().Contains(keyword))
                .ToList();
        }
        // Lấy danh sách danh mục
        public List<string> GetCategories()
        {
            return _db.Inventory.Select(i => i.Category).Distinct().OrderBy(c => c).ToList();
        }
    //


    //chuc nang
        // Thêm nguyên liệu mới
        public bool AddInventoryItem(Inventory item)
        {
            try
            {
                _db.Inventory.Add(item);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Cập nhật nguyên liệu
        public bool UpdateInventoryItem(Inventory item)
        {
            try
            {
                var existingItem = _db.Inventory.Find(item.ItemID);
                if (existingItem != null)
                {
                    _db.Entry(existingItem).CurrentValues.SetValues(item);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        // Xóa nguyên liệu
        public bool DeleteInventoryItem(string itemID)
        {
            try
            {
                var item = _db.Inventory.Find(itemID);
                if (item != null)
                {
                    _db.Inventory.Remove(item);
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        // Cập nhật số lượng kho
        public bool UpdateInventoryQuantity(string itemID, decimal quantityChange)
        {
            try
            {
                var item = _db.Inventory.Find(itemID);
                if (item != null)
                {
                    item.Quantity += quantityChange;
                    if (item.Quantity < 0)
                        return false;

                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        // Cập nhật số lượng kho trực tiếp
        public bool SetInventoryQuantity(string itemID, decimal newQuantity)
        {
            try
            {
                var item = _db.Inventory.Find(itemID);
                if (item != null)
                {
                    item.Quantity = newQuantity;
                    if (item.Quantity < 0)
                        return false;

                    _db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    //


    //Kiem tra
        // Kiểm tra nguyên liệu có được sử dụng trong menu không
        public bool IsInventoryItemUsedInMenu(string itemID)
        {
            return _db.MenuItemIngredients.Any(m => m.ItemID == itemID);
        }
        // Kiểm tra còn đủ số lượng không
        public bool CheckStockAvailability(string itemID, decimal requiredQuantity)
        {
            var item = GetInventoryByID(itemID);
            return item != null && item.Quantity >= requiredQuantity;
        }
    //
    }
}