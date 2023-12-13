using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BeerProject.Beer;

namespace BeerProject 
{
    public enum BeerType { LAGER, PILSNER, MÜNCHENER, WIENERDORTMUNDER, BOCK, DOBBELBOCK, PORTER, MIX }

    internal class Beer : IComparable<Beer>
    {
        private string _brewery;
        private string _brewname;
        private BeerType _beertype;
        private int _volume;
        private double _percent;

        public string brewery
        {
            get { return _brewery; }
            set { _brewery = value; }
        }
        public string brewname
        {
            get { return _brewname; }
            set { _brewname = value; }
        }
        public BeerType beerType
        {
            get { return _beertype; }
            set { _beertype = value; }
        }
        public int volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public double percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        public Beer() { }
        public Beer(string brewery, string brewname, BeerType beerType, int volume, double percent) 
        {
            _brewery = brewery;
            _brewname = brewname;
            _beertype = beerType;
            _volume = volume;
            _percent = percent;

        }

        public override string ToString()
        {
            return $"Bryggeri: {_brewery}, Navn: {_brewname} Type: {_beertype} Volume i cl: {_volume} Alkoholpct: {_percent}";

        }

        public double GetUnits()
        {
            double genstand = volume * percent / 150;
                return genstand;
        }
        public void Add(Beer addedBeer)
        {
            _volume += addedBeer.volume;
            _percent = (_volume * _percent + addedBeer._volume * _percent) / (_volume + addedBeer._volume);
        }
        public Beer Mix(Beer otherBeer)
        {
            string mixedBrewery = $"{_brewery} & {otherBeer._brewery}";
            string mixedBeerName = $"{_brewname} {otherBeer._brewname}";
            Beer mixedBeer = new Beer(mixedBrewery, mixedBeerName, BeerType.MIX, _volume + otherBeer._volume, (_volume * _percent + otherBeer._volume * otherBeer._percent) / (_volume + otherBeer._volume));
            return mixedBeer;
        }

        public static Beer Mix(Beer beer1, Beer beer2)
        {
            string mixedBrewery = $"{beer1._brewery} & {beer2._brewery}";
            string mixedBrewname = $"{beer1._brewname} & {beer2._brewname}";
            Beer mixedBeer = new Beer(mixedBrewery, mixedBrewname, BeerType.MIX, beer1._volume + beer2._volume, (beer1._volume * beer1._percent + beer2._volume * beer2._percent) / (beer1._volume + beer2._volume));
            return mixedBeer;
        }

        public int CompareTo(Beer other)
        {            
            return GetUnits().CompareTo(other.GetUnits());
        }
    }
}
/*

}*/