namespace Wpm.Management.Domain
{
    public class Breed : Entity
    {
        public string Name { get; set; }
        public WeightRange MaleIdealWeight { get; set; }
        public WeightRange FemaileIdealWeight { get; set; }

        public Breed(string name,
                     WeightRange maleIdealWeight,
                     WeightRange femaileIdealWeight)
        {
            Name = name;
            MaleIdealWeight = maleIdealWeight;
            FemaileIdealWeight = femaileIdealWeight;
        }
    }

    public record WeightRange
    {

        public decimal From { get; init; }
        public decimal To { get; init; }
        public WeightRange(decimal from, decimal to)
        {
            From = from;
            To = to;
        }
    }

}
