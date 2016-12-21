using System;

namespace hl7_parser
{
    public class HierarchicDesignator
    {

        public HierarchicDesignator(string value, char[] encodingCharacters)
        {
            string[] values = value.Split(encodingCharacters);
            AddValue((x) => Namespace = x, values, 0);
            AddValue((x) => UniversalId= x, values, 1);
            AddValue((x) => UniversalIdType = x, values, 2);
        }

        private void AddValue(Action<string> addValue, string[] values, int index)
        {
            if (values.Length > index)
                addValue(values[index]);
        }

        public string Namespace { get; set; }
        public string UniversalId { get; set; }
        public string UniversalIdType { get; set; }
    }
}