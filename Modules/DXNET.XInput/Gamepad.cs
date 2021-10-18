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

namespace DXNET.XInput
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct Gamepad
    {
        public const short LeftThumbDeadZone = 7849;
        ///<summary>Constant RightThumbDeadZone</summary>
        ///<unmanaged>XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE</unmanaged>
        public const short RightThumbDeadZone = 8689;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>wButtons</unmanaged>
        /// <unmanaged-short>wButtons</unmanaged-short>
        public DXNET.XInput.GamepadButtonFlags Buttons;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>bLeftTrigger</unmanaged>
        /// <unmanaged-short>bLeftTrigger</unmanaged-short>
        public System.Byte LeftTrigger;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>bRightTrigger</unmanaged>
        /// <unmanaged-short>bRightTrigger</unmanaged-short>
        public System.Byte RightTrigger;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>sThumbLX</unmanaged>
        /// <unmanaged-short>sThumbLX</unmanaged-short>
        public System.Int16 LeftThumbX;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>sThumbLY</unmanaged>
        /// <unmanaged-short>sThumbLY</unmanaged-short>
        public System.Int16 LeftThumbY;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>sThumbRX</unmanaged>
        /// <unmanaged-short>sThumbRX</unmanaged-short>
        public System.Int16 RightThumbX;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>sThumbRY</unmanaged>
        /// <unmanaged-short>sThumbRY</unmanaged-short>
        public System.Int16 RightThumbY;

        /// <summary>Constant TriggerThreshold.</summary>
        /// <unmanaged>XINPUT_GAMEPAD_TRIGGER_THRESHOLD</unmanaged>
        public const byte TriggerThreshold = unchecked((byte)30u);

        public override string ToString()
        {
            return string.Format("Buttons: {0}, LeftTrigger: {1}, RightTrigger: {2}, LeftThumbX: {3}, LeftThumbY: {4}, RightThumbX: {5}, RightThumbY: {6}", Buttons, LeftTrigger, RightTrigger, LeftThumbX, LeftThumbY, RightThumbX, RightThumbY);
        }
    }
}

