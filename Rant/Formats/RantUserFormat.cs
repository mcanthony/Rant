﻿using System.Globalization;

using Rant.Engine;

namespace Rant.Formats
{
    /// <summary>
    /// Represents a user-specified Rant format.
    /// </summary>
    public sealed class RantUserFormat : RantFormat
    {
        #region Quotation marks

        /// <summary>
        /// The opening primary quotation mark.
        /// </summary>
        public new char OpeningPrimaryQuote { get; set; } = '\u201c';
        /// <summary>
        /// The closing primary quotation mark.
        /// </summary>
        public new char ClosingPrimaryQuote { get; set; } = '\u201d';

        /// <summary>
        /// The opening secondary quotation mark.
        /// </summary>
        public new char OpeningSecondaryQuote { get; set; } = '\u2018';
        /// <summary>
        /// The closing secondary quotation mark.
        /// </summary>
        public new char ClosingSecondaryQuote { get; set; } = '\u2019';

		/// <summary>
		/// The standard space character used in automated formatting, such as series.
		/// </summary>
		public new char StandardSpace { get; set; } = ' ';

        #endregion

        /// <summary>
        /// The letter set used by escape sequences like \c and \w.
        /// </summary>
        public new char[] Letters { get; set; }

		/// <summary>
		/// The culture to format output strings with.
		/// </summary>
		public new CultureInfo Culture { get; set; } = CultureInfo.InvariantCulture;

		/// <summary>
		/// Adds the specified strings to the title case exclusion list for the current format.
		/// </summary>
		/// <param name="words">The words to exclude from title case capitalization.</param>
		public void AddTitleCaseExclusions(params string[] words) => TitleCaseExclusions.AddRange(words);
	}
}