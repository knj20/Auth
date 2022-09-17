using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Auth.Data.Enteties
{
    public class Plant
    {
        /// <summary>
        /// gets or sets the plant id.
        /// </summary>
         [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// gets or sets the name of the plant.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// gets or sets the available of the plant.
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// gets or sets the price of the plant.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// gets or sets the family of the plant.
        /// </summary>
        public Family Family { get; set; }


    }
}
