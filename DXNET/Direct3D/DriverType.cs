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
using System.Runtime.InteropServices;

namespace DXNET.Direct3D
{
    /// <summary>
    /// DriverType
    /// </summary>
    public enum DriverType : int
    {
        /// <summary>
        /// D3D_DRIVER_TYPE_UNKNOWN
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// D3D_DRIVER_TYPE_HARDWARE
        /// </summary>
        Hardware = 1,

        /// <summary>
        /// D3D_DRIVER_TYPE_REFERENCE
        /// </summary>
        Reference = 2,

        /// <summary>
        /// D3D_DRIVER_TYPE_NULL
        /// </summary>
        Null = 3,

        /// <summary>
        /// D3D_DRIVER_TYPE_SOFTWARE
        /// </summary>
        Software = 4,

        /// <summary>
        /// D3D_DRIVER_TYPE_WARP
        /// </summary>
        Warp = 5
    }
}
