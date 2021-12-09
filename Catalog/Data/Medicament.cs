using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data
{
    public class Medicament : IEquatable<Medicament>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Purpose { get; set; }

        public int Dosage { get; set; }
        public int CountOfDoses { get; set; }

        public DateTime DateOfIssue { get; private set; }
        public DateTime ShelfLife { get; private set; }

        public Medicament() : this(new DateTime(2000, 1, 1), new DateTime(2001, 1, 1))
        {

        }
        public Medicament(DateTime dateOfIssue, DateTime shelfLife)
        {
            DateOfIssue     = dateOfIssue;
            ShelfLife       = shelfLife;
        }

        public bool Equals(Medicament other)
        {
            return Name == other.Name &&
                Category == other.Category &&
                Purpose == other.Purpose &&
                Dosage == other.Dosage &&
                CountOfDoses == other.CountOfDoses &&
                DateOfIssue == other.DateOfIssue &&
                ShelfLife == other.ShelfLife;
        }
    }
}
