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

namespace DXNET.Win32
{
    /// <summary>
    /// ComStreamBase
    /// </summary>
    [Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public partial class ComStreamBase : DXNET.ComObject, IStreamBase
    {
        /// <summary>
        /// ComStreamBase
        /// </summary>
        /// <param name="nativePtr"></param>
        public ComStreamBase(System.IntPtr nativePtr) : base(nativePtr)
        {
        }

        /// <summary>
        /// ComStreamBase
        /// </summary>
        /// <param name="nativePtr"></param>
        public static explicit operator ComStreamBase(System.IntPtr nativePtr) => nativePtr == System.IntPtr.Zero ? null : new ComStreamBase(nativePtr);

        /// <summary>
        /// ISequentialStream::Read
        /// </summary>
        /// <param name = "vRef">No documentation.</param>
        /// <param name = "cb">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT ISequentialStream::Read([Out, Buffer] void* pv,[In] ULONG cb,[Out, Optional] ULONG* pcbRead)</unmanaged>
        public unsafe int Read(IntPtr vRef, int cb)
        {
            int cbReadRef;
            DXNET.Result __result__;

            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, (void*)vRef, cb, &cbReadRef, (*(void***)this._nativePointer)[3]);
            __result__.CheckError();
            return cbReadRef;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "vRef">No documentation.</param>
        /// <param name = "cb">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT ISequentialStream::Write([In, Buffer] const void* pv,[In] ULONG cb,[Out, Optional] ULONG* pcbWritten)</unmanaged>
        /// <unmanaged-short>ISequentialStream::Write</unmanaged-short>
        public unsafe System.Int32 Write(System.IntPtr vRef, System.Int32 cb)
        {
            System.Int32 cbWrittenRef;
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, (void*)vRef, cb, &cbWrittenRef, (*(void***)this._nativePointer)[4]);
            __result__.CheckError();
            return cbWrittenRef;
        }
    }
}
