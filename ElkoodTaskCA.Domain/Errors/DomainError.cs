using Elkood.Domain.Exceptions;
using Elkood.Domain.Exceptions.Http;

namespace ElkoodTaskCA.Domain.Errors;

public class DomainError
{
    public static HttpMessage NotFound => new("test",
        HttpStatusCode.NotFound404);
}