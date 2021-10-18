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
    public enum FeatureLevel : System.Int32
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_9_1</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_9_1</unmanaged-short>
        Level_9_1 = unchecked((System.Int32)(37120)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_9_2</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_9_2</unmanaged-short>
        Level_9_2 = unchecked((System.Int32)(37376)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_9_3</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_9_3</unmanaged-short>
        Level_9_3 = unchecked((System.Int32)(37632)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_10_0</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_10_0</unmanaged-short>
        Level_10_0 = unchecked((System.Int32)(40960)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_10_1</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_10_1</unmanaged-short>
        Level_10_1 = unchecked((System.Int32)(41216)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_11_0</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_11_0</unmanaged-short>
        Level_11_0 = unchecked((System.Int32)(45056)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_11_1</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_11_1</unmanaged-short>
        Level_11_1 = unchecked((System.Int32)(45312)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_12_0</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_12_0</unmanaged-short>
        Level_12_0 = unchecked((System.Int32)(49152)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_FEATURE_LEVEL_12_1</unmanaged>
        /// <unmanaged-short>D3D_FEATURE_LEVEL_12_1</unmanaged-short>
        Level_12_1 = unchecked((System.Int32)(49408))
    }
}
