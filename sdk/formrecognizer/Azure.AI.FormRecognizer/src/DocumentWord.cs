﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    [CodeGenModel("DocumentWord")]
    public partial class DocumentWord
    {
        /// <summary>
        /// Initializes a new instance of DocumentWord. Use for the <see cref="DocumentAnalysisModelFactory"/>.
        /// </summary>
        internal DocumentWord(string content, BoundingPolygon boundingPolygon, DocumentSpan span, float confidence)
        {
            Content = content;
            BoundingPolygon = boundingPolygon;
            Span = span;
            Confidence = confidence;
        }

        /// <summary>
        /// The polygon that outlines the content of this word. Coordinates are specified relative to the
        /// top-left of the page, and points are ordered clockwise from the left relative to the word
        /// orientation. Units are in pixels for images and inches for PDF. The <see cref="LengthUnit"/>
        /// type of a recognized page can be found at <see cref="DocumentPage.Unit"/>.
        /// </summary>
        public BoundingPolygon BoundingPolygon { get; private set; }

        private IReadOnlyList<float> Polygon
        {
            get => throw new InvalidOperationException();
            set
            {
                BoundingPolygon = new BoundingPolygon(value);
            }
        }
    }
}
