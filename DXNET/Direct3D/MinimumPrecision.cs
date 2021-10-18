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
    public enum MinimumPrecision : System.Int32
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_DEFAULT</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_DEFAULT</unmanaged-short>
        MinimumPrecisionDefault = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_FLOAT_16</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_FLOAT_16</unmanaged-short>
        MinimumPrecisionFloat16 = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_FLOAT_2_8</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_FLOAT_2_8</unmanaged-short>
        MinimumPrecisionFloat28 = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_RESERVED</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_RESERVED</unmanaged-short>
        MinimumPrecisionReserved = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_SINT_16</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_SINT_16</unmanaged-short>
        MinimumPrecisionSInt16 = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_UINT_16</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_UINT_16</unmanaged-short>
        MinimumPrecisionUInt16 = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_ANY_16</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_ANY_16</unmanaged-short>
        MinimumPrecisionAny16 = unchecked((System.Int32)(240)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_MIN_PRECISION_ANY_10</unmanaged>
        /// <unmanaged-short>D3D_MIN_PRECISION_ANY_10</unmanaged-short>
        MinimumPrecisionAny10 = unchecked((System.Int32)(241))
    }
}
