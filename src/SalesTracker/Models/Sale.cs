﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Sales")]
    public class Sale
    {
        public Sale()
        {
            this.Inventory = new HashSet<Inventory>();
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int SaleId { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}