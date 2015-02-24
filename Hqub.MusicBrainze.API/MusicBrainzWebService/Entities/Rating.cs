﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MusicBrainzWebService.Entities
{
    [XmlType(Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("rating", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Rating
    {
        [XmlAttribute("votes-count")]
        public int VotesCount { get; set; }

        [XmlText]
        public double Value { get; set; }
    }
}
