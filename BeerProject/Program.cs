namespace BeerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Beer> beerList = new List<Beer>();

            Beer beer1 = new Beer
            {
                brewery = "Carlsberg",
                brewname = "Rød",
                beerType = BeerType.PILSNER,
                volume = 40,
                percent = 5.5
            };
            beerList.Add(beer1);

            Beer beer2 = new Beer
            {
                brewery = "Tuborg",
                brewname = "Grøn",
                beerType = BeerType.PORTER,
                volume = 50,
                percent = 4.5
            };
            beerList.Add(beer2);

            Beer beer3 = new Beer
            {
                brewery = "Svaneke Bryghus",
                brewname = "Mørk Guld",
                beerType = BeerType.LAGER,
                volume = 75,
                percent = 5.7
            };
            beerList.Add(beer3);

            // Test the Mix method
            Beer mixedBeer1 = beer1.Mix(beer2);
            Console.WriteLine("\nMixed Beer from Beer 1 and Beer 2:");
            Console.WriteLine("Mixed Beer: " + mixedBeer1.ToString());
            beerList.Add(mixedBeer1);

            Beer mixedBeer2 = Beer.Mix(beer1, beer2);
            Console.WriteLine("\nMixed Beer from Beer 1 and Beer 2:");
            Console.WriteLine("Mixed Beer: " + mixedBeer2.ToString());
            beerList.Add(mixedBeer2);

            // Print the original list
            Console.WriteLine("Original List:");
            foreach (Beer beer in beerList)
            {
                Console.WriteLine(beer.ToString());
            }

            // Sort the list by UNIT
            beerList.Sort(new SortingBeerBy(SortBy.UNIT));

            // Print the sorted list
            Console.WriteLine("\nSorted List by Units:");
            foreach (Beer beer in beerList)
            {
                Console.WriteLine(beer.ToString());
            }

            // Sort the list by PERCENT
            beerList.Sort(new SortingBeerBy(SortBy.PERCENT));

            // Print the sorted list
            Console.WriteLine("\nSorted List by Percent:");
            foreach (Beer beer in beerList)
            {
                Console.WriteLine(beer.ToString());
            }

            // Sort the list by VOLUME
            beerList.Sort(new SortingBeerBy(SortBy.VOLUME));

            // Print the sorted list
            Console.WriteLine("\nSorted List by Volume:");
            foreach (Beer beer in beerList)
            {
                Console.WriteLine(beer.ToString());
            }
        }
    }
}
