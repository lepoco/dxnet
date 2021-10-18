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
    public enum InterpolationMode : System.Int32
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_UNDEFINED</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_UNDEFINED</unmanaged-short>
        Undefined = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_CONSTANT</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_CONSTANT</unmanaged-short>
        Constant = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR</unmanaged-short>
        Linear = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR_CENTROID</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR_CENTROID</unmanaged-short>
        LinearCentroid = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE</unmanaged-short>
        LinearNoperspective = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID</unmanaged-short>
        LinearNoperspectiveCentroid = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR_SAMPLE</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR_SAMPLE</unmanaged-short>
        LinearSample = unchecked((System.Int32)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE</unmanaged>
        /// <unmanaged-short>D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE</unmanaged-short>
        LinearNoperspectiveSample = unchecked((System.Int32)(7))
    }
}
