﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CofffeeShop.DTO
{
    [Table("InventoryTransactions")]
    public class InventoryTransaction
    {
        [Key]
        [StringLength(20)]
        public string TransactionID { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        [StringLength(10)]
        public string ItemID { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; } // "Nhập", "Xuất", "Điều chỉnh"

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [ForeignKey("User")]
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(20)]
        public string OrderID { get; set; } // Nếu liên quan đến Order

        [StringLength(500)]
        public string Note { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual User User { get; set; }
    }
}