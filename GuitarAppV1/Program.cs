using GuitarAppV1.Models;

namespace GuitarAppV1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocaster", Models.Type.Electric, Wood.Alder, Wood.Alder, 6);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine($"  We have a {guitar.Spec.Builder} {guitar.Spec.Model} {guitar.Spec.Type} guitar:\n" +
                        $"     {guitar.Spec.BackWood} back and siddes,\n" +
                        $"     {guitar.Spec.TopWood} top,\n" +
                        $"     {guitar.Spec.NumStrings} strings.\n" +
                        $"  You can have it for  {guitar.Price} dollars!");
                }
            }
            else
            {
                Console.WriteLine(" Erin, we have nothing for u.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("001", 4000, new GuitarSpec(Builder.Collings, "CJ", Models.Type.Acoustic, Wood.IndianRosewood, Wood.Sitka, 6));
            inventory.AddGuitar("002", 1500, new GuitarSpec(Builder.Fender, "Stratocaster", Models.Type.Electric, Wood.Alder, Wood.Alder, 6));
            inventory.AddGuitar("003", 2000, new GuitarSpec(Builder.Fender, "Stratocaster", Models.Type.Electric, Wood.Alder, Wood.Alder, 6));
            
        }
    }

}

