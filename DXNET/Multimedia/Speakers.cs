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
// -----------------------------------------------------------------------------
// Original code from NAudio project. http://naudio.codeplex.com/
// Greetings to Mark Heath.
// -----------------------------------------------------------------------------

namespace DXNET.Multimedia
{
    public enum Speakers : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_FRONT_LEFT</unmanaged>
        /// <unmanaged-short>SPEAKER_FRONT_LEFT</unmanaged-short>
        FrontLeft = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_FRONT_RIGHT</unmanaged>
        /// <unmanaged-short>SPEAKER_FRONT_RIGHT</unmanaged-short>
        FrontRight = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_FRONT_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_FRONT_CENTER</unmanaged-short>
        FrontCenter = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_LOW_FREQUENCY</unmanaged>
        /// <unmanaged-short>SPEAKER_LOW_FREQUENCY</unmanaged-short>
        LowFrequency = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_BACK_LEFT</unmanaged>
        /// <unmanaged-short>SPEAKER_BACK_LEFT</unmanaged-short>
        BackLeft = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_BACK_RIGHT</unmanaged>
        /// <unmanaged-short>SPEAKER_BACK_RIGHT</unmanaged-short>
        BackRight = unchecked((System.Int32)(32)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_FRONT_LEFT_OF_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_FRONT_LEFT_OF_CENTER</unmanaged-short>
        FrontLeftOfCenter = unchecked((System.Int32)(64)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_FRONT_RIGHT_OF_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_FRONT_RIGHT_OF_CENTER</unmanaged-short>
        FrontRightOfCenter = unchecked((System.Int32)(128)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_BACK_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_BACK_CENTER</unmanaged-short>
        BackCenter = unchecked((System.Int32)(256)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_SIDE_LEFT</unmanaged>
        /// <unmanaged-short>SPEAKER_SIDE_LEFT</unmanaged-short>
        SideLeft = unchecked((System.Int32)(512)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_SIDE_RIGHT</unmanaged>
        /// <unmanaged-short>SPEAKER_SIDE_RIGHT</unmanaged-short>
        SideRight = unchecked((System.Int32)(1024)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_CENTER</unmanaged-short>
        TopCenter = unchecked((System.Int32)(2048)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_FRONT_LEFT</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_FRONT_LEFT</unmanaged-short>
        TopFrontLeft = unchecked((System.Int32)(4096)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_FRONT_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_FRONT_CENTER</unmanaged-short>
        TopFrontCenter = unchecked((System.Int32)(8192)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_FRONT_RIGHT</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_FRONT_RIGHT</unmanaged-short>
        TopFrontRight = unchecked((System.Int32)(16384)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_BACK_LEFT</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_BACK_LEFT</unmanaged-short>
        TopBackLeft = unchecked((System.Int32)(32768)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_BACK_CENTER</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_BACK_CENTER</unmanaged-short>
        TopBackCenter = unchecked((System.Int32)(65536)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_TOP_BACK_RIGHT</unmanaged>
        /// <unmanaged-short>SPEAKER_TOP_BACK_RIGHT</unmanaged-short>
        TopBackRight = unchecked((System.Int32)(131072)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_RESERVED</unmanaged>
        /// <unmanaged-short>SPEAKER_RESERVED</unmanaged-short>
        Reserved = unchecked((System.Int32)(2147221504)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>SPEAKER_ALL</unmanaged>
        /// <unmanaged-short>SPEAKER_ALL</unmanaged-short>
        All = unchecked((System.Int32)(-2147483648)),
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = unchecked((System.Int32)(0))
    }
}
