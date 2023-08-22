using crmProject.Enums;

namespace crmProject.Entities;

public sealed class Client
{
    private readonly string _name;

    public string Name
    {
        get => _name;
        init => _name = value is { Length: 0 } ? _name = value : throw new ArgumentOutOfRangeException();
    }

    private readonly string _surname;

    public string Surname
    {
        get => _surname;
        init => _surname = value is { Length: 0 } ? _surname = value : throw new ArgumentOutOfRangeException();
    }

    private readonly string _patronymic;

    public string? Patronymic
    {
        get => _patronymic;
        init => _patronymic = value is { Length: 0 } ? _patronymic = value : throw new ArgumentOutOfRangeException();
    }

    private readonly ushort _age;

    public ushort Age
    {
        get => _age;
        init => _age = value > 0 ? _age = value : throw new ArgumentOutOfRangeException();
    }

    private readonly string _passportNumber;

    public string PassportNumber
    {
        get => _passportNumber;
        init => _passportNumber =
            value is { Length: 0 } ? _passportNumber = value : throw new ArgumentOutOfRangeException();
    }

    private readonly Gender _gender;

    public Gender Gender
    {
        get => _gender;
        init
        {
            if (value != Gender.Female && value != Gender.Male)
            {
                throw new ArgumentOutOfRangeException();
            }

            _gender = value;
        }
    }
}