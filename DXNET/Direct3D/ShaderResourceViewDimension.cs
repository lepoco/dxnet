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
    /// D3D_SRV_DIMENSION
    /// </summary>
    public enum ShaderResourceViewDimension : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_UNKNOWN</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_UNKNOWN</unmanaged-short>
        Unknown = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_BUFFER</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_BUFFER</unmanaged-short>
        Buffer = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE1D</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE1D</unmanaged-short>
        Texture1D = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE1DARRAY</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE1DARRAY</unmanaged-short>
        Texture1DArray = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2D</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE2D</unmanaged-short>
        Texture2D = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DARRAY</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE2DARRAY</unmanaged-short>
        Texture2DArray = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DMS</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE2DMS</unmanaged-short>
        Texture2DMultisampled = unchecked((System.Int32)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE2DMSARRAY</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE2DMSARRAY</unmanaged-short>
        Texture2DMultisampledArray = unchecked((System.Int32)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURE3D</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURE3D</unmanaged-short>
        Texture3D = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURECUBE</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURECUBE</unmanaged-short>
        TextureCube = unchecked((System.Int32)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_TEXTURECUBEARRAY</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_TEXTURECUBEARRAY</unmanaged-short>
        TextureCubeArray = unchecked((System.Int32)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_SRV_DIMENSION_BUFFEREX</unmanaged>
        /// <unmanaged-short>D3D_SRV_DIMENSION_BUFFEREX</unmanaged-short>
        ExtendedBuffer = unchecked((System.Int32)(11))
    }
}
