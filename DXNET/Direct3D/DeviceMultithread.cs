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
    /// DeviceMultithread
    /// </summary>
    [Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
    public partial class DeviceMultithread : ComObject
    {
        /// <summary>
        /// DeviceMultithread
        /// </summary>
        /// <param name="nativePtr"></param>
        public DeviceMultithread(IntPtr nativePtr) : base(nativePtr)
        {
        }

        /// <summary>
        /// DeviceMultithread
        /// </summary>
        /// <param name="nativePtr"></param>
        public static explicit operator DeviceMultithread(System.IntPtr nativePtr) => nativePtr == System.IntPtr.Zero ? null : new DeviceMultithread(nativePtr);

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>void ID3D10Multithread::Enter()</unmanaged>
        /// <unmanaged-short>ID3D10Multithread::Enter</unmanaged-short>
        public unsafe void Enter()
        {
            DXNET.LocalInterop.CalliStdCallvoid(this._nativePointer, (*(void***)this._nativePointer)[3]);
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>void ID3D10Multithread::Leave()</unmanaged>
        /// <unmanaged-short>ID3D10Multithread::Leave</unmanaged-short>
        public unsafe void Leave()
        {
            DXNET.LocalInterop.CalliStdCallvoid(this._nativePointer, (*(void***)this._nativePointer)[4]);
        }

        /// <summary>
        /// BOOL ID3D10Multithread::SetMultithreadProtected([In] BOOL bMTProtect)
        /// </summary>
        /// <param name = "bMTProtect">No documentation.</param>
        /// <returns>No documentation.</returns>
        /// <unmanaged>BOOL ID3D10Multithread::SetMultithreadProtected([In] BOOL bMTProtect)</unmanaged>
        /// <unmanaged-short>ID3D10Multithread::SetMultithreadProtected</unmanaged-short>
        public unsafe DXNET.Mathematics.Interop.RawBool SetMultithreadProtected(DXNET.Mathematics.Interop.RawBool bMTProtect)
        {
            DXNET.Mathematics.Interop.RawBool __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallSharpDXMathematicsInteropRawBool0(this._nativePointer, bMTProtect, (*(void***)this._nativePointer)[5]);
            return __result__;
        }

        /// <summary>
        /// No documentation.
        /// </summary>
        /// <returns>No documentation.</returns>
        /// <unmanaged>BOOL ID3D10Multithread::GetMultithreadProtected()</unmanaged>
        /// <unmanaged-short>ID3D10Multithread::GetMultithreadProtected</unmanaged-short>
        public unsafe DXNET.Mathematics.Interop.RawBool GetMultithreadProtected()
        {
            DXNET.Mathematics.Interop.RawBool __result__;
            __result__ = DXNET.LocalInterop.CalliStdCallSharpDXMathematicsInteropRawBool(this._nativePointer, (*(void***)this._nativePointer)[6]);
            return __result__;
        }
    }
}
