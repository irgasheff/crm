namespace crmProject.Dtos;

public readonly struct ClientDto
{
    public string Name { get; init; }
    public string Surname { get; init; }
    public string? Patronymic { get; init; }
    public string Age { get; init; }
    public string PassportNumber { get; init; }
    public string Gender { get; init; }
}