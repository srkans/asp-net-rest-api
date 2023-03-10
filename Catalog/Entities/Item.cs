using System;

namespace Catalog.Entities
{
    public record Item //like class but has some extra features
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset createdDate { get; init; }
    }
}