using System;

namespace hl7_parser
{
    public class ProcessingType
    {
        private string v;

        public ProcessingType(string value, char[] encodingCharacters)
        {
            string[] values = value.Split(encodingCharacters);
            AddValue((x) => ProcessingId = (ProcessingId)Enum.Parse(typeof(ProcessingId), x, true), values, 0);
            AddValue((x) => ProcessingMode = (ProcessingMode)Enum.Parse(typeof(ProcessingMode), x, true), values, 1);
        }

        private void AddValue(Action<string> addValue, string[] values, int index)
        {
            if (values.Length > index)
                addValue(values[index]);
        }
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