using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umbrella.AI.Gemini.Models
{
    /// <summary>
    /// Dati del contenuto.
    /// </summary>
    public class ContentData
    {
        /// <summary>
        /// Parti del contenuto.
        /// </summary>
        public List<Part> Parts { get; set; } = [];

        /// <summary>
        /// Ruolo dell'autore del contenuto.
        /// </summary>
        public string Role { get; set; } = string.Empty;
    }
}