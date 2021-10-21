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
using System.Collections.Generic;

namespace DXNET.DXGI
{
    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>DXGI_COLOR_SPACE_TYPE</unmanaged>
    /// <unmanaged-short>DXGI_COLOR_SPACE_TYPE</unmanaged-short>
    public enum ColorSpaceType : System.Int32
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709</unmanaged-short>
        RgbFullG22NoneP709 = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709</unmanaged-short>
        RgbFullG10NoneP709 = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709</unmanaged-short>
        RgbStudioG22NoneP709 = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020</unmanaged-short>
        RgbStudioG22NoneP2020 = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RESERVED</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RESERVED</unmanaged-short>
        Reserved = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601</unmanaged-short>
        YcbcrFullG22NoneP709X601 = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601</unmanaged-short>
        YcbcrStudioG22LeftP601 = unchecked((System.Int32)(6)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601</unmanaged-short>
        YcbcrFullG22LeftP601 = unchecked((System.Int32)(7)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709</unmanaged-short>
        YcbcrStudioG22LeftP709 = unchecked((System.Int32)(8)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709</unmanaged-short>
        YcbcrFullG22LeftP709 = unchecked((System.Int32)(9)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020</unmanaged-short>
        YcbcrStudioG22LeftP2020 = unchecked((System.Int32)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020</unmanaged-short>
        YcbcrFullG22LeftP2020 = unchecked((System.Int32)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020</unmanaged-short>
        RgbFullG2084NoneP2020 = unchecked((System.Int32)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020</unmanaged-short>
        YcbcrStudioG2084LeftP2020 = unchecked((System.Int32)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020</unmanaged-short>
        RgbStudioG2084NoneP2020 = unchecked((System.Int32)(14)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020</unmanaged-short>
        YcbcrStudioG22TopleftP2020 = unchecked((System.Int32)(15)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020</unmanaged-short>
        YcbcrStudioG2084TopleftP2020 = unchecked((System.Int32)(16)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020</unmanaged-short>
        RgbFullG22NoneP2020 = unchecked((System.Int32)(17)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020</unmanaged-short>
        YcbcrStudioGhlgTopleftP2020 = unchecked((System.Int32)(18)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020</unmanaged-short>
        YcbcrFullGhlgTopleftP2020 = unchecked((System.Int32)(19)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709</unmanaged-short>
        RgbStudioG24NoneP709 = unchecked((System.Int32)(20)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020</unmanaged-short>
        RgbStudioG24NoneP2020 = unchecked((System.Int32)(21)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709</unmanaged-short>
        YcbcrStudioG24LeftP709 = unchecked((System.Int32)(22)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020</unmanaged-short>
        YcbcrStudioG24LeftP2020 = unchecked((System.Int32)(23)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020</unmanaged-short>
        YcbcrStudioG24TopleftP2020 = unchecked((System.Int32)(24)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>DXGI_COLOR_SPACE_CUSTOM</unmanaged>
        /// <unmanaged-short>DXGI_COLOR_SPACE_CUSTOM</unmanaged-short>
        Custom = unchecked((System.Int32)(-1))
    }
}