using crmProject.Dtos;
using crmProject.Services;

CreateClient();

void CreateClient()
{
    Console.WriteLine("Введите имя клиента: ");
    string name = Console.ReadLine();

    Console.WriteLine("Введите фамилие клиента: ");
    string surname = Console.ReadLine();

    Console.WriteLine("Введите отчество клиента: ");
    string patronymic = Console.ReadLine();

    Console.WriteLine("Введите возраст клиента: ");
    string age = Console.ReadLine();

    Console.WriteLine("Введите серию паспорта клиента: ");
    string passportNumber = Console.ReadLine();

    Console.WriteLine("Введите пол клиента (male или female) :");
    string gender = Console.ReadLine();

    ClientDto clientDto = new ClientDto()
    {
        Name = name,
        Surname = surname,
        Patronymic = patronymic,
        Age = age,
        PassportNumber = passportNumber,
        Gender = gender
    };

    ClientService.CreateClient(clientDto);
}

void CreateOrder()
{
    Console.WriteLine("Введите описание заказа: ");
    string description = Console.ReadLine();
    
    Console.WriteLine("Введите итоговую сумму заказа: ");
    string price = Console.ReadLine();
    
    Console.WriteLine("Введите дату доставки заказа: ");
    string date = Console.ReadLine();
    
    Console.WriteLine("Введите тип доставки: ");
    string deliveryType = Console.ReadLine();
    
    Console.WriteLine("Введите адресс доставки: ");
    string deliveryAddress = Console.ReadLine();

    OrderDto orderDto = new OrderDto()
    {
        Description =description,
        Price = price,
        Date = date,
        DeliveryType = deliveryType,
        DeliveryAddress = deliveryAddress
    };

    OrderService.CreateOrder(orderDto);
}