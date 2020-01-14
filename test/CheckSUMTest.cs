using System;
using System.IO;
using Xunit;

namespace BitHelp.Core.ManageFile.Test
{
    public class CheckSUMTest
    {
        public readonly string _folder = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        [Fact]
        public void Check_googlelogo_color_272x92dp()
        {
            string file = Path.GetFullPath($@"{_folder}\Resources\googlelogo_color_272x92dp.png");
            string result = CheckSUM.GetMD5Hash(file);
            Assert.Equal("j5Mn2yWX+lfS9CtKbFqYVQ", result);
        }
    }
}
