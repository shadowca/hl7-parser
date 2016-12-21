using System;
using System.Globalization;

namespace hl7_parser
{
    public class Parser
    {
        public MessageHeader Parse(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();

            string[] valueSplitter = new[] { "|" };
            string[] lines = value.Split(valueSplitter, StringSplitOptions.None);

            MessageHeader header = new MessageHeader();
            header.FieldSeparator = "|";
            header.EncodingCharacters = lines[1].ToCharArray();
            header.SendingApplication = new HierarchicDesignator(lines[2], header.EncodingCharacters);
            header.SendingFacility = new HierarchicDesignator(lines[3], header.EncodingCharacters);
            header.ReceivingApplication= new HierarchicDesignator(lines[4], header.EncodingCharacters);
            header.ReceivingFacility = new HierarchicDesignator(lines[5], header.EncodingCharacters);
            header.DateTimeOfMessage = DateTimeOffset.ParseExact(lines[6],"yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            header.Security = !string.IsNullOrEmpty(lines[7])? lines[7]: NeverNull.Option<string>.None;
            header.MessageType = new MessageType(lines[8], header.EncodingCharacters);
            header.MessageControlId = !string.IsNullOrEmpty(lines[9]) ? lines[9] : NeverNull.Option<string>.None;
            header.ProcessingId = new ProcessingType(lines[10], header.EncodingCharacters);
            header.VersionId = lines[11];
            header.SequenceNumber = !string.IsNullOrEmpty(lines[12])?uint.Parse(lines[12]): NeverNull.Option<uint>.None;
            header.ContinuationPointer = lines[13];
            header.AcceptAcknowledgementType = (AcceptAcknowledgementType)Enum.Parse(typeof(AcceptAcknowledgementType), lines[14], true);
            header.ApplicationAcknowledgementType = (ApplicationAcknowledgementType)Enum.Parse(typeof(ApplicationAcknowledgementType), lines[15], true);
            header.CountryCode =  lines[16];
            header.CharacterSet = lines[17];
            header.PrincipalLanguageOfMessage = lines[18];
            
            return header;
        }
    }
}
