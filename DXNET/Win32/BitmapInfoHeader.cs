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

using System.Runtime.InteropServices;

namespace DXNET.Win32
{
    /// <summary>
    /// BitmapInfoHeader
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BitmapInfoHeader
    {
        /// <summary>
        /// SizeInBytes
        /// </summary>
        public int SizeInBytes;

        /// <summary>
        /// Width
        /// </summary>
        public int Width;

        /// <summary>
        /// Height
        /// </summary>
        public int Height;

        /// <summary>
        /// PlaneCount
        /// </summary>
        public short PlaneCount;

        /// <summary>
        /// BitCount
        /// </summary>
        public short BitCount;

        /// <summary>
        /// Compression
        /// </summary>
        public int Compression;

        /// <summary>
        /// SizeImage
        /// </summary>
        public int SizeImage;

        /// <summary>
        /// XPixelsPerMeter
        /// </summary>
        public int XPixelsPerMeter;

        /// <summary>
        /// YPixelsPerMeter
        /// </summary>
        public int YPixelsPerMeter;

        /// <summary>
        /// ColorUsedCount
        /// </summary>
        public int ColorUsedCount;

        /// <summary>
        /// ColorImportantCount
        /// </summary>
        public int ColorImportantCount;
    }
}