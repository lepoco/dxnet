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
    /// 
    /// </summary>
    [Guid("8BA5FB08-5195-40e2-AC58-0D989C3A0102")]
    public partial class Blob : DXNET.ComObject
    {
        public Blob(System.IntPtr nativePtr) : base(nativePtr)
        {
        }

        public static explicit operator DataPointer(Blob blob)
        {
            return new DataPointer(blob.BufferPointer, blob.BufferSize);
        }

        public static explicit operator Blob(System.IntPtr nativePtr) => nativePtr == System.IntPtr.Zero ? null : new Blob(nativePtr);
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>GetBufferPointer</unmanaged>
        /// <unmanaged-short>GetBufferPointer</unmanaged-short>
        public System.IntPtr BufferPointer
        {
            get => GetBufferPointer();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>GetBufferSize</unmanaged>
        /// <unmanaged-short>GetBufferSize</unmanaged-short>
        public DXNET.PointerSize BufferSize
        {
            get => GetBufferSize();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns>No documentation.</returns>
        /// <unmanaged>void* ID3D10Blob::GetBufferPointer()</unmanaged>
        /// <unmanaged-short>ID3D10Blob::GetBufferPointer</unmanaged-short>
        internal unsafe System.IntPtr GetBufferPointer()
        {
            System.IntPtr __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallSystemIntPtr(this._nativePointer, (*(void***)this._nativePointer)[3]);
            return __result__;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns>No documentation.</returns>
        /// <unmanaged>SIZE_T ID3D10Blob::GetBufferSize()</unmanaged>
        /// <unmanaged-short>ID3D10Blob::GetBufferSize</unmanaged-short>
        internal unsafe DXNET.PointerSize GetBufferSize()
        {
            DXNET.PointerSize __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallvoidPtr(this._nativePointer, (*(void***)this._nativePointer)[4]);
            return __result__;
        }
    }
}