using AuthService.Application.Common.Interfaces;

namespace AuthService.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
}
