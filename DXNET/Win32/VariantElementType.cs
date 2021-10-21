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

namespace DXNET.Win32
{
    /// <summary>
    /// Type of a simple variant value.
    /// </summary>
    public enum VariantElementType : ushort
    {
        /// <summary>
        /// <see langword="Empty"/>
        /// </summary>
        Empty = 0,

        /// <summary>
        /// <see langword="null"/>
        /// </summary>
        Null = 1,

        /// <summary>
        /// <see langword="short"/>
        /// </summary>
        Short = 2,

        /// <summary>
        /// <see langword="int"/>
        /// </summary>
        Int = 3,

        /// <summary>
        /// <see langword="float"/>
        /// </summary>
        Float = 4,

        /// <summary>
        /// <see langword="double"/>
        /// </summary>
        Double = 5,

        /// <summary>
        /// <see langword="Currency"/>
        /// </summary>
        Currency = 6,

        /// <summary>
        /// <see langword="Date"/>
        /// </summary>
        Date = 7,

        /// <summary>
        /// <see langword="BinaryString"/>
        /// </summary>
        BinaryString = 8,

        /// <summary>
        /// <see langword="Dispatch"/>
        /// </summary>
        Dispatch = 9,

        /// <summary>
        /// <see langword="Error"/>
        /// </summary>
        Error = 10,

        /// <summary>
        /// <see langword="bool"/>
        /// </summary>
        Bool = 11,

        /// <summary>
        /// <see langword="Variant"/>
        /// </summary>
        Variant = 12,

        /// <summary>
        /// <see langword="Empty"/>
        /// </summary>
        ComUnknown = 13,

        /// <summary>
        /// <see langword="decimal"/>
        /// </summary>
        Decimal = 14,

        /// <summary>
        /// <see langword="byte"/>
        /// </summary>
        Byte = 16,

        /// <summary>
        /// <see langword="UByte"/>
        /// </summary>
        UByte = 17,

        /// <summary>
        /// <see langword="UShort"/>
        /// </summary>
        UShort = 18,

        /// <summary>
        /// <see langword="UInt"/>
        /// </summary>
        UInt = 19,

        /// <summary>
        /// <see langword="long"/>
        /// </summary>
        Long = 20,

        /// <summary>
        /// <see langword="ULong"/>
        /// </summary>
        ULong = 21,

        /// <summary>
        /// <see langword="Int1"/>
        /// </summary>
        Int1 = 22,

        /// <summary>
        /// <see langword="UInt1"/>
        /// </summary>
        UInt1 = 23,

        /// <summary>
        /// <see langword="void"/>
        /// </summary>
        Void = 24,

        /// <summary>
        /// <see langword="result"/>
        /// </summary>
        Result = 25,

        /// <summary>
        /// <see langword="IntPtr"/>
        /// </summary>
        Pointer = 26,

        /// <summary>
        /// <see langword="SaveArray"/>
        /// </summary>
        SafeArray = 27,

        /// <summary>
        /// <see langword="ConstantArray"/>
        /// </summary>
        ConstantArray = 28,

        /// <summary>
        /// <see langword="UserDefined"/>
        /// </summary>
        UserDefined = 29,

        /// <summary>
        /// <see langword="StringPointer"/>
        /// </summary>
        StringPointer = 30,

        /// <summary>
        /// <see langword="WStringPointer"/>
        /// </summary>
        WStringPointer = 31,

        /// <summary>
        /// <see langword="Recor"/>
        /// </summary>
        Recor = 36,

        /// <summary>
        /// <see langword="IntPointer"/>
        /// </summary>
        IntPointer = 37,

        /// <summary>
        /// <see langword="UIntPointer"/>
        /// </summary>
        UIntPointer = 38,

        /// <summary>
        /// <see langword="SaveArray"/>
        /// </summary>
        FileTime = 64,

        /// <summary>
        /// <see langword="Blob"/>
        /// </summary>
        Blob = 65,

        /// <summary>
        /// <see langword="Stream"/>
        /// </summary>
        Stream = 66,

        /// <summary>
        /// <see langword="Storage"/>
        /// </summary>
        Storage = 67,

        /// <summary>
        /// <see langword="StreamedObject"/>
        /// </summary>
        StreamedObject = 68,

        /// <summary>
        /// <see langword="StoredObject"/>
        /// </summary>
        StoredObject = 69,

        /// <summary>
        /// <see langword="BlobObject"/>
        /// </summary>
        BlobObject = 70,

        /// <summary>
        /// <see langword="ClipData"/>
        /// </summary>
        ClipData = 71,

        /// <summary>
        /// <see langword="Clsid"/>
        /// </summary>
        Clsid = 72,

        /// <summary>
        /// <see langword="VersionedStream"/>
        /// </summary>
        VersionedStream = 73,

        /// <summary>
        /// <see langword="BinaryStringBlob"/>
        /// </summary>
        BinaryStringBlob = 0xfff,
    }
}
