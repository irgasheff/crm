using crmProject.Enums;

namespace crmProject.Entities;

public sealed class Client
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Patronymic { get; set; } = string.Empty;
    public ushort Age { get; set; }
    public string PassportNumber { get; set; } = string.Empty;
    public Gender Gender { get; set; }
}