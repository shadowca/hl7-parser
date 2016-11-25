using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hl7_parser;

namespace hl7_parser_tests
{
    [TestClass]
    public class MessageHeaderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_string_for_parsing_is_null_or_empty_it_should_throw_an_argument_null_exception()
        {
            MessageHeader.From("");
        }
    }
}
