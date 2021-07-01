using HotChocolate;
using Microsoft.Extensions.Logging;
using System;

namespace StarWars.ExtraGraphQL
{
public class MyErrorFilter : IErrorFilter
{
    private readonly ILogger _logger;

    public MyErrorFilter(ILogger<MyErrorFilter> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public IError OnError(IError error)
    {
        _logger.LogInformation(error.Exception, error.Message);

        return error;
    }
}
}
