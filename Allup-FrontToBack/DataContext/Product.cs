namespace Allup_FrontToBack.DataContext
{
    public class Product
    {
        public int id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool InStock { get; set; } = true;
        public string? Code { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; } = [];
        public required string CoverImageUrl { get; set; }
        public required string HoverImageUrl { get; set; }
        public List<ProductTag>? ProductTags { get; set; } = [];
    }

    public class ProductImage
    {
        public int Id { get; set; }
        public required string ImageUrl { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<ProductTag>? ProductTags { get; set; } = [];
    }

    public class ProductTag
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
