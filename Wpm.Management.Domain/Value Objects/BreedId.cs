namespace Wpm.Management.Domain.Value_Objects
{
    public record BreedId
    {
        private readonly IBreedService _breedService;
        public Guid Value { get; set; }

        public BreedId(Guid value, IBreedService breedService)
        {
            _breedService = breedService;

            ValidateBreed(value);

            Value = value;
        }

        private void ValidateBreed(Guid value)
        {
            if (_breedService.GetBreed(value) == null)
            {
                throw new ArgumentException("Breed is not valid");
            }
        }
    }
}
