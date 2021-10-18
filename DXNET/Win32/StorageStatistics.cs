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

namespace DXNET.Win32
{
    public partial struct StorageStatistics
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>pwcsName</unmanaged>
        /// <unmanaged-short>pwcsName</unmanaged-short>
        public System.String PwcsName;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>type</unmanaged>
        /// <unmanaged-short>type</unmanaged-short>
        public System.Int32 Type;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>cbSize</unmanaged>
        /// <unmanaged-short>cbSize</unmanaged-short>
        public System.Int64 CbSize;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>mtime</unmanaged>
        /// <unmanaged-short>mtime</unmanaged-short>
        public System.Int64 Mtime;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>ctime</unmanaged>
        /// <unmanaged-short>ctime</unmanaged-short>
        public System.Int64 Ctime;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>atime</unmanaged>
        /// <unmanaged-short>atime</unmanaged-short>
        public System.Int64 Atime;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>grfMode</unmanaged>
        /// <unmanaged-short>grfMode</unmanaged-short>
        public System.Int32 GrfMode;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>grfLocksSupported</unmanaged>
        /// <unmanaged-short>grfLocksSupported</unmanaged-short>
        public System.Int32 GrfLocksSupported;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>clsid</unmanaged>
        /// <unmanaged-short>clsid</unmanaged-short>
        public System.Guid Clsid;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>grfStateBits</unmanaged>
        /// <unmanaged-short>grfStateBits</unmanaged-short>
        public System.Int32 GrfStateBits;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>reserved</unmanaged>
        /// <unmanaged-short>reserved</unmanaged-short>
        public System.Int32 Reserved;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        internal partial struct __Native
        {
            public System.IntPtr PwcsName;
            public System.Int32 Type;
            public System.Int64 CbSize;
            public System.Int64 Mtime;
            public System.Int64 Ctime;
            public System.Int64 Atime;
            public System.Int32 GrfMode;
            public System.Int32 GrfLocksSupported;
            public System.Guid Clsid;
            public System.Int32 GrfStateBits;
            public System.Int32 Reserved;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal(@ref.PwcsName);
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            PwcsName = System.Runtime.InteropServices.Marshal.PtrToStringUni(@ref.PwcsName);
            Type = @ref.Type;
            CbSize = @ref.CbSize;
            Mtime = @ref.Mtime;
            Ctime = @ref.Ctime;
            Atime = @ref.Atime;
            GrfMode = @ref.GrfMode;
            GrfLocksSupported = @ref.GrfLocksSupported;
            Clsid = @ref.Clsid;
            GrfStateBits = @ref.GrfStateBits;
            Reserved = @ref.Reserved;
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.PwcsName = System.Runtime.InteropServices.Marshal.StringToHGlobalUni(PwcsName);
            @ref.Type = Type;
            @ref.CbSize = CbSize;
            @ref.Mtime = Mtime;
            @ref.Ctime = Ctime;
            @ref.Atime = Atime;
            @ref.GrfMode = GrfMode;
            @ref.GrfLocksSupported = GrfLocksSupported;
            @ref.Clsid = Clsid;
            @ref.GrfStateBits = GrfStateBits;
            @ref.Reserved = Reserved;
        }
    }
}
