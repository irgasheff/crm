using crmProject.Dtos;
using crmProject.Services;

Console.WriteLine("Выбериите действие: Создать клиента или Создать заказ");
string command = Console.ReadLine();

switch (command)
{
    case "Создать клиента":
        CreateClient();
        break;
    case "Создать заказ":
        CreateOrder();
        break;
    default:
        Console.WriteLine("Неизвестная команда");
        break;
}

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

    if (!ValidateClient(clientDto)) return;

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
        Description = description,
        Price = price,
        Date = date,
        DeliveryType = deliveryType,
        DeliveryAddress = deliveryAddress
    };

    if (!ValidateOrder(orderDto)) return;


    OrderService.CreateOrder(orderDto);
}

bool ValidateClient(ClientDto clientDto)
{
    List<string> errors = new();

    if (clientDto.Name is { Length: 0 })
        errors.Add("Name field is required!");

    if (clientDto.Surname is { Length: 0 })
        errors.Add("Surname field is required");

    if (clientDto.Patronymic is { Length: 0 })
        errors.Add("Patronymic field is required");

    bool isAgeCorrect = ushort.TryParse(clientDto.Age, out ushort age);
    if (!isAgeCorrect)
        errors.Add("Please input correct value for age field!");

    if (clientDto.PassportNumber is { Length: 0 })
        errors.Add("Passport number field is required");

    if (clientDto.Gender != "male" && clientDto.Gender != "female")
        errors.Add("Please input correct value for gender field (male, female)!");

    if (errors is not { Count: > 0 }) return true;
    foreach (string error in errors)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error);
    }

    Console.ForegroundColor = ConsoleColor.White;
    return false;
}

bool ValidateOrder(OrderDto orderDto)
{
    List<string> errors = new();

    if (orderDto.Description is { Length: 0 })
        errors.Add("Заполните описание для вашего заказа");

    bool isPriceCorrect = double.TryParse(orderDto.Price, out double price);
    if (!isPriceCorrect)
        errors.Add("Введите правильное значение для поля цена");

    if (orderDto.Date is { Length: 0 })
        errors.Add("Заполните дату для вашего заказа");

    if (orderDto.DeliveryType != "express" && orderDto.DeliveryType != "standard" && orderDto.DeliveryType != "free")
        errors.Add("Выберите правильный тип доставки");

    if (orderDto.DeliveryAddress is { Length: 0 })
        errors.Add("Заполните адрес доставки для вашего заказа");

    if (errors is not { Count: > 0 }) return true;
    foreach (string error in errors)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(error);
    }

    Console.ForegroundColor = ConsoleColor.White;
    return false;
}