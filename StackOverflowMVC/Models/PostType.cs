﻿using Microsoft.EntityFrameworkCore;

namespace StackOverflowMVC.Models
{
    [Index(nameof(Type))]
    public class PostType
    {
        public int Id { get; set; }

        public string Type { get; set; } = null!;
    }
}
