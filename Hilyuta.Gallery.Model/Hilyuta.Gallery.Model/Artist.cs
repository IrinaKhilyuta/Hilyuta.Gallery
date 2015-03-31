// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Artist.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Artist type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Hilyuta.Gallery.Model
{
    /// <summary>
    /// The artist.
    /// </summary>
    public class Artist : BaseClass
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the date of death.
        /// </summary>
        public DateTime DateOfDeath { get; set; }

        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        public ICollection<Picture> Pictures { get; set; }
    }
}
