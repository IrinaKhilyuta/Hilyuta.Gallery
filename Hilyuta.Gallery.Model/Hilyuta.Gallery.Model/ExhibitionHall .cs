// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExhibitionHall .cs" company="m">
//   mm
// </copyright>
// <summary>
//   The exhibition hall.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Hilyuta.Gallery.Model
{
    /// <summary>
    /// The exhibition hall.
    /// </summary>
    public class ExhibitionHall : BaseClass
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the capacity.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        public ICollection<Picture> Pictures { get; set; }

        /// <summary>
        /// Gets or sets the employeers.
        /// </summary>
        public ICollection<Employeer> Employeers { get; set; }
    }
}
