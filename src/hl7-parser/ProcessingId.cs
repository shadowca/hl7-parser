namespace hl7_parser
{
    public class ProcessingType
    {
        public ProcessingId ProcessingId { get; set; }
        public ProcessingMode ProcessingMode { get; set; }
    }
    public enum ProcessingId
    {
        /// <summary>
        /// Debugging
        /// </summary>
        D,
        /// <summary>
        /// Production
        /// </summary>
        P,
        /// <summary>
        /// Training
        /// </summary>
        T
    }
    public enum ProcessingMode
    {
        /// <summary>
        /// Archive
        /// </summary>
        A,
        /// <summary>
        /// Restore from archive
        /// </summary>
        R,
        /// <summary>
        /// Initial load
        /// </summary>
        I,
        /// <summary>
        /// Not present (the default, meaning current processing)
        /// </summary>
        NotPresent 
    }
}