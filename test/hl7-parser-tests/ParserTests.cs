using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hl7_parser;

namespace hl7_parser_tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_string_for_parsing_is_null_or_empty_it_should_throw_an_argument_null_exception()
        {
            var parser = new Parser();
            parser.Parse("");
        }

        [TestMethod]
        public void Test() {
            var parser = new Parser();
            var result = parser.Parse(@"MSH|^~\&|SUBx||PAT||20040328112408||ADT^A01^ADT_A01|47|P|2.5|||AL|NE|DEU|8859/1|DEU^^HL70296||2.16.840.1.113883.2.6.9.1^^2.16.840.1.113883.2.6^ISO|<cr>");
            Assert.IsNotNull(result);
        }
    }
}
