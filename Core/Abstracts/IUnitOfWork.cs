using Core.Abstracts.IRepositories;
using Utils.Responses;

namespace Core.Abstracts
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IProductRepository ProductRepository {  get; }
        IProductImageRepository ProductImageRepository { get; }
        IProductAttributeRepository ProductAttributeRepository { get; }
        IProductReviewRepository ProductReviewRepository { get; }
        ISubcategoryRepository SubcategoryRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        IBrandRepository BrandRepository { get; }

        Task<IResult> CommitAsync();
    }
}
