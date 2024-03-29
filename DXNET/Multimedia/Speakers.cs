﻿// Copyright (c) 2021 DXNET - Pomianowski Leszek & Contributors
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
// -----------------------------------------------------------------------------
// Original code from NAudio project. http://naudio.codeplex.com/
// Greetings to Mark Heath.
// -----------------------------------------------------------------------------

namespace DXNET.Multimedia
{
    /// <summary>
    /// SPEAKER
    /// </summary>
    public enum Speakers : int
    {
        /// <summary>
        /// SPEAKER_FRONT_LEFT
        /// </summary>
        FrontLeft = 1,

        /// <summary>
        /// SPEAKER_FRONT_RIGHT
        /// </summary>
        FrontRight = 2,

        /// <summary>
        /// SPEAKER_FRONT_CENTER
        /// </summary>
        FrontCenter = 4,

        /// <summary>
        /// SPEAKER_LOW_FREQUENCY
        /// </summary>
        LowFrequency = 8,

        /// <summary>
        /// SPEAKER_BACK_LEFT
        /// </summary>
        BackLeft = 16,

        /// <summary>
        /// SPEAKER_BACK_RIGHT
        /// </summary>
        BackRight = 32,

        /// <summary>
        /// SPEAKER_FRONT_LEFT_OF_CENTER
        /// </summary>
        FrontLeftOfCenter = 64,

        /// <summary>
        /// SPEAKER_FRONT_RIGHT_OF_CENTER
        /// </summary>
        FrontRightOfCenter = 128,

        /// <summary>
        /// SPEAKER_BACK_CENTER
        /// </summary>
        BackCenter = 256,

        /// <summary>
        /// SPEAKER_SIDE_LEFT
        /// </summary>
        SideLeft = 512,

        /// <summary>
        /// SPEAKER_SIDE_RIGHT
        /// </summary>
        SideRight = 1024,

        /// <summary>
        /// SPEAKER_TOP_CENTER
        /// </summary>
        TopCenter = 2048,

        /// <summary>
        /// SPEAKER_TOP_FRONT_LEFT
        /// </summary>
        TopFrontLeft = 4096,

        /// <summary>
        /// SPEAKER_TOP_FRONT_CENTER
        /// </summary>
        TopFrontCenter = 8192,

        /// <summary>
        /// SPEAKER_TOP_FRONT_RIGHT
        /// </summary>
        TopFrontRight = 16384,

        /// <summary>
        /// SPEAKER_TOP_BACK_LEFT
        /// </summary>
        TopBackLeft = 32768,

        /// <summary>
        /// SPEAKER_TOP_BACK_CENTER
        /// </summary>
        TopBackCenter = 65536,

        /// <summary>
        /// SPEAKER_TOP_BACK_RIGHT
        /// </summary>
        TopBackRight = 131072,

        /// <summary>
        /// SPEAKER_RESERVED
        /// </summary>
        Reserved = 2147221504,

        /// <summary>
        /// SPEAKER_ALL
        /// </summary>
        All = -2147483648,

        /// <summary>
        /// None
        /// </summary>
        None = 0
    }
}
