﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class MetaDescription
    {
        private string metaDescriptionText; // Meta dane - Opis pdostrony; Znajduje się w tagu: <meta name="description" content="treść opisu">. To jets opis jaki się wyświetla w google pod linkiem do każdego z wyników
        private int metaDescriptionLength; // Długość opisu w ilości znaków
        private int metaDescriptionPixelWidth; // długość opisu w szerokości liczonej w pikselach
        public string MetaDescriptionText
        {
            get { return metaDescriptionText; }
            set { metaDescriptionText = value; }
        }
        public int MetaDescriptionLength
        {
            get { return metaDescriptionLength; }
            set { metaDescriptionLength = value; }
        }
        public int MetaDescriptionPixelWidth
        {
            get { return metaDescriptionPixelWidth; }
            set { metaDescriptionPixelWidth = value; }
        }
    }
}
