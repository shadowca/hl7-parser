namespace hl7_parser
{
    public enum ApplicationAcknowledgementType
    {
        /// <summary>
        /// Always
        /// </summary>
        AL,
        /// <summary>
        /// Never
        /// </summary>
        NE,
        /// <summary>
        /// Error/reject conditions only
        /// </summary>
        ER,
        /// <summary>
        /// Successful completion only
        /// </summary>
        SU
    }
}