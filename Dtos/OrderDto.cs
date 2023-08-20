namespace crmProject.Dtos;

public class OrderDto
{
    public Guid Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public string Price { get; init; } = string.Empty;
    public string Date { get; init; } = string.Empty;
    public string DeliveryType { get; init; } = string.Empty;
    public string DeliveryAddress { get; init; } = string.Empty;
}