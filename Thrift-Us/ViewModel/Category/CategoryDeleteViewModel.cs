﻿using System.ComponentModel.DataAnnotations;

namespace Thrift_Us.ViewModel.Category
{
    public class CategoryDeleteViewModel
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
