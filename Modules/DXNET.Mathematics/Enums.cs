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
// Original code from SlimMath project. http://code.google.com/p/slimmath/
// Greetings to SlimDX Group. Original code published with the following license:
// -----------------------------------------------------------------------------
/*
* Copyright (c) 2007-2011 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

namespace DXNET
{
    /*
     * The enumerations defined in this file are in alphabetical order. When
     * adding new enumerations or renaming existing ones, please make sure
     * the ordering is maintained.
    */

    /// <summary>
    /// Describes the type of angle.
    /// </summary>
    public enum AngleType
    {
        /// <summary>
        /// Specifies an angle measurement in revolutions.
        /// </summary>
        Revolution,

        /// <summary>
        /// Specifies an angle measurement in degrees.
        /// </summary>
        Degree,

        /// <summary>
        /// Specifies an angle measurement in radians.
        /// </summary>
        Radian,

        /// <summary>
        /// Specifies an angle measurement in gradians.
        /// </summary>
        Gradian
    }

	/// <summary>
	/// Describes how one bounding volume contains another.
	/// </summary>
	public enum ContainmentType
	{
		/// <summary>
		/// The two bounding volumes don't intersect at all.
		/// </summary>
		Disjoint,

		/// <summary>
		/// One bounding volume completely contains another.
		/// </summary>
		Contains,

		/// <summary>
		/// The two bounding volumes overlap.
		/// </summary>
		Intersects
	};
	
	/// <summary>
	/// Describes the result of an intersection with a plane in three dimensions.
	/// </summary>
	public enum PlaneIntersectionType
	{
		/// <summary>
		/// The object is behind the plane.
		/// </summary>
		Back,

		/// <summary>
		/// The object is in front of the plane.
		/// </summary>
		Front,

		/// <summary>
		/// The object is intersecting the plane.
		/// </summary>
		Intersecting
	};
}
