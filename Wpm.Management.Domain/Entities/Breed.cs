using Wpm.Management.Domain.Value_Objects;

namespace Wpm.Management.Domain.Entities
{
    public class Breed : Entity
    {
        public string Name { get; set; }
        public WeightRange MaleIdealWeight { get; set; }
        public WeightRange FemaileIdealWeight { get; set; }
        public BreedId BreedId{ get; init; }

        public Breed( Guid id,
                     string name,
                     WeightRange maleIdealWeight,
                     WeightRange femaileIdealWeight)
        {
            Id = id;
            Name = name;
            MaleIdealWeight = maleIdealWeight;
            FemaileIdealWeight = femaileIdealWeight;
        }
    }

    

}
