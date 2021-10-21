// Copyright (c) 2021 DXNET - Pomianowski Leszek & Contributors
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

using System;
using System.Collections.Generic;

namespace DXNET.DXGI
{
    /// <summary>
    /// DXGI_ALPHA_MODE
    /// </summary>
    public enum AlphaMode : int
    {
        /// <summary>
        /// DXGI_ALPHA_MODE_UNSPECIFIED
        /// </summary>
        Unspecified = unchecked((System.Int32)(0)),

        /// <summary>
        /// DXGI_ALPHA_MODE_PREMULTIPLIED
        /// </summary>
        Premultiplied = unchecked((System.Int32)(1)),

        /// <summary>
        /// DXGI_ALPHA_MODE_STRAIGHT
        /// </summary>
        Straight = unchecked((System.Int32)(2)),

        /// <summary>
        /// DXGI_ALPHA_MODE_IGNORE
        /// </summary>
        Ignore = unchecked((System.Int32)(3))
    }
}