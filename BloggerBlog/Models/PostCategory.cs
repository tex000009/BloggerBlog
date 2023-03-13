namespace BloggerBlog.Models
{
    public class PostCategory
    {

        public int Id { get; set; }
        public string PostId { get; set; }
        public string CategoryId { get; set; }
        public string Post { get; set; }

        public string Category  { get; set; }
    }
}
