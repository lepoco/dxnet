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
    /// STATSTG
    /// </summary>
    public partial struct StorageStatistics
    {
        /// <summary>
        /// pwcsName
        /// </summary>
        public string PwcsName;

        /// <summary>
        /// type
        /// </summary>
        public int Type;

        /// <summary>
        /// cbSize
        /// </summary>
        public long CbSize;

        /// <summary>
        /// mtime
        /// </summary>
        public long Mtime;

        /// <summary>
        /// ctime
        /// </summary>
        public long Ctime;

        /// <summary>
        /// atime
        /// </summary>
        public long Atime;

        /// <summary>
        /// grfMode
        /// </summary>
        public int GrfMode;

        /// <summary>
        /// grfLocksSupported
        /// </summary>
        public int GrfLocksSupported;

        /// <summary>
        /// clsid
        /// </summary>
        public Guid Clsid;

        /// <summary>
        /// grfStateBits
        /// </summary>
        public int GrfStateBits;

        /// <summary>
        /// reserved
        /// </summary>
        public int Reserved;
        
        [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
        internal partial struct __Native
        {
            public IntPtr PwcsName;
            public int Type;
            public long CbSize;
            public long Mtime;
            public long Ctime;
            public long Atime;
            public int GrfMode;
            public int GrfLocksSupported;
            public Guid Clsid;
            public int GrfStateBits;
            public int Reserved;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            Marshal.FreeHGlobal(@ref.PwcsName);
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            PwcsName = Marshal.PtrToStringUni(@ref.PwcsName);
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
            @ref.PwcsName = Marshal.StringToHGlobalUni(PwcsName);
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
