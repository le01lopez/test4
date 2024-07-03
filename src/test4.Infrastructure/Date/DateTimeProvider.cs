using test4.Application.Abstractions.Date;

namespace test4.Infrastructure.Date;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
