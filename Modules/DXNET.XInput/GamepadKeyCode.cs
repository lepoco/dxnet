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
    public enum GamepadKeyCode : System.Int16
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_A</unmanaged>
        /// <unmanaged-short>VK_PAD_A</unmanaged-short>
        A = unchecked((System.Int16)(22528)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_B</unmanaged>
        /// <unmanaged-short>VK_PAD_B</unmanaged-short>
        B = unchecked((System.Int16)(22529)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_X</unmanaged>
        /// <unmanaged-short>VK_PAD_X</unmanaged-short>
        X = unchecked((System.Int16)(22530)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_Y</unmanaged>
        /// <unmanaged-short>VK_PAD_Y</unmanaged-short>
        Y = unchecked((System.Int16)(22531)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_RSHOULDER</unmanaged-short>
        RightShoulder = unchecked((System.Int16)(22532)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_LSHOULDER</unmanaged-short>
        LeftShoulder = unchecked((System.Int16)(22533)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_LTRIGGER</unmanaged-short>
        LeftTrigger = unchecked((System.Int16)(22534)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_RTRIGGER</unmanaged-short>
        RightTrigger = unchecked((System.Int16)(22535)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_UP</unmanaged-short>
        DPadUp = unchecked((System.Int16)(22544)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_DOWN</unmanaged-short>
        DPadDown = unchecked((System.Int16)(22545)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_LEFT</unmanaged-short>
        DPadLeft = unchecked((System.Int16)(22546)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_RIGHT</unmanaged-short>
        DPadRight = unchecked((System.Int16)(22547)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_START</unmanaged>
        /// <unmanaged-short>VK_PAD_START</unmanaged-short>
        Start = unchecked((System.Int16)(22548)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_BACK</unmanaged>
        /// <unmanaged-short>VK_PAD_BACK</unmanaged-short>
        Back = unchecked((System.Int16)(22549)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_PRESS</unmanaged-short>
        LeftThumbPress = unchecked((System.Int16)(22550)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_PRESS</unmanaged-short>
        RightThumbPress = unchecked((System.Int16)(22551)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UP</unmanaged-short>
        LeftThumbUp = unchecked((System.Int16)(22560)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWN</unmanaged-short>
        LeftThumbDown = unchecked((System.Int16)(22561)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_RIGHT</unmanaged-short>
        LeftThumbRight = unchecked((System.Int16)(22562)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_LEFT</unmanaged-short>
        LeftThumbLeft = unchecked((System.Int16)(22563)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpLeft = unchecked((System.Int16)(22564)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPRIGHT</unmanaged-short>
        LeftThumbUpright = unchecked((System.Int16)(22565)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged-short>
        LeftThumbDownright = unchecked((System.Int16)(22566)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownLeft = unchecked((System.Int16)(22567)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UP</unmanaged-short>
        RightThumbUp = unchecked((System.Int16)(22576)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWN</unmanaged-short>
        RightThumbDown = unchecked((System.Int16)(22577)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_RIGHT</unmanaged-short>
        RightThumbRight = unchecked((System.Int16)(22578)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_LEFT</unmanaged-short>
        RightThumbLeft = unchecked((System.Int16)(22579)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpleft = unchecked((System.Int16)(22580)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPRIGHT</unmanaged-short>
        RightThumbUpRight = unchecked((System.Int16)(22581)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged-short>
        RightThumbDownRight = unchecked((System.Int16)(22582)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownleft = unchecked((System.Int16)(22583)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int16)(0))
    }
}
