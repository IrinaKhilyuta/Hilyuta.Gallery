// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employeer.cs" company="ыы">
//   ыы
// </copyright>
// <summary>
//   Defines the Employeer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Hilyuta.Gallery.Model
{
    /// <summary>
    /// The employeer.
    /// </summary>
    public class Employeer : BaseClass
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
        /// Gets or sets the home address.
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// Gets or sets the present post.
        /// </summary>
        public string PresentPost { get; set; }

        /// <summary>
        /// Gets or sets the social security number.
        /// </summary>
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Gets or sets the authority identifier.
        /// </summary>
        public string AuthorityIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the medical insurance number.
        /// </summary>
        public string MedicalInsuranceNumber { get; set; }

        /// <summary>
        /// Gets or sets the halls under the jurisdiction.
        /// </summary>
        public ICollection<ExhibitionHall> HallsUnderTheJurisdiction { get; set; }
    }
}
