using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PBL3_CofffeeShop.DTO;

namespace PBL3_CofffeeShop.DAL
{
    public class InventoryTransactionDAL
    {
        private CoffeeDbContext _db;
        private static InventoryTransactionDAL _instance;

        private InventoryTransactionDAL()
        {
            _db = new CoffeeDbContext();
        }

        public static InventoryTransactionDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InventoryTransactionDAL();
                return _instance;
            }
        }

    // Xu ly
        // Lấy tất cả giao dịch
        public List<InventoryTransaction> GetAllTransactions()
        {
            return _db.InventoryTransactions
                .Include(t => t.Inventory)
                .Include(t => t.User)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }

        // Lấy giao dịch theo khoảng thời gian
        public List<InventoryTransaction> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _db.InventoryTransactions
                .Include(t => t.Inventory)
                .Include(t => t.User)
                .Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }

        // Lấy giao dịch theo loại
        public List<InventoryTransaction> GetTransactionsByType(string type)
        {
            if (type == "Tất cả")
                return GetAllTransactions();

            return _db.InventoryTransactions
                .Include(t => t.Inventory)
                .Include(t => t.User)
                .Where(t => t.Type == type)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }

        // Lấy giao dịch theo nguyên liệu
        public List<InventoryTransaction> GetTransactionsByItem(string itemID)
        {
            return _db.InventoryTransactions
                .Include(t => t.Inventory)
                .Include(t => t.User)
                .Where(t => t.ItemID == itemID)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }
    //

    // Chuc nang
        // Nhập kho
        public bool StockIn(string itemID, decimal quantity, string userID, decimal price = 0, string note = "")
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Tạo giao dịch nhập kho
                    var transaction = new InventoryTransaction
                    {
                        TransactionID = GenerateTransactionID(),
                        ItemID = itemID,
                        Quantity = quantity,
                        Type = "Nhập",
                        TransactionDate = DateTime.Now,
                        UserID = userID,
                        Note = note
                    };

                    _db.InventoryTransactions.Add(transaction);

                    // Cập nhật số lượng và giá (nếu có) trong kho
                    var inventory = _db.Inventory.Find(itemID);
                    if (inventory != null)
                    {
                        inventory.Quantity += quantity;

                        // Cập nhật giá nếu có
                        if (price > 0)
                        {
                            inventory.CostPrice = price;
                        }
                    }

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }

        // Xuất kho
        public bool StockOut(string itemID, decimal quantity, string userID, string orderID = null, string note = "")
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Kiểm tra số lượng tồn kho
                    var inventory = _db.Inventory.Find(itemID);
                    if (inventory == null || inventory.Quantity < quantity)
                        return false;

                    // Tạo giao dịch xuất kho
                    var transaction = new InventoryTransaction
                    {
                        TransactionID = GenerateTransactionID(),
                        ItemID = itemID,
                        Quantity = quantity,
                        Type = "Xuất",
                        TransactionDate = DateTime.Now,
                        UserID = userID,
                        OrderID = orderID,
                        Note = note
                    };

                    _db.InventoryTransactions.Add(transaction);

                    // Cập nhật số lượng trong kho
                    inventory.Quantity -= quantity;

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }

        // Điều chỉnh kho
        public bool AdjustStock(string itemID, decimal newQuantity, string userID, string note = "")
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    // Lấy thông tin hiện tại
                    var inventory = _db.Inventory.Find(itemID);
                    if (inventory == null)
                        return false;

                    // Tính toán sự thay đổi
                    decimal difference = newQuantity - inventory.Quantity;
                    if (difference == 0)
                        return true; // Không có thay đổi

                    // Xác định loại điều chỉnh
                    string adjustmentType = difference > 0 ? "Điều chỉnh tăng" : "Điều chỉnh giảm";

                    // Tạo giao dịch điều chỉnh
                    var transaction = new InventoryTransaction
                    {
                        TransactionID = GenerateTransactionID(),
                        ItemID = itemID,
                        Quantity = Math.Abs(difference),
                        Type = adjustmentType,
                        TransactionDate = DateTime.Now,
                        UserID = userID,
                        Note = note
                    };

                    _db.InventoryTransactions.Add(transaction);

                    // Cập nhật số lượng
                    inventory.Quantity = newQuantity;

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }

        // Thêm nhiều giao dịch (cho phiếu nhập kho)
        public bool AddTransactionBatch(List<InventoryTransaction> transactions)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    foreach (var transaction in transactions)
                    {
                        if (string.IsNullOrEmpty(transaction.TransactionID))
                            transaction.TransactionID = GenerateTransactionID();

                        if (transaction.TransactionDate == default)
                            transaction.TransactionDate = DateTime.Now;

                        _db.InventoryTransactions.Add(transaction);

                        // Cập nhật số lượng trong kho
                        var inventory = _db.Inventory.Find(transaction.ItemID);
                        if (inventory != null)
                        {
                            if (transaction.Type == "Nhập")
                            {
                                inventory.Quantity += transaction.Quantity;
                            }
                            else if (transaction.Type == "Xuất")
                            {
                                if (inventory.Quantity < transaction.Quantity)
                                    throw new Exception($"Không đủ số lượng {inventory.Name} trong kho");

                                inventory.Quantity -= transaction.Quantity;
                            }
                            else if (transaction.Type == "Điều chỉnh tăng")
                            {
                                inventory.Quantity += transaction.Quantity;
                            }
                            else if (transaction.Type == "Điều chỉnh giảm")
                            {
                                if (inventory.Quantity < transaction.Quantity)
                                    throw new Exception($"Không đủ số lượng {inventory.Name} trong kho");

                                inventory.Quantity -= transaction.Quantity;
                            }
                        }
                    }

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }

        // Thực hiện kiểm kê kho
        public bool PerformInventoryCheck(string userId, Dictionary<string, decimal> actualQuantities, string note)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    foreach (var item in actualQuantities)
                    {
                        string itemId = item.Key;
                        decimal actualQty = item.Value;

                        var inventoryItem = _db.Inventory.Find(itemId);
                        if (inventoryItem == null) continue;

                        decimal difference = actualQty - inventoryItem.Quantity;

                        if (difference != 0)
                        {
                            // Tạo giao dịch điều chỉnh
                            var transaction = new InventoryTransaction
                            {
                                TransactionID = GenerateTransactionID(),
                                ItemID = itemId,
                                Quantity = Math.Abs(difference),
                                Type = difference > 0 ? "Điều chỉnh tăng" : "Điều chỉnh giảm",
                                TransactionDate = DateTime.Now,
                                UserID = userId,
                                Note = $"Kiểm kê: {note}"
                            };

                            _db.InventoryTransactions.Add(transaction);

                            // Cập nhật số lượng thực tế
                            inventoryItem.Quantity = actualQty;
                        }
                    }

                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
    //

    // phuongthuc hotro
        // Tạo mã giao dịch tự động
        private string GenerateTransactionID()
        {
            string prefix = "TRX" + DateTime.Now.ToString("yyyyMMdd");
            int count = _db.InventoryTransactions
                .Count(t => t.TransactionID.StartsWith(prefix)) + 1;

            return prefix + count.ToString("D4");
        }
    //
    }
}