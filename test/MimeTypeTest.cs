using System;
using Xunit;

namespace BitHelp.Core.ManageFile.Test
{
    public class MimeTypeTest
    {
        [Fact]
        public void Check_pdf()
        {
            Assert.Equal("application/pdf", MimeType.Get("pdf"));
            Assert.Equal("application/pdf", MimeType.Get("PDF"));
            Assert.Equal("application/pdf", MimeType.Get("PdF"));
        }

        [Fact]
        public void Check_dot_jpg()
        {
            Assert.Equal("image/jpeg", MimeType.Get(".jpg"));
            Assert.Equal("image/jpeg", MimeType.Get(".JPG"));
            Assert.Equal("image/jpeg", MimeType.Get(".JpG"));
        }

        [Fact]
        public void Check_file_dot_png()
        {
            Assert.Equal("image/png", MimeType.Get("file.png"));
            Assert.Equal("image/png", MimeType.Get("file.png"));
            Assert.Equal("image/png", MimeType.Get("file.png"));
        }

        [Fact]
        public void Check_null()
        {
            Assert.Throws<ArgumentNullException>(() => MimeType.Get(null));
        }

        [Fact]
        public void Check_empty()
        {
            Assert.Equal(string.Empty, MimeType.Get(string.Empty));
            Assert.Equal(string.Empty, MimeType.Get("        "));
        }
    }
}
