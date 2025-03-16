namespace Umbrella.AI.Gemini.Models
{

    /// <summary>
    /// Risposta dell'API per l'elenco dei modelli.
    /// </summary>
    public class ModelsResponse
    {
        /// <summary>
        /// Lista dei modelli disponibili.
        /// </summary>
        public List<ModelInfo> Models { get; set; } = [];
    }

    /// <summary>
    /// Informazioni su un modello.
    /// </summary>
    public class ModelInfo
    {
        /// <summary>
        /// Nome del modello.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Versione del modello.
        /// </summary>
        public string Version { get; set; } = "";

        /// <summary>
        /// Descrizione del modello.
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Limite di input token del modello.
        /// </summary>
        public int InputTokenLimit { get; set; }

        /// <summary>
        /// Limite di output token del modello.
        /// </summary>
        public int OutputTokenLimit { get; set; }
    }
}