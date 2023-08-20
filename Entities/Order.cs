using crmProject.Enums;

namespace crmProject.Entities;

public sealed class Order
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Date { get; set; } = string.Empty;
    public DeliveryType DeliveryType { get; set; }
    public string DeliveryAddress { get; set; } = string.Empty;
}