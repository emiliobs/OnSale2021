﻿using System.ComponentModel.DataAnnotations;

namespace Onsale.Common.Entities
{
    public class OrdenDetail
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public decimal Value => (decimal)Quantity * Price;

    }
}
