using test4.Domain.Abstractions;

namespace test4.Domain.Products.Events;

public sealed record ProductCreatedDomainEvent(Guid ProductId) : IDomainEvent;
