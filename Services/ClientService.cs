using crmProject.Dtos;
using crmProject.Entities;
using crmProject.Enums;

namespace crmProject.Services;

public class ClientService
{
    public static Client CreateClient(ClientDto clientDto)
    {
        Gender gender = clientDto.Gender switch
        {
            "male" => Gender.Male,
            "female" => Gender.Female,
            _ => Gender.Male
        };

        return new Client()
        {
            Name = clientDto.Name,
            Surname = clientDto.Surname,
            Patronymic = clientDto.Patronymic,
            Age = ushort.Parse(clientDto.Age),
            PassportNumber = clientDto.PassportNumber,
            Gender = gender
        };
    }
}