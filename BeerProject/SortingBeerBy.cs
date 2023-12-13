using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    public enum SortBy { UNIT,PERCENT,VOLUME}
    internal class SortingBeerBy : IComparer<Beer>
    {
        private SortBy sortBy;

        public SortingBeerBy(SortBy sortBy)
        {
            this.sortBy = sortBy;
        }

        public int Compare(Beer beer1, Beer beer2)
        {
            switch (sortBy)
            {
                case SortBy.UNIT:
                    return beer1.GetUnits().CompareTo(beer2.GetUnits());

                case SortBy.PERCENT:
                    return beer1.percent.CompareTo(beer2.percent);

                case SortBy.VOLUME:
                    return beer1.volume.CompareTo(beer2.volume);

                default:
                    throw new ArgumentException("Invalid SortBy value");
            }
        }
    }

}
