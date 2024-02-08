using System;
using Xunit;

namespace BitHelp.Core.ManageFile.Test
{
    public class MimeTypeTest
    {
        [Theory]
        [InlineData("application/pdf", "pdf")]
        [InlineData("application/pdf", "PDF")]
        [InlineData("application/pdf", "PdF")]
        public void Check_pdf(string reference, string compare)
        {
            Assert.Equal(reference, MimeType.Get(compare));
        }

        [Theory]
        [InlineData("image/jpeg", ".jpg")]
        [InlineData("image/jpeg", ".JPG")]
        [InlineData("image/jpeg", ".JpG")]
        public void Check_dot_jpg(string reference, string compare)
        {
            Assert.Equal(reference, MimeType.Get(compare));
        }

        [Theory]
        [InlineData("image/png", "file.png")]
        [InlineData("image/png", "file.PNG")]
        [InlineData("image/png", "file.PnG")]
        public void Check_file_dot_png(string reference, string compare)
        {
            Assert.Equal(reference, MimeType.Get(compare));
        }

        [Theory]
        [InlineData("image/svg+xml", "file.svg")]
        [InlineData("image/svg+xml", "file.SVG")]
        [InlineData("image/svg+xml", "file.SvG")]
        public void Check_file_dot_svg(string reference, string compare)
        {
            Assert.Equal(reference, MimeType.Get(compare));
        }

        [Theory]
        [InlineData("application/vnd.ms-sstr+xml", "file.ism/manifest")]
        [InlineData("application/x-mpegURL", "file.ism/manifest(format=m3u8-aapl)")]
        [InlineData("audio/x-mpegurl", "file.m3u8")]
        [InlineData("video/mp4", "file.mp4")]
        [InlineData("application/x-mpegURL", "file.ism/manifest(format=m3u8-cmaf)")]
        [InlineData("application/dash+xml", "file.ism/manifest(format=mpd-time-cmaf)")]
        public void Check_file_video(string reference, string compare)
        {
            Assert.Equal(reference, MimeType.Get(compare));
        }

        [Fact]
        public void Check_null()
        {
            Assert.Throws<ArgumentNullException>(() => MimeType.Get(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData("     ")]
        public void Check_empty(string compare)
        {
            Assert.Equal(string.Empty, MimeType.Get(compare));
        }
    }
}
