using static System.Runtime.InteropServices.JavaScript.JSType;
using static EvaluationSampleCode.HtmlFormatHelper;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormat_StringValue_ReturnBoldValue()
        {
            HtmlFormatHelper htmlFormatHelper = new HtmlFormatHelper();

            var result = htmlFormatHelper.GetBoldFormat("Hello");

            Assert.AreEqual("<b>Hello</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_StringValue_ReturnItalicValue()
        {
            HtmlFormatHelper htmlFormatHelper = new HtmlFormatHelper();

            var result = htmlFormatHelper.GetItalicFormat("Hello");

            Assert.AreEqual("<i>Hello</i>", result);
        }
    }
}