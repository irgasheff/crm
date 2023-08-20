using crmProject.Dtos;
using crmProject.Entities;
using crmProject.Enums;

namespace crmProject.Services;

public class OrderService
{
    public static Order CreateOrder(OrderDto orderDto)
    {
        DeliveryType deliveryType = orderDto.DeliveryType switch
        {
            "express" => DeliveryType.Express,
            "standard" => DeliveryType.Standard,
            "free" => DeliveryType.Free,
            _ => DeliveryType.Free
        };

        return new Order()
        {
            Id = orderDto.Id,
            Description = orderDto.Description,
            Price = double.Parse(orderDto.Price),
            Date = orderDto.Date,
            DeliveryType = deliveryType,
            DeliveryAddress = orderDto.DeliveryAddress
        };
    }
}