using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CofffeeShop.DAL;
using PBL3_CofffeeShop.DTO;

namespace PBL3_CofffeeShop.BLL
{
    public class InventoryBLL
    {
        private static InventoryBLL _instance;

        public static InventoryBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryBLL();
                return _instance;
            }
        }

        private InventoryBLL() { }

        // Lấy tất cả nguyên liệu
        public List<Inventory> GetAllInventory()
        {
            return InventoryDAL.Instance.GetAllInventory();
        }

        // Lấy nguyên liệu theo ID
        public Inventory GetInventoryByID(string itemID)
        {
            return InventoryDAL.Instance.GetInventoryByID(itemID);
        }

        // Lấy nguyên liệu theo danh mục
        public List<Inventory> GetInventoryByCategory(string category)
        {
            return InventoryDAL.Instance.GetInventoryByCategory(category);
        }

        // Lấy nguyên liệu sắp hết
        public List<Inventory> GetLowStockItems()
        {
            return InventoryDAL.Instance.GetLowStockItems();
        }

        // Lấy nguyên liệu sắp hết hạn
        public List<Inventory> GetExpiringItems(int days = 7)
        {
            return InventoryDAL.Instance.GetExpiringItems(days);
        }

        // Thêm nguyên liệu mới
        public bool AddInventoryItem(Inventory item)
        {
            // Validate
            if (string.IsNullOrEmpty(item.Name))
                throw new Exception("Tên nguyên liệu không được để trống");

            if (item.Quantity < 0)
                throw new Exception("Số lượng không được âm");

            if (item.MinimumQuantity < 0)
                throw new Exception("Số lượng tối thiểu không được âm");

            if (item.CostPrice < 0)
                throw new Exception("Giá nhập không được âm");

            // Tạo ID nếu chưa có
            if (string.IsNullOrEmpty(item.ItemID))
                item.ItemID = GenerateItemID();

            return InventoryDAL.Instance.AddInventoryItem(item);
        }

        // Cập nhật nguyên liệu
        public bool UpdateInventoryItem(Inventory item)
        {
            // Validate
            if (string.IsNullOrEmpty(item.ItemID))
                throw new Exception("Mã nguyên liệu không được để trống");

            if (string.IsNullOrEmpty(item.Name))
                throw new Exception("Tên nguyên liệu không được để trống");

            if (item.Quantity < 0)
                throw new Exception("Số lượng không được âm");

            if (item.MinimumQuantity < 0)
                throw new Exception("Số lượng tối thiểu không được âm");

            if (item.CostPrice < 0)
                throw new Exception("Giá nhập không được âm");

            return InventoryDAL.Instance.UpdateInventoryItem(item);
        }

        // Xóa nguyên liệu
        public bool DeleteInventoryItem(string itemID)
        {
            // Kiểm tra xem nguyên liệu có đang được sử dụng không
            if (InventoryDAL.Instance.IsInventoryItemUsedInMenu(itemID))
                throw new Exception("Không thể xóa nguyên liệu đang được sử dụng trong menu");

            return InventoryDAL.Instance.DeleteInventoryItem(itemID);
        }

        // Tìm kiếm nguyên liệu
        public List<Inventory> SearchInventory(string keyword)
        {
            return InventoryDAL.Instance.SearchInventory(keyword);
        }

        // Lấy danh sách category
        public List<string> GetCategories()
        {
            var categories = InventoryDAL.Instance.GetCategories();
            categories.Insert(0, "Tất cả");
            return categories;
        }

        // Tạo ID mới
        private string GenerateItemID()
        {
            var items = GetAllInventory();
            if (items.Count == 0)
                return "INV001";

            var maxId = items
                .Where(i => i.ItemID.StartsWith("INV"))
                .Select(i => i.ItemID.Substring(3))
                .Select(id => int.TryParse(id, out int num) ? num : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"INV{(maxId + 1):D3}";
        }

        // Kiểm tra tồn kho
        public bool CheckStockAvailability(string itemID, decimal requiredQuantity)
        {
            var item = InventoryDAL.Instance.GetInventoryByID(itemID);
            return item != null && item.Quantity >= requiredQuantity;
        }

        // Helpers
        public static string GetStockStatus(Inventory item)
        {
            if (item.Quantity == 0)
                return "Hết hàng";
            else if (item.Quantity <= item.MinimumQuantity)
                return "Sắp hết";
            else
                return "Còn hàng";
        }

        public static int GetDaysUntilExpiration(DateTime expirationDate)
        {
            return (expirationDate - DateTime.Now).Days;
        }

        public static string FormatCurrency(decimal amount)
        {
            return string.Format("{0:N0}đ", amount);
        }
    }
}