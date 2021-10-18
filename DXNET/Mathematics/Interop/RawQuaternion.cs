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

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DXNET.Mathematics.Interop
{
    /// <summary>
    /// Interop type for a Quaternion (4 floats).
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [DebuggerDisplay("X: {X}, Y: {Y}, Z: {Z}, W: {W}")]
    public struct RawQuaternion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RawQuaternion"/> struct.
        /// </summary>
        /// <param name="x">The X.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        /// <param name="w">The w.</param>
        public RawQuaternion(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// The X component of the quaternion.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the quaternion.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the quaternion.
        /// </summary>
        public float Z;

        /// <summary>
        /// The W component of the quaternion.
        /// </summary>
        public float W;
    }
}
