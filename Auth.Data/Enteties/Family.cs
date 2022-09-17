using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Auth.Data.Enteties
{
    public class Family
    {
        /// <summary>
        /// gets or sets the Family id.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// gets or sets the name of the Family.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// gets or sets the list of the Plants of the famify.
        /// </summary>
        public ICollection<Plant> Plants { get; set; } = new List<Plant>();

    }
}
