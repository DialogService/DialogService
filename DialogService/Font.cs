using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public class Font : IFont
    {
        /// <summary>
        /// Font size
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Font name
        /// </summary>
        public string Name { get; set; }
    }
}
