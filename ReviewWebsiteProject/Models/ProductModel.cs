﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public ProductModel(int id, string name, string description, string review, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Review = review;
            Image = image;
        }
    }
}
