// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="kk">
//   k
// </copyright>
// <summary>
//   Defines the Order type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Hilyuta.Gallery.Model
{
    /// <summary>
    /// The order.
    /// </summary>
    public class Order : BaseClass
    {
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the client name.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the number of visitios.
        /// </summary>
        public string NumberOfVisitios { get; set; }

        /// <summary>
        /// Gets or sets the order time.
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// Gets or sets the order date.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }
    }
}
