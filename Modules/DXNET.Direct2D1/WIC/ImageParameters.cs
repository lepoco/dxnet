﻿// Copyright (c) 2021 DXNET - Pomianowski Leszek & Contributors
// Copyright (c) 2010-2019 SharpDX - Alexandre Mutel & SharpDX Contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
namespace DXNET.WIC
{
    public partial struct ImageParameters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageParameters" /> struct.
        /// </summary>
        /// <param name="pixelFormat">The pixel format.</param>
        /// <param name="dpiX">The dpi X.</param>
        /// <param name="dpiY">The dpi Y.</param>
        /// <param name="top">The top.</param>
        /// <param name="left">The left.</param>
        /// <param name="pixelWidth">Width in pixel.</param>
        /// <param name="pixelHeight">Height in pixel.</param>
        public ImageParameters(Direct2D1.PixelFormat pixelFormat, float dpiX, float dpiY, float top, float left, int pixelWidth, int pixelHeight)
        {
            PixelFormat = pixelFormat;
            DpiX = dpiX;
            DpiY = dpiY;
            Top = top;
            Left = left;
            PixelWidth = pixelWidth;
            PixelHeight = pixelHeight;
        }
    }
}