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

namespace DXNET.DXGI
{
    public partial struct ModeDescription
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref = "T:DXNET.DXGI.ModeDescription" /> structure.
        /// </summary>
        /// <param name = "width">The width.</param>
        /// <param name = "height">The height.</param>
        /// <param name = "refreshRate">The refresh rate.</param>
        /// <param name = "format">The format.</param>
        public ModeDescription(int width, int height, Rational refreshRate, Format format)
        {
            this.Width = width;
            this.Height = height;
            this.RefreshRate = refreshRate;
            this.Format = format;
            this.ScanlineOrdering = DisplayModeScanlineOrder.Unspecified;
            this.Scaling = DisplayModeScaling.Unspecified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModeDescription"/> struct.
        /// </summary>
        /// <param name="format">The format.</param>
        public ModeDescription(Format format) : this()
        {
            Format = format;
        }
    }
}