namespace Umbrella.AI.Gemini.Models
{
    /// <summary>
    /// Rappresenta una risposta generata dal modello.
    /// </summary>
    public class GeminiResponse
    {
        /// <summary>
        /// Contenuti generati dal modello.
        /// </summary>
        public List<GeneratedContent> Candidates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MetaDataInfo? UsageMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ModelVersion { get; set; } = "";
        /// <summary>
        /// Ottiene il testo della prima risposta generata.
        /// </summary>
        public string? Text => ExtractRawText();
        /// <summary>
        /// 
        /// </summary>
        public GeminiResponse()
        {
            Candidates = [];
        }

        private string ExtractRawText()
        {
            if (Candidates == null || Candidates?.Count == 0)
            {
                Console.WriteLine("No candidates found.");
                return "";
            }

            if (Candidates[0]?.Content?.Parts?.Count == 0)
            {
                Console.WriteLine("No parts found in the first candidate.");
                return "";
            }

            return Candidates[0].Content.Parts[0].Text;
        }
    }
}