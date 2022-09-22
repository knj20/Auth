using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Models
{
    internal class FamilyDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// gets or sets the name of the Family.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// gets or sets the list of the Plants of the famify.
        /// </summary>
        public ICollection<PlantDto> Plants { get; set; } = new List<PlantDto>();
    }
}
