// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Picture.cs" company="">
//   jk
// </copyright>
// <summary>
//   Defines the Picture type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Hilyuta.Gallery.Model
{
    /// <summary>
    /// The picture.
    /// </summary>
    public class Picture : BaseClass
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the painting year.
        /// </summary>
        public uint PaintingYear { get; set; }

        /// <summary>
        /// The author.
        /// </summary>
        public Artist Author { get; set; }

        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the technique.
        /// </summary>
        public string Technique { get; set; }
    }
}
