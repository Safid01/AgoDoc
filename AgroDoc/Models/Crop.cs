using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDoc.Models
{
    public class Crop
    {
        public int CropId { get; set; }

        public string CropName { get; set; }

        public string SuitableLocation { get; set; }

        public int MinDurationDays { get; set; }

        public int MaxDurationDays { get; set; }

        public double MinN { get; set; }
        public double MaxN { get; set; }

        public double MinP { get; set; }
        public double MaxP { get; set; }

        public double MinK { get; set; }
        public double MaxK { get; set; }

        public double MinPh { get; set; }
        public double MaxPh { get; set; }

        public string SuitableSoil { get; set; }

        public string Description { get; set; }
    }
}
