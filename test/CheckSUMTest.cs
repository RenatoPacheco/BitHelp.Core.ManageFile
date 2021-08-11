using System.IO;
using Xunit;

namespace BitHelp.Core.ManageFile.Test
{
    public class CheckSUMTest
    {
        [Fact]
        public void Check_googlelogo_color_272x92dp()
        {
            string file = Path.GetFullPath(@"./Resources/googlelogo_color_272x92dp.png");
            string result = CheckSUM.GetMD5Hash(file);
            Assert.Equal("j5Mn2yWX+lfS9CtKbFqYVQ", result);
        }
    }
}
