using AuthorizationService.Application.Common.Interfaces;

namespace AuthorizationService.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
