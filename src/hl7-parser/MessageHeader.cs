using NeverNull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hl7_parser
{
    public class MessageHeader
    {
        
        public string FieldSeparator { get; set; }
        public string EncodingCharacters { get; set; }
        public Option<HierarchicDesignator> SendingApplication { get; set; }
        public Option<HierarchicDesignator> SendingFacility { get; set; }
        public Option<HierarchicDesignator> ReceivingApplication { get; set; }
        public Option<HierarchicDesignator> ReceivingFacility { get; set; }
        public Option<DateTimeOffset> DateTimeOfMessage { get; set; }
        public Option<string> Security { get; set; }
        public MessageType MessageType { get; set; }
        public string MessageControlId { get; set; }
        public ProcessingType ProcessingId { get; set; }
        public string VersionId { get; set; }
        public Option<uint> SequenceNumber { get; set; }
        public Option<string> ContinuationPointer { get; set; }
        public Option<AcceptAcknowledgementType> AcceptAcknowledgementType { get; set; }
        public Option<ApplicationAcknowledgementType> ApplicationAcknowledgementType { get; set; }
        public Option<string> CountryCode { get; set; }
        public Option<string> CharacterSet { get; set; }
        public Option<string> PrincipalLanguageOfMessage { get; set; }


        public static MessageHeader From(string line)
        {
            
          if (string.IsNullOrEmpty(line))
                throw new ArgumentNullException();

            return null;

        }
    }
}
