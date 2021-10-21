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
    /// <summary>
    /// AUDIO_STREAM_CATEGORY
    /// </summary>
    public enum AudioStreamCategory : int
    {
        /// <summary>
        /// AudioCategory_Other
        /// </summary>
        Other = 0,

        /// <summary>
        /// AudioCategory_ForegroundOnlyMedia
        /// </summary>
        ForegroundOnlyMedia = 1,

        /// <summary>
        /// AudioCategory_Communications
        /// </summary>
        Communications = 3,

        /// <summary>
        /// AudioCategory_Alerts
        /// </summary>
        Alerts = 4,

        /// <summary>
        /// AudioCategory_SoundEffects
        /// </summary>
        SoundEffects = 5,

        /// <summary>
        /// AudioCategory_GameEffects
        /// </summary>
        GameEffects = 6,

        /// <summary>
        /// AudioCategory_GameMedia
        /// </summary>
        GameMedia = 7,

        /// <summary>
        /// AudioCategory_GameChat
        /// </summary>
        GameChat = 8,

        /// <summary>
        /// AudioCategory_Speech
        /// </summary>
        Speech = 9,

        /// <summary>
        /// AudioCategory_Movie
        /// </summary>
        Movie = 10,

        /// <summary>
        /// AudioCategory_Media
        /// </summary>
        Media = 11
    }
}
