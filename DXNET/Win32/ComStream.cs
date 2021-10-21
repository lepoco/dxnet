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
    /// ComStream
    /// </summary>
    [Guid("0000000c-0000-0000-C000-000000000046")]
    public partial class ComStream : ComStreamBase, IStream
    {
        /// <summary>
        /// ComStream
        /// </summary>
        /// <param name="nativePtr"></param>
        public ComStream(IntPtr nativePtr) : base(nativePtr)
        {
        }

        /// <summary>
        /// ComStream
        /// </summary>
        /// <param name="nativePtr"></param>

        public static explicit operator ComStream(IntPtr nativePtr) => nativePtr == IntPtr.Zero ? null : new ComStream(nativePtr);
        
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "dlibMove">No documentation.</param>
        /// <param name = "dwOrigin">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::Seek([In] LARGE_INTEGER dlibMove,[In] DWORD dwOrigin,[Out, Optional] ULARGE_INTEGER* plibNewPosition)</unmanaged>
        /// <unmanaged-short>IStream::Seek</unmanaged-short>
        public unsafe System.Int64 Seek(System.Int64 dlibMove, System.IO.SeekOrigin dwOrigin)
        {
            System.Int64 libNewPositionRef;
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, dlibMove, unchecked((System.UInt32)dwOrigin), &libNewPositionRef, (*(void***)this._nativePointer)[5]);
            __result__.CheckError();
            return libNewPositionRef;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "libNewSize">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::SetSize([In] ULARGE_INTEGER libNewSize)</unmanaged>
        /// <unmanaged-short>IStream::SetSize</unmanaged-short>
        public unsafe void SetSize(System.Int64 libNewSize)
        {
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, libNewSize, (*(void***)this._nativePointer)[6]);
            __result__.CheckError();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "stmRef">No documentation.</param>
        /// <param name = "cb">No documentation.</param>
        /// <param name = "cbWrittenRef">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::CopyTo([In] IStream* pstm,[In] ULARGE_INTEGER cb,[Out] ULARGE_INTEGER* pcbRead,[Out] ULARGE_INTEGER* pcbWritten)</unmanaged>
        /// <unmanaged-short>IStream::CopyTo</unmanaged-short>
        public unsafe System.Int64 CopyTo(DXNET.Win32.IStream stmRef, System.Int64 cb, out System.Int64 cbWrittenRef)
        {
            System.IntPtr stmRef_ = System.IntPtr.Zero;
            System.Int64 cbReadRef;
            DXNET.Result __result__;
            stmRef_ = DXNET.CppObject.ToCallbackPtr<DXNET.Win32.IStream>(stmRef);
            fixed (void* cbWrittenRef_ = &cbWrittenRef)
                __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, (void*)stmRef_, cb, &cbReadRef, cbWrittenRef_, (*(void***)this._nativePointer)[7]);
            __result__.CheckError();
            return cbReadRef;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "grfCommitFlags">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::Commit([In] DWORD grfCommitFlags)</unmanaged>
        /// <unmanaged-short>IStream::Commit</unmanaged-short>
        public unsafe void Commit(DXNET.Win32.CommitFlags grfCommitFlags)
        {
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, unchecked((System.Int32)grfCommitFlags), (*(void***)this._nativePointer)[8]);
            __result__.CheckError();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::Revert()</unmanaged>
        /// <unmanaged-short>IStream::Revert</unmanaged-short>
        public unsafe void Revert()
        {
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, (*(void***)this._nativePointer)[9]);
            __result__.CheckError();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "libOffset">No documentation.</param>
        /// <param name = "cb">No documentation.</param>
        /// <param name = "dwLockType">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::LockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] DWORD dwLockType)</unmanaged>
        /// <unmanaged-short>IStream::LockRegion</unmanaged-short>
        public unsafe void LockRegion(System.Int64 libOffset, System.Int64 cb, DXNET.Win32.LockType dwLockType)
        {
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, libOffset, cb, unchecked((System.Int32)dwLockType), (*(void***)this._nativePointer)[10]);
            __result__.CheckError();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "libOffset">No documentation.</param>
        /// <param name = "cb">No documentation.</param>
        /// <param name = "dwLockType">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::UnlockRegion([In] ULARGE_INTEGER libOffset,[In] ULARGE_INTEGER cb,[In] DWORD dwLockType)</unmanaged>
        /// <unmanaged-short>IStream::UnlockRegion</unmanaged-short>
        public unsafe void UnlockRegion(System.Int64 libOffset, System.Int64 cb, DXNET.Win32.LockType dwLockType)
        {
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, libOffset, cb, unchecked((System.Int32)dwLockType), (*(void***)this._nativePointer)[11]);
            __result__.CheckError();
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <param name = "grfStatFlag">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::Stat([Out] STATSTG* pstatstg,[In] DWORD grfStatFlag)</unmanaged>
        /// <unmanaged-short>IStream::Stat</unmanaged-short>
        public unsafe DXNET.Win32.StorageStatistics GetStatistics(DXNET.Win32.StorageStatisticsFlags grfStatFlag)
        {
            DXNET.Win32.StorageStatistics statstgRef;
            DXNET.Win32.StorageStatistics.__Native statstgRef_ = default(DXNET.Win32.StorageStatistics.__Native);
            statstgRef = default(DXNET.Win32.StorageStatistics);
            DXNET.Result __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, &statstgRef_, unchecked((System.Int32)grfStatFlag), (*(void***)this._nativePointer)[12]);
            statstgRef.__MarshalFrom(ref statstgRef_);
            __result__.CheckError();
            return statstgRef;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns>No documentation.</returns>
        /// <unmanaged>HRESULT IStream::Clone([Out] IStream** ppstm)</unmanaged>
        /// <unmanaged-short>IStream::Clone</unmanaged-short>
        public unsafe IStream Clone()
        {
            IStream stmOut;
            IntPtr stmOut_ = System.IntPtr.Zero;
            DXNET.Result __result__;
            
            __result__ = DXNET.LocalInterop.CalliStdCallint(this._nativePointer, &stmOut_, (*(void***)this._nativePointer)[13]);
            if (stmOut_ != System.IntPtr.Zero)
                stmOut = new DXNET.Win32.ComStream(stmOut_);
            else
                stmOut = null;
            __result__.CheckError();
            return stmOut;
        }
    }
}
