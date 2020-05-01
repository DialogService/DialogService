using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    /// <summary>
    /// Dialog model
    /// </summary>
    public class Dialog
    {
        /// <summary>
        /// Gets or sets dialog's title text
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Creates an empty dialog
        /// </summary>
        public Dialog()
        {
        }

        /// <summary>
        /// Creates a dialog with a specified title text
        /// </summary>
        /// <param name="title">Title text</param>
        public Dialog(string title) : this()
        {
            Title = title;
        }
    }
}
