using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppV1.Models
{
    internal class Inventory
    {
        private List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            var guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                if ((searchSpec.Builder == Builder.Any || guitar.Spec.Builder == searchSpec.Builder) &&
                    (searchSpec.Model == null || guitar.Spec.Model == searchSpec.Model) &&
                    (searchSpec.Type == null || guitar.Spec.Type == searchSpec.Type) &&
                    (searchSpec.BackWood == null || guitar.Spec.BackWood == searchSpec.BackWood) &&
                    (searchSpec.TopWood == null || guitar.Spec.TopWood == searchSpec.TopWood) &&
                    (searchSpec.NumStrings == 0 || guitar.Spec.NumStrings == searchSpec.NumStrings))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }
        }

}

