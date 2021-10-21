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
    /// XINPUT_KEYSTROKE_FLAGS
    /// </summary>
    [Flags]
    public enum GamepadKeyCode : short
    {
        /// <summary>
        /// VK_PAD_A
        /// </summary>
        A = 22528,

        /// <summary>
        /// VK_PAD_B
        /// </summary>
        B = 22529,

        /// <summary>
        /// VK_PAD_X
        /// </summary>
        X = 22530,

        /// <summary>
        /// VK_PAD_Y
        /// </summary>
        Y = 22531,

        /// <summary>
        /// VK_PAD_RSHOULDER
        /// </summary>
        RightShoulder = 22532,

        /// <summary>
        /// VK_PAD_LSHOULDER
        /// </summary>
        LeftShoulder = 22533,

        /// <summary>
        /// VK_PAD_LTRIGGER
        /// </summary>
        LeftTrigger = 22534,

        /// <summary>
        /// VK_PAD_RTRIGGER
        /// </summary>
        RightTrigger = 22535,

        /// <summary>
        /// VK_PAD_DPAD_UP
        /// </summary>
        DPadUp = 22544,

        /// <summary>
        /// VK_PAD_DPAD_DOWN
        /// </summary>
        DPadDown = 22545,

        /// <summary>
        /// VK_PAD_DPAD_LEFT
        /// </summary>
        DPadLeft = 22546,

        /// <summary>
        /// VK_PAD_DPAD_RIGHT
        /// </summary>
        DPadRight = 22547,

        /// <summary>
        /// VK_PAD_START
        /// </summary>
        Start = 22548,

        /// <summary>
        /// VK_PAD_BACK
        /// </summary>
        Back = 22549,

        /// <summary>
        /// VK_PAD_LTHUMB_PRESS
        /// </summary>
        LeftThumbPress = 22550,

        /// <summary>
        /// VK_PAD_RTHUMB_PRESS
        /// </summary>
        RightThumbPress = 22551,

        /// <summary>
        /// VK_PAD_LTHUMB_UP
        /// </summary>
        LeftThumbUp = 22560,

        /// <summary>
        /// VK_PAD_LTHUMB_DOWN
        /// </summary>
        LeftThumbDown = 22561,

        /// <summary>
        /// VK_PAD_LTHUMB_RIGHT
        /// </summary>
        LeftThumbRight = 22562,

        /// <summary>
        /// VK_PAD_LTHUMB_LEFT
        /// </summary>
        LeftThumbLeft = 22563,

        /// <summary>
        /// VK_PAD_LTHUMB_UPLEFT
        /// </summary>
        RightThumbUpLeft = 22564,

        /// <summary>
        /// VK_PAD_LTHUMB_UPRIGHT
        /// </summary>
        LeftThumbUpright = 22565,

        /// <summary>
        /// VK_PAD_LTHUMB_DOWNRIGHT
        /// </summary>
        LeftThumbDownright = 22566,

        /// <summary>
        /// VK_PAD_LTHUMB_DOWNLEFT
        /// </summary>
        RightThumbDownLeft = 22567,

        /// <summary>
        /// VK_PAD_RTHUMB_UP
        /// </summary>
        RightThumbUp = 22576,

        /// <summary>
        /// VK_PAD_RTHUMB_DOWN
        /// </summary>
        RightThumbDown = unchecked((System.Int16)(22577)),

        /// <summary>
        /// VK_PAD_RTHUMB_RIGHT
        /// </summary>
        RightThumbRight = unchecked((System.Int16)(22578)),

        /// <summary>
        /// VK_PAD_RTHUMB_LEFT
        /// </summary>
        RightThumbLeft = 22579,

        /// <summary>
        /// VK_PAD_RTHUMB_UPLEFT
        /// </summary>
        RightThumbUpleft = 22580,

        /// <summary>
        /// VK_PAD_RTHUMB_UPRIGHT
        /// </summary>
        RightThumbUpRight = 22581,

        /// <summary>
        /// VK_PAD_RTHUMB_DOWNRIGHT
        /// </summary>
        RightThumbDownRight = 22582,

        /// <summary>
        /// VK_PAD_RTHUMB_DOWNLEFT
        /// </summary>
        RightThumbDownleft = 22583,

        /// <summary>
        /// None
        /// </summary>
        None = 0
    }
}
