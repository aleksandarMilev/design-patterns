namespace DesignPatterns.Structural.Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, TreeType> treeTypes = [];

        public TreeType GetTreeType(string species)
        {
            if (!this.treeTypes.ContainsKey(species))
            {
                this.treeTypes[species] = new(species);

                Console.WriteLine($"Creating new tree type for species: {species}");
            }
            else
            {
                Console.WriteLine($"Reusing existing tree type for species: {species}");
            }

            return this.treeTypes[species];
        }
    }
}
