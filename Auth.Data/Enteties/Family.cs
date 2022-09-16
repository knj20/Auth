using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Data.Enteties
{
    class Family
    {
        /// <summary>
        /// gets or sets the Family id.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// gets or sets the name of the Family.
        /// </summary>
        string Name { get; set; }
    }
}
