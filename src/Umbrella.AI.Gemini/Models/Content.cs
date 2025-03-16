using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Umbrella.AI.Gemini.Models
{
    /// <summary>
    /// Rappresenta un contenuto generato.
    /// </summary>
    public class GeneratedContent
    {
        /// <summary>
        /// Il contenuto della risposta.
        /// </summary>
        public ContentData Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GeneratedContent()
        {
            Content = new ContentData();
        }
    }
}