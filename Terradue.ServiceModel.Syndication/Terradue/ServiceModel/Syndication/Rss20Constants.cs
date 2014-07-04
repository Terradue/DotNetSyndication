//
// SyndicationElementExtensionCollection.cs
//
// Author:
//	Atsushi Enomoto  <atsushi@ximian.com>
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Terradue.ServiceModel.Syndication
{
    internal static class Rss20Constants
    {
        public const string AuthorTag = "author";
        public const string CategoryTag = "category";
        public const string ChannelTag = "channel";
        public const string CopyrightTag = "copyright";
        public const string DescriptionTag = "description";
        public const string DomainTag = "domain";
        public const string EnclosureTag = "enclosure";
        public const string ExtensionWrapperTag = "extensionWrapper";
        public const string GeneratorTag = "generator";
        public const string GuidTag = "guid";
        public const string ImageTag = "image";
        public const string IsPermaLinkTag = "isPermaLink";
        public const string ItemTag = "item";
        public const string LanguageTag = "language";
        public const string LastBuildDateTag = "lastBuildDate";
        public const string LengthTag = "length";
        public const string LinkTag = "link";
        public const string ManagingEditorTag = "managingEditor";
        public const string PubDateTag = "pubDate";
        public const string Rss20Namespace = "";
        public const string RssTag = "rss";
        public const string SourceTag = "source";
        public const string SpecificationLink = "http://blogs.law.harvard.edu/tech/rss";
        public const string TitleTag = "title";
        public const string TypeTag = "type";
        public const string UrlTag = "url";
        public const string Version = "2.0";
        public const string VersionTag = "version";
    }

}
