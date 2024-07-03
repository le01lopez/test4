using MediatR;
using test4.Domain.Abstractions;

namespace test4.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
