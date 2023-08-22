using crmProject.Dtos;
using crmProject.Entities;
using crmProject.Enums;

namespace crmProject.Services;

public class ClientService
{
    private readonly List<Client> _clients;

    public void CreateClient(ClientDto clientDto)
    {
        Gender gender = clientDto.Gender switch
        {
            "male" => Gender.Male,
            "female" => Gender.Female,
            _ => Gender.Male
        };

        Client client = new Client()
        {
            Name = clientDto.Name,
            Surname = clientDto.Surname,
            Patronymic = clientDto.Patronymic,
            Age = ushort.Parse(clientDto.Age),
            PassportNumber = clientDto.PassportNumber,
            Gender = gender,
            Phone = clientDto.Phone,
            Email = clientDto.Email,
            Password = clientDto.Password
        };

        _clients.Add(client);
    }
}