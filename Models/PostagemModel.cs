using System;
namespace Blog.Models
{
    public class PostagemModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
    }
}
