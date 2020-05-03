using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    /// <summary>
    /// Defines font settings
    /// </summary>
    public interface IFont
    {
        /// <summary>
        /// Font size
        /// </summary>
        int Size { get; }
        /// <summary>
        /// Font name
        /// </summary>
        string Name { get; }
    }
}
