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

namespace DXNET.XInput
{
    /// <summary>
    /// GamepadButtonFlags
    /// </summary>
    [Flags]
    public enum GamepadButtonFlags : ushort
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// DPadUp
        /// </summary>
        DPadUp = 0x0001,

        /// <summary>
        /// DPadDown
        /// </summary>
        DPadDown = 0x0002,

        /// <summary>
        /// DPadLeft
        /// </summary>
        DPadLeft = 0x0004,

        /// <summary>
        /// DPadRight
        /// </summary>
        DPadRight = 0x0008,

        /// <summary>
        /// Start
        /// </summary>
        Start = 0x0010,

        /// <summary>
        /// Back
        /// </summary>
        Back = 0x0020,

        /// <summary>
        /// LeftThumb
        /// </summary>
        LeftThumb = 0x0040,

        /// <summary>
        /// RightThumb
        /// </summary>
        RightThumb = 0x0080,

        /// <summary>
        /// LeftShoulder
        /// </summary>
        LeftShoulder = 0x0100,

        /// <summary>
        /// RightShoulder
        /// </summary>
        RightShoulder = 0x0200,

        /// <summary>
        /// A
        /// </summary>
        A = 0x1000,

        /// <summary>
        /// B
        /// </summary>
        B = 0x2000,

        /// <summary>
        /// X
        /// </summary>
        X = 0x4000,

        /// <summary>
        /// Y
        /// </summary>
        Y = 0x8000
    }
}
