using Core.Concretes.Entities;
using Utils.Generics;

namespace Core.Abstracts.IRepositories
{
    public interface IProductRepository : IRepository<Product> { }
    public interface IProductAttributeRepository : IRepository<ProductAttribute> { }
    public interface IProductImageRepository : IRepository<ProductImage> { }
    public interface IProductReviewRepository : IRepository<ProductReview> { }
    public interface ISubcategoryRepository : IRepository<Subcategory> { }
    public interface ICategoryRepository : IRepository<Category> { }
    public interface ICartItemRepository : IRepository<CartItem> { }
    public interface ICartRepository : IRepository<Cart> { }
    public interface IBrandRepository : IRepository<Brand> { }
    

}
