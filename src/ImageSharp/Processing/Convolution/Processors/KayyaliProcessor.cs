﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing.Convolution.Processors
{
    /// <summary>
    /// Applies edge detection processing to the image using the Kayyali operator filter. <see href="http://edgedetection.webs.com/"/>
    /// </summary>
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    internal class KayyaliProcessor<TPixel> : EdgeDetector2DProcessor<TPixel>
         where TPixel : struct, IPixel<TPixel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KayyaliProcessor{TPixel}"/> class.
        /// </summary>
        /// <param name="grayscale">Whether to convert the image to grayscale before performing edge detection.</param>
        public KayyaliProcessor(bool grayscale)
            : base(KayyaliKernels.KayyaliX, KayyaliKernels.KayyaliY, grayscale)
        {
        }
    }
}