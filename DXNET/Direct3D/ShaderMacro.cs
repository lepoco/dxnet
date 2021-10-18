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

namespace DXNET.Direct3D
{
    public partial struct ShaderMacro : IEquatable<ShaderMacro>
    {
        public System.String Name;

        public System.String Definition;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderMacro"/> struct. 
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="definition">
        /// The definition.
        /// </param>
        public ShaderMacro(string name, object definition)
        {
            Name = name;
            Definition = definition == null ? null : definition.ToString();
        }

        public bool Equals(ShaderMacro other)
        {
            return string.Equals(this.Name, other.Name) && string.Equals(this.Definition, other.Definition);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is ShaderMacro && Equals((ShaderMacro)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Name != null ? this.Name.GetHashCode() : 0) * 397) ^ (this.Definition != null ? this.Definition.GetHashCode() : 0);
            }
        }

        public static bool operator ==(ShaderMacro left, ShaderMacro right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ShaderMacro left, ShaderMacro right)
        {
            return !left.Equals(right);
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        internal partial struct __Native
        {
            public System.IntPtr Name;
            public System.IntPtr Definition;
        }

        internal unsafe void __MarshalFree(ref __Native @ref)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal(@ref.Name);
            System.Runtime.InteropServices.Marshal.FreeHGlobal(@ref.Definition);
        }

        internal unsafe void __MarshalFrom(ref __Native @ref)
        {
            Name = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(@ref.Name);
            Definition = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(@ref.Definition);
        }

        internal unsafe void __MarshalTo(ref __Native @ref)
        {
            @ref.Name = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(Name);
            @ref.Definition = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(Definition);
        }
    }
}