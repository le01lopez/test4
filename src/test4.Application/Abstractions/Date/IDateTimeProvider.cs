namespace test4.Application.Abstractions.Date;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
