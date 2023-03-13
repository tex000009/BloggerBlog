﻿namespace BloggerBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
