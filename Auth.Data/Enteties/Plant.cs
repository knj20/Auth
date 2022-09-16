using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Enteties
{
    class Plant
    {
        /// <summary>
        /// gets or sets the plant id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// gets or sets the name of the plant.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// gets or sets the available of the plant.
        /// </summary>
        bool Available { get; set; }

        /// <summary>
        /// gets or sets the price of the plant.
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// gets or sets the family of the plant.
        /// </summary>
        Family Family { get; set; }


    }
}
