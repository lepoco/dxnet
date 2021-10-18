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
    public enum DeviceSubType : System.Byte
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GAMEPAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GAMEPAD</unmanaged-short>
        Gamepad = unchecked((System.Byte)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_UNKNOWN</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_UNKNOWN</unmanaged-short>
        Unknown = unchecked((System.Byte)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_WHEEL</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_WHEEL</unmanaged-short>
        Wheel = unchecked((System.Byte)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_ARCADE_STICK</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_ARCADE_STICK</unmanaged-short>
        ArcadeStick = unchecked((System.Byte)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_FLIGHT_STICK</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_FLIGHT_STICK</unmanaged-short>
        FlightStick = unchecked((System.Byte)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_DANCE_PAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_DANCE_PAD</unmanaged-short>
        DancePad = unchecked((System.Byte)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR</unmanaged-short>
        Guitar = unchecked((System.Byte)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE</unmanaged-short>
        GuitarAlternate = unchecked((System.Byte)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_DRUM_KIT</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_DRUM_KIT</unmanaged-short>
        DrumKit = unchecked((System.Byte)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_GUITAR_BASS</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_GUITAR_BASS</unmanaged-short>
        GuitarBass = unchecked((System.Byte)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_DEVSUBTYPE_ARCADE_PAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVSUBTYPE_ARCADE_PAD</unmanaged-short>
        ArcadePad = unchecked((System.Byte)(19))
    }
}
