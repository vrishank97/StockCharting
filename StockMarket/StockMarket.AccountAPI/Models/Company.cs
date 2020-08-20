﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.AccountAPI.Models
{
    [Table("Company")]
    public class Company
    {
       [Key]
       [StringLength(30)]
        public string CompanyCode { get; set; }
        [Required]
        [StringLength(25)]
        public string CompanyName { get; set; }
        [StringLength(30)]
        public string CEO { get; set; }
        public IEnumerable<StockPrice> StockPrices { get; set; } //Navigation Prop
    }
}
