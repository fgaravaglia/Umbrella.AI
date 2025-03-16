using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umbrella.AI.Gemini.Models
{
    /// <summary>
    /// Risposta dell'API per il conteggio dei token.
    /// </summary>
    public class CountTokensResponse
    {
        /// <summary>
        /// Numero totale di token nel testo.
        /// </summary>
        public int TotalTokens { get; set; }
    }
}