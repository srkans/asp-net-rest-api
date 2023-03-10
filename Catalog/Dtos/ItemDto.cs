using System;

namespace Catalog.Dtos
{
        public record ItemDto //like class but has some extra features
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset createdDate { get; init; }
    }
}