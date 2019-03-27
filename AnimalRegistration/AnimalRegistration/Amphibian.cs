namespace AnimalRegistration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Amphibian
    {
        [Key]
        public int AmphibiansID { get; set; }

        public string AmphibiansName { get; set; }

        public string AmphibiansType { get; set; }

        public int? animalSpecies_animalID { get; set; }

        public string DietryType { get; set; }

        public string PopulationNumber { get; set; }

        public virtual animal animal { get; set; }
    }
}
