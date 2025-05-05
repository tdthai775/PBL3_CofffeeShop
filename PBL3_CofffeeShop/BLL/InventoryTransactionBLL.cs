using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CofffeeShop.DAL;
using PBL3_CofffeeShop.DTO.ViewModel;
using PBL3_CofffeeShop.DTO;

namespace PBL3_CofffeeShop.BLL
{
    public class InventoryTransactionBLL
    {
        private static InventoryTransactionBLL _instance;
        private InventoryTransactionDAL _transactionDAL;
        private InventoryDAL _inventoryDAL;

        private InventoryTransactionBLL()
        {
            _transactionDAL = InventoryTransactionDAL.Instance;
            _inventoryDAL = InventoryDAL.Instance;
        }

        public static InventoryTransactionBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryTransactionBLL();
                return _instance;
            }
        }

    // XuLy
        // Lấy tất cả giao dịch
        public List<TransactionDisplayDTO> GetAllTransactions()
        {
            var transactions = _transactionDAL.GetAllTransactions();
            return ConvertToTransactionDTO(transactions);
        }

        // Lấy giao dịch theo khoảng thời gian
        public List<TransactionDisplayDTO> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            var transactions = _transactionDAL.GetTransactionsByDateRange(startDate, endDate);
            return ConvertToTransactionDTO(transactions);
        }

        // Lấy giao dịch theo loại
        public List<TransactionDisplayDTO> GetTransactionsByType(string type)
        {
            var transactions = _transactionDAL.GetTransactionsByType(type);
            return ConvertToTransactionDTO(transactions);
        }

        // Lấy giao dịch theo mã nguyên liệu
        public List<TransactionDisplayDTO> GetTransactionsByItem(string itemID)
        {
            var transactions = _transactionDAL.GetTransactionsByItem(itemID);
            return ConvertToTransactionDTO(transactions);
        }

        // Lấy loại giao dịch
        public List<string> GetTransactionTypes()
        {
            return new List<string>
            {
                "Tất cả", "Nhập", "Xuất", "Điều chỉnh tăng", "Điều chỉnh giảm"
            };
        }
        //

    // ChucNang
        // Nhập kho
        public bool ImportInventory(ImportInventoryDTO importDTO)
        {
            // Kiểm tra dữ liệu
            if (importDTO.Quantity <= 0)
                throw new Exception("Số lượng nhập phải lớn hơn 0");

            if (importDTO.Price < 0)
                throw new Exception("Giá nhập không được âm");

            if (string.IsNullOrEmpty(importDTO.UserID))
                throw new Exception("Người nhập không được trống");

            // Kiểm tra xem nguyên liệu đã tồn tại chưa
            var existingItem = _inventoryDAL.GetInventoryByID(importDTO.ItemID);

            // Nếu nguyên liệu chưa tồn tại, tạo mới
            if (existingItem == null)
            {
                if (string.IsNullOrEmpty(importDTO.Name))
                    throw new Exception("Tên nguyên liệu không được trống");

                var newItem = new Inventory
                {
                    ItemID = string.IsNullOrEmpty(importDTO.ItemID) ? GenerateItemID() : importDTO.ItemID,
                    Name = importDTO.Name,
                    Category = importDTO.Category,
                    Quantity = 0, // Sẽ được cập nhật trong StockIn
                    MinimumQuantity = 0, // Giá trị mặc định
                    Unit = importDTO.Unit,
                    ExpirationDate = importDTO.ExpirationDate,
                    CostPrice = importDTO.Price
                };

                bool created = _inventoryDAL.AddInventoryItem(newItem);
                if (!created)
                    return false;

                importDTO.ItemID = newItem.ItemID;
            }

            // Thực hiện nhập kho
            return _transactionDAL.StockIn(
                importDTO.ItemID,
                importDTO.Quantity,
                importDTO.UserID,
                importDTO.Price,
                importDTO.Note
            );
        }

        // Xuất kho
        public bool ExportInventory(string itemID, decimal quantity, string userID, string orderID = null, string note = "")
        {
            // Kiểm tra dữ liệu
            if (quantity <= 0)
                throw new Exception("Số lượng xuất phải lớn hơn 0");

            if (string.IsNullOrEmpty(userID))
                throw new Exception("Người xuất không được trống");

            // Kiểm tra tồn kho
            var item = _inventoryDAL.GetInventoryByID(itemID);
            if (item == null)
                throw new Exception("Không tìm thấy nguyên liệu");

            if (item.Quantity < quantity)
                throw new Exception($"Số lượng trong kho không đủ. Hiện có: {item.Quantity} {item.Unit}");

            // Thực hiện xuất kho
            return _transactionDAL.StockOut(itemID, quantity, userID, orderID, note);
        }

        // Điều chỉnh kho
        public bool AdjustInventory(string itemID, decimal newQuantity, string userID, string note = "")
        {
            // Kiểm tra dữ liệu
            if (newQuantity < 0)
                throw new Exception("Số lượng không được âm");

            if (string.IsNullOrEmpty(userID))
                throw new Exception("Người điều chỉnh không được trống");

            // Kiểm tra tồn tại
            var item = _inventoryDAL.GetInventoryByID(itemID);
            if (item == null)
                throw new Exception("Không tìm thấy nguyên liệu");

            // Thực hiện điều chỉnh
            return _transactionDAL.AdjustStock(itemID, newQuantity, userID, note);
        }

        // Nhập kho nhiều mục
        public bool ImportInventoryBatch(List<ImportInventoryDTO> importItems, string userID, string note = "")
        {
            if (importItems == null || importItems.Count == 0)
                throw new Exception("Danh sách nhập kho không được trống");

            if (string.IsNullOrEmpty(userID))
                throw new Exception("Người nhập không được trống");

            var transactions = new List<InventoryTransaction>();

            foreach (var item in importItems)
            {
                // Kiểm tra dữ liệu
                if (item.Quantity <= 0)
                    throw new Exception($"Nguyên liệu {item.Name}: Số lượng nhập phải lớn hơn 0");

                // Kiểm tra xem nguyên liệu đã tồn tại chưa
                var existingItem = _inventoryDAL.GetInventoryByID(item.ItemID);

                // Nếu nguyên liệu chưa tồn tại, tạo mới
                if (existingItem == null)
                {
                    if (string.IsNullOrEmpty(item.Name))
                        throw new Exception("Tên nguyên liệu không được trống");

                    var newItem = new Inventory
                    {
                        ItemID = string.IsNullOrEmpty(item.ItemID) ? GenerateItemID() : item.ItemID,
                        Name = item.Name,
                        Category = item.Category,
                        Quantity = 0,
                        MinimumQuantity = 0,
                        Unit = item.Unit,
                        ExpirationDate = item.ExpirationDate,
                        CostPrice = item.Price
                    };

                    bool created = _inventoryDAL.AddInventoryItem(newItem);
                    if (!created)
                        return false;

                    item.ItemID = newItem.ItemID;
                }

                // Tạo giao dịch
                var transaction = new InventoryTransaction
                {
                    ItemID = item.ItemID,
                    Quantity = item.Quantity,
                    Type = "Nhập",
                    TransactionDate = DateTime.Now,
                    UserID = userID,
                    Note = note
                };

                transactions.Add(transaction);
            }

            // Thực hiện nhập kho hàng loạt
            return _transactionDAL.AddTransactionBatch(transactions);
        }
        //

    // Kiem Kho
        // Lấy danh sách mục kiểm kê
        public List<InventoryCheckItemDTO> GetInventoryForChecking(string category = null)
        {
            List<Inventory> items;

            if (string.IsNullOrEmpty(category) || category == "Tất cả")
                items = _inventoryDAL.GetAllInventory();
            else
                items = _inventoryDAL.GetInventoryByCategory(category);

            return items.Select(i => new InventoryCheckItemDTO
            {
                ItemID = i.ItemID,
                Name = i.Name,
                Category = i.Category,
                SystemQuantity = i.Quantity,
                ActualQuantity = i.Quantity, // Mặc định bằng số lượng trong hệ thống
                Unit = i.Unit
            }).ToList();
        }

        // Thực hiện kiểm kê kho
        public bool PerformInventoryCheck(List<InventoryCheckItemDTO> checkItems, string userID, string note)
        {
            if (string.IsNullOrEmpty(userID))
                throw new Exception("Người kiểm kê không được trống");

            if (checkItems == null || checkItems.Count == 0)
                throw new Exception("Danh sách kiểm kê không được trống");

            var actualQuantities = checkItems.ToDictionary(
                item => item.ItemID,
                item => item.ActualQuantity
            );

            return _transactionDAL.PerformInventoryCheck(userID, actualQuantities, note);
        }

        // Lấy chênh lệch kiểm kê
        public List<InventoryCheckItemDTO> GetInventoryDiscrepancies(List<InventoryCheckItemDTO> checkItems)
        {
            return checkItems.Where(i => i.Difference != 0).ToList();
        }
    //



    // ThongKe
        // Thống kê số lượng giao dịch theo loại
        public Dictionary<string, int> GetTransactionCountByType(DateTime startDate, DateTime endDate)
        {
            var transactions = _transactionDAL.GetTransactionsByDateRange(startDate, endDate);

            return transactions
                .GroupBy(t => t.Type)
                .ToDictionary(
                    g => g.Key,
                    g => g.Count()
                );
        }

        // Thống kê giá trị giao dịch nhập theo nguyên liệu
        public Dictionary<string, decimal> GetImportValueByItem(DateTime startDate, DateTime endDate)
        {
            var transactions = _transactionDAL.GetTransactionsByDateRange(startDate, endDate)
                .Where(t => t.Type == "Nhập");

            return transactions
                .GroupBy(t => t.ItemID)
                .ToDictionary(
                    g => g.First().Inventory?.Name ?? g.Key,
                    g => g.Sum(t => t.Quantity * (t.Inventory?.CostPrice ?? 0))
                );
        }

        // Thống kê giá trị giao dịch xuất theo nguyên liệu
        public Dictionary<string, decimal> GetExportValueByItem(DateTime startDate, DateTime endDate)
        {
            var transactions = _transactionDAL.GetTransactionsByDateRange(startDate, endDate)
                .Where(t => t.Type == "Xuất");

            return transactions
                .GroupBy(t => t.ItemID)
                .ToDictionary(
                    g => g.First().Inventory?.Name ?? g.Key,
                    g => g.Sum(t => t.Quantity * (t.Inventory?.CostPrice ?? 0))
                );
        }
    //


    // Ho tro
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

        // Chuyển đổi giao dịch thành DTO
        private TransactionDisplayDTO ConvertToTransactionDTO(InventoryTransaction transaction)
        {
            return new TransactionDisplayDTO
            {
                TransactionID = transaction.TransactionID,
                TransactionDate = transaction.TransactionDate,
                ItemID = transaction.ItemID,
                ItemName = transaction.Inventory?.Name ?? "Không xác định",
                Category = transaction.Inventory?.Category ?? "Không xác định",
                Quantity = transaction.Quantity,
                Unit = transaction.Inventory?.Unit ?? "",
                Type = transaction.Type,
                UserID = transaction.UserID,
                UserName = transaction.User?.UserName ?? "Không xác định",
                Note = transaction.Note
            };
        }

        // Chuyển đổi danh sách giao dịch thành danh sách DTO
        private List<TransactionDisplayDTO> ConvertToTransactionDTO(List<InventoryTransaction> transactions)
        {
            return transactions.Select(t => ConvertToTransactionDTO(t)).ToList();
        }
    //
    }
}
