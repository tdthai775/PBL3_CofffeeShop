using System;
using System.Collections.Generic;
using System.Linq;
using PBL3_CofffeeShop.DAL;
using PBL3_CofffeeShop.DTO;
using PBL3_CofffeeShop.DTO.ViewModel;

namespace PBL3_CofffeeShop.BLL
{
    public class InventoryBLL
    {
        private static InventoryBLL _instance;
        private InventoryDAL _inventoryDAL;

        private InventoryBLL()
        {
            _inventoryDAL = InventoryDAL.Instance;
        }

        public static InventoryBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryBLL();
                return _instance;
            }
        }


    //Xu ly
        // Lấy tất cả nguyên liệu
        public List<InventoryDisplayDTO> GetAllInventory()
        {
            var items = _inventoryDAL.GetAllInventory();
            return ConvertToDisplayDTO(items);
        }

        // Lấy nguyên liệu theo ID
        public InventoryDisplayDTO GetInventoryByID(string itemID)
        {
            var item = _inventoryDAL.GetInventoryByID(itemID);
            if (item == null)
                return null;

            return ConvertToDisplayDTO(item);
        }

        // Lấy nguyên liệu theo danh mục
        public List<InventoryDisplayDTO> GetInventoryByCategory(string category)
        {
            var items = _inventoryDAL.GetInventoryByCategory(category);
            return ConvertToDisplayDTO(items);
        }

        // Lấy các nguyên liệu sắp hết
        public List<InventoryDisplayDTO> GetLowStockItems()
        {
            var items = _inventoryDAL.GetLowStockItems();
            return ConvertToDisplayDTO(items);
        }

        // Lấy các nguyên liệu sắp hết hạn
        public List<InventoryDisplayDTO> GetExpiringItems(int days = 7)
        {
            var items = _inventoryDAL.GetExpiringItems(days);
            return ConvertToDisplayDTO(items);
        }

        // Tìm kiếm nguyên liệu
        public List<InventoryDisplayDTO> SearchInventory(string keyword)
        {
            var items = _inventoryDAL.SearchInventory(keyword);
            return ConvertToDisplayDTO(items);
        }

        // Lấy danh sách danh mục
        public List<string> GetCategories()
        {
            var categories = _inventoryDAL.GetCategories();
            if (!categories.Contains("Tất cả"))
                categories.Insert(0, "Tất cả");
            return categories;
        }

        // Lấy số lượng nguyên liệu còn ít
        public int GetLowStockCount()
        {
            return _inventoryDAL.GetLowStockItems().Count;
        }

        // Lấy số lượng nguyên liệu sắp hết hạn
        public int GetExpiringItemsCount(int days = 7)
        {
            return _inventoryDAL.GetExpiringItems(days).Count;
        }

        // Lấy tổng số lượng nguyên liệu
        public int GetTotalInventoryCount()
        {
            return _inventoryDAL.GetAllInventory().Count;
        }

        // Lấy tổng giá trị kho
        public decimal GetTotalInventoryValue()
        {
            var items = _inventoryDAL.GetAllInventory();
            return items.Sum(i => i.Quantity * i.CostPrice);
        }
    //


    //Chuc nang
        // Thêm nguyên liệu mới
        public bool AddInventoryItem(string name, string category, decimal quantity,
            decimal minimumQuantity, string unit, DateTime expirationDate, decimal costPrice)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(name))
                throw new Exception("Tên nguyên liệu không được để trống");

            if (quantity < 0)
                throw new Exception("Số lượng không được âm");

            if (minimumQuantity < 0)
                throw new Exception("Số lượng tối thiểu không được âm");

            if (costPrice < 0)
                throw new Exception("Giá nhập không được âm");

            var item = new Inventory
            {
                ItemID = GenerateItemID(),
                Name = name,
                Category = category,
                Quantity = quantity,
                MinimumQuantity = minimumQuantity,
                Unit = unit,
                ExpirationDate = expirationDate,
                CostPrice = costPrice
            };

            return _inventoryDAL.AddInventoryItem(item);
        }

        // Cập nhật nguyên liệu
        public bool UpdateInventoryItem(string itemID, string name, string category, decimal quantity,
            decimal minimumQuantity, string unit, DateTime expirationDate, decimal costPrice)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(itemID))
                throw new Exception("Mã nguyên liệu không được để trống");

            if (string.IsNullOrEmpty(name))
                throw new Exception("Tên nguyên liệu không được để trống");

            if (quantity < 0)
                throw new Exception("Số lượng không được âm");

            if (minimumQuantity < 0)
                throw new Exception("Số lượng tối thiểu không được âm");

            if (costPrice < 0)
                throw new Exception("Giá nhập không được âm");

            var item = new Inventory
            {
                ItemID = itemID,
                Name = name,
                Category = category,
                Quantity = quantity,
                MinimumQuantity = minimumQuantity,
                Unit = unit,
                ExpirationDate = expirationDate,
                CostPrice = costPrice
            };

            return _inventoryDAL.UpdateInventoryItem(item);
        }

        // Xóa nguyên liệu
        public bool DeleteInventoryItem(string itemID)
        {
            // Kiểm tra xem nguyên liệu có đang được sử dụng không
            if (_inventoryDAL.IsInventoryItemUsedInMenu(itemID))
                throw new Exception("Không thể xóa nguyên liệu đang được sử dụng trong menu");

            return _inventoryDAL.DeleteInventoryItem(itemID);
        }
    //


    // Kiem tra
        // Kiểm tra tồn kho
        public bool CheckStockAvailability(string itemID, decimal requiredQuantity)
        {
            var item = _inventoryDAL.GetInventoryByID(itemID);
            return item != null && item.Quantity >= requiredQuantity;
        }
    //


    // BaoCao va ThongKe
        // Lấy giá trị kho theo danh mục
        public Dictionary<string, decimal> GetInventoryValueByCategory()
        {
            var items = _inventoryDAL.GetAllInventory();
            return items
                .GroupBy(i => i.Category)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(i => i.Quantity * i.CostPrice)
                );
        }

        // Lấy số lượng mục theo danh mục
        public Dictionary<string, int> GetInventoryCountByCategory()
        {
            var items = _inventoryDAL.GetAllInventory();
            return items
                .GroupBy(i => i.Category)
                .ToDictionary(
                    g => g.Key,
                    g => g.Count()
                );
        }
        // Lấy danh sách đơn vị đo phổ biến
        public List<string> GetCommonUnits()
        {
            return new List<string>
            {
                "Kg", "g", "L", "ml", "Gói", "Hộp", "Chai", "Lon", "Túi", "Cái", "Thùng"
            };
        }
    //

    // Phuong thuc ho tro
        // Tạo mã nguyên liệu mới
        private string GenerateItemID()
        {
            var items = _inventoryDAL.GetAllInventory();
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

        // Định dạng số tiền
        public static string FormatCurrency(decimal amount)
        {
            return string.Format("{0:#,##0} VNĐ", amount);
        }

        // Lấy trạng thái tồn kho
        public static string GetStockStatus(Inventory item)
        {
            if (item.Quantity == 0)
                return "Hết hàng";
            else if (item.Quantity <= item.MinimumQuantity)
                return "Sắp hết";
            else
                return "Còn hàng";
        }

        // Lấy số ngày còn hạn
        public static int GetDaysUntilExpiration(DateTime expirationDate)
        {
            return (expirationDate - DateTime.Now).Days;
        }
    //

    //Chuyen doi
        // Chuyển đổi đối tượng Inventory thành DTO
        private InventoryDisplayDTO ConvertToDisplayDTO(Inventory item)
        {
            return new InventoryDisplayDTO
            {
                ItemID = item.ItemID,
                Name = item.Name,
                Category = item.Category,
                Quantity = item.Quantity,
                MinimumQuantity = item.MinimumQuantity,
                Unit = item.Unit,
                ExpirationDate = item.ExpirationDate,
                CostPrice = item.CostPrice
            };
        }

        // Chuyển đổi danh sách Inventory thành danh sách DTO
        private List<InventoryDisplayDTO> ConvertToDisplayDTO(List<Inventory> items)
        {
            return items.Select(i => ConvertToDisplayDTO(i)).ToList();
        }
    //

    }
}