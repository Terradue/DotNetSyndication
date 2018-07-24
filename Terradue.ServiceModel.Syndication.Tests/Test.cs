using NUnit.Framework;
using System;
using System.IO;
using System.Xml;

namespace Terradue.ServiceModel.Syndication.Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
			var feed = SyndicationFeed.Load(XmlReader.Create("../../in/search.atom"));

			Atom10FeedFormatter formatter = new Atom10FeedFormatter(feed);
            
			formatter.WriteTo(XmlWriter.Create(new FileStream("../../out/search.atom", FileMode.Create, FileAccess.Write)));

        }
    }
}
