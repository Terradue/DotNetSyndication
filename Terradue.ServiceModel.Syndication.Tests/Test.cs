using System;
using System.IO;
using System.Xml;
using Xunit;

namespace Terradue.ServiceModel.Syndication.Tests
{
    public class Test
    {
        [Fact(DisplayName = "Feed Loading Test #1")]
        [Trait("Category", "unit")]
        public void TestCase()
        {
			var feed = SyndicationFeed.Load(XmlReader.Create(TestFixture.TestBaseDir + "/in/search.atom"));

			Atom10FeedFormatter formatter = new Atom10FeedFormatter(feed);
            
			formatter.WriteTo(XmlWriter.Create(new FileStream(TestFixture.TestBaseDir + "/out/search.atom", FileMode.Create, FileAccess.Write)));

        }

        [Fact(DisplayName = "Feed Loading Test #2")]
        [Trait("Category", "unit")]
        public void TestCase2()
        {
			var feed = SyndicationFeed.Load(XmlReader.Create(TestFixture.TestBaseDir + "/in/mundisearch.atom"));

			Atom10FeedFormatter formatter = new Atom10FeedFormatter(feed);
            
        }
    }
}
