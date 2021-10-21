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
    /// <unmanaged>D3D_MIN_PRECISION</unmanaged>
    /// <unmanaged-short>D3D_MIN_PRECISION</unmanaged-short>
    public enum MinimumPrecision : int
    {
        /// <summary>
        /// D3D_MIN_PRECISION_DEFAULT
        /// </summary>
        MinimumPrecisionDefault = 0,

        /// <summary>
        /// D3D_MIN_PRECISION_FLOAT_16
        /// </summary>
        MinimumPrecisionFloat16,

        /// <summary>
        /// D3D_MIN_PRECISION_FLOAT_2_8
        /// </summary>
        MinimumPrecisionFloat28,

        /// <summary>
        /// D3D_MIN_PRECISION_RESERVED
        /// </summary>
        MinimumPrecisionReserved,

        /// <summary>
        /// D3D_MIN_PRECISION_SINT_16
        /// </summary>
        MinimumPrecisionSInt16,

        /// <summary>
        /// D3D_MIN_PRECISION_UINT_16
        /// </summary>
        MinimumPrecisionUInt16,

        /// <summary>
        /// D3D_MIN_PRECISION_ANY_16
        /// </summary>
        MinimumPrecisionAny16 = 240,

        /// <summary>
        /// D3D_MIN_PRECISION_ANY_10
        /// </summary>
        MinimumPrecisionAny10 = 241
    }
}
