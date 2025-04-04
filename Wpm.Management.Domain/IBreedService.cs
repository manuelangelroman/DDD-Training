﻿using Wpm.Management.Domain.Entities;
using Wpm.Management.Domain.Value_Objects;

namespace Wpm.Management.Domain
{
    public interface IBreedService
    {
        Breed? GetBreed(Guid id);
    }

    public class FakeBreedService : IBreedService
    {
        public readonly List<Breed> breeds =
            [
                new Breed(Guid.NewGuid(), "Beagle", new WeightRange(10m,20m), new WeightRange(11m,18m)),
                new Breed(Guid.NewGuid(), "Staffordshire Terrier", new WeightRange(28m,40m), new WeightRange(24m,34m))
            ];

        public Breed? GetBreed(Guid id)
        {
           if (id == Guid.Empty)
           {
                throw new ArgumentException("Breed is not valid");
           }

            var result = breeds.Find(f=>  f.Id == id);
            return result ?? throw new ArgumentException("Breed was not found");
        }
    }
}
