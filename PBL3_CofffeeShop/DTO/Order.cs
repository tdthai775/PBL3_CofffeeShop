﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_CofffeeShop.DTO
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            BaristaQueues = new HashSet<BaristaQueue>();
            CreatedAt = DateTime.Now;
            Status = "Pending";
            DiscountAmount = 0;
        }

        [Key]
        [StringLength(20)]
        public string OrderID { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // Pending, In Progress, Completed

        [Required]
        [Range(1, 9999)]
        public int CardNumber { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public decimal DiscountAmount { get; set; }

        [Required]
        public decimal FinalAmount { get; set; }

        [ForeignKey("User")]
        [StringLength(10)]
        public string UserID { get; set; }

        [ForeignKey("Discount")]
        [StringLength(10)]
        public string DiscountID { get; set; }

        public virtual User User { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<BaristaQueue> BaristaQueues { get; set; }
    }
}