using crmProject.Enums;

namespace crmProject.Dtos;

public class ClientDto
{
    public string Name { get; init; } =string.Empty;
    public string Surname { get; init; } =string.Empty;
    public string Patronymic { get; init; } =string.Empty;
    public string Age { get; init; } =string.Empty;
    public string PassportNumber { get; init; } =string.Empty;
    public string Gender { get; init; } =string.Empty;
}