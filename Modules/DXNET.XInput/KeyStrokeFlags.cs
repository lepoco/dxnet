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
    /// No documentation.
    /// </summary>
    /// <unmanaged>XINPUT_KEYSTROKE_FLAGS</unmanaged>
    /// <unmanaged-short>XINPUT_KEYSTROKE_FLAGS</unmanaged-short>
    [Flags]
    public enum KeyStrokeFlags : System.Int16
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_KEYDOWN</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_KEYDOWN</unmanaged-short>
        KeyDown = unchecked((System.Int16)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_KEYUP</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_KEYUP</unmanaged-short>
        KeyUp = unchecked((System.Int16)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_REPEAT</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_REPEAT</unmanaged-short>
        Repeat = unchecked((System.Int16)(4)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int16)(0))
    }
}
