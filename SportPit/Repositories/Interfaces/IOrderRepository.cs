using SportPit.Models;
using SportPit.Models.Dto;

namespace SportPit.Repositories.Interfaces;

public interface IOrderRepository
{
    Dictionary<ProductCartDto, int> CountProductsByProductId {  get; }
    decimal Sum { get; }
    void Add(ProductCartDto productCartDTO);
    void Remove(ProductCartDto productCartDTO);
}
