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

namespace DXNET.RawInput
{
    /// <summary>
    /// RAW_MOUSE_BUTTON_FLAGS
    /// </summary>
    [Flags]
    public enum MouseButtonFlags : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_LEFT_BUTTON_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_LEFT_BUTTON_DOWN</unmanaged-short>
        LeftButtonDown = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_LEFT_BUTTON_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_LEFT_BUTTON_UP</unmanaged-short>
        LeftButtonUp = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_RIGHT_BUTTON_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_RIGHT_BUTTON_DOWN</unmanaged-short>
        RightButtonDown = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_RIGHT_BUTTON_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_RIGHT_BUTTON_UP</unmanaged-short>
        RightButtonUp = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_MIDDLE_BUTTON_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_MIDDLE_BUTTON_DOWN</unmanaged-short>
        MiddleButtonDown = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_MIDDLE_BUTTON_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_MIDDLE_BUTTON_UP</unmanaged-short>
        MiddleButtonUp = unchecked((System.Int32)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_1_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_1_DOWN</unmanaged-short>
        Button1Down = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_1_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_1_UP</unmanaged-short>
        Button1Up = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_2_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_2_DOWN</unmanaged-short>
        Button2Down = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_2_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_2_UP</unmanaged-short>
        Button2Up = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_3_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_3_DOWN</unmanaged-short>
        Button3Down = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_3_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_3_UP</unmanaged-short>
        Button3Up = unchecked((System.Int32)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_4_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_4_DOWN</unmanaged-short>
        Button4Down = unchecked((System.Int32)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_4_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_4_UP</unmanaged-short>
        Button4Up = unchecked((System.Int32)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_5_DOWN</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_5_DOWN</unmanaged-short>
        Button5Down = unchecked((System.Int32)(256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_BUTTON_5_UP</unmanaged>
        /// <unmanaged-short>RI_MOUSE_BUTTON_5_UP</unmanaged-short>
        Button5Up = unchecked((System.Int32)(512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_WHEEL</unmanaged>
        /// <unmanaged-short>RI_MOUSE_WHEEL</unmanaged-short>
        MouseWheel = unchecked((System.Int32)(1024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>RI_MOUSE_HWHEEL</unmanaged>
        /// <unmanaged-short>RI_MOUSE_HWHEEL</unmanaged-short>
        Hwheel = unchecked((System.Int32)(2048)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int32)(0))
    }
}
