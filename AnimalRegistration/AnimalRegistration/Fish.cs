namespace AnimalRegistration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fish
    {
        public int FishID { get; set; }

        public string FishType { get; set; }

        public string FishName { get; set; }

        public int? animalSpecies_animalID { get; set; }

        public string DietryType { get; set; }

        public string PopulationNumber { get; set; }

        public virtual animal animal { get; set; }
    }
}
