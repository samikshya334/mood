﻿using System.ComponentModel.DataAnnotations;

namespace Thrift1.ViewModel
{
    public class DeleteViewModel
    {
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
