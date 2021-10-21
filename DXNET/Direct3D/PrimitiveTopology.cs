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

namespace DXNET.Direct3D
{
    /// <summary>
    /// D3D_PRIMITIVE_TOPOLOGY
    /// </summary>
    public enum PrimitiveTopology : int
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_UNDEFINED</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_UNDEFINED</unmanaged-short>
        Undefined = unchecked((System.Int32)(0)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_POINTLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_POINTLIST</unmanaged-short>
        PointList = unchecked((System.Int32)(1)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINELIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_LINELIST</unmanaged-short>
        LineList = unchecked((System.Int32)(2)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP</unmanaged-short>
        LineStrip = unchecked((System.Int32)(3)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST</unmanaged-short>
        TriangleList = unchecked((System.Int32)(4)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP</unmanaged-short>
        TriangleStrip = unchecked((System.Int32)(5)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ</unmanaged-short>
        LineListWithAdjacency = unchecked((System.Int32)(10)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ</unmanaged-short>
        LineStripWithAdjacency = unchecked((System.Int32)(11)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ</unmanaged-short>
        TriangleListWithAdjacency = unchecked((System.Int32)(12)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ</unmanaged-short>
        TriangleStripWithAdjacency = unchecked((System.Int32)(13)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith1ControlPoints = unchecked((System.Int32)(33)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith2ControlPoints = unchecked((System.Int32)(34)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith3ControlPoints = unchecked((System.Int32)(35)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith4ControlPoints = unchecked((System.Int32)(36)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith5ControlPoints = unchecked((System.Int32)(37)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith6ControlPoints = unchecked((System.Int32)(38)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith7ControlPoints = unchecked((System.Int32)(39)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith8ControlPoints = unchecked((System.Int32)(40)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith9ControlPoints = unchecked((System.Int32)(41)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith10ControlPoints = unchecked((System.Int32)(42)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith11ControlPoints = unchecked((System.Int32)(43)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith12ControlPoints = unchecked((System.Int32)(44)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith13ControlPoints = unchecked((System.Int32)(45)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith14ControlPoints = unchecked((System.Int32)(46)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith15ControlPoints = unchecked((System.Int32)(47)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith16ControlPoints = unchecked((System.Int32)(48)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith17ControlPoints = unchecked((System.Int32)(49)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith18ControlPoints = unchecked((System.Int32)(50)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith19ControlPoints = unchecked((System.Int32)(51)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith20ControlPoints = unchecked((System.Int32)(52)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith21ControlPoints = unchecked((System.Int32)(53)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith22ControlPoints = unchecked((System.Int32)(54)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith23ControlPoints = unchecked((System.Int32)(55)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith24ControlPoints = unchecked((System.Int32)(56)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith25ControlPoints = unchecked((System.Int32)(57)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith26ControlPoints = unchecked((System.Int32)(58)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith27ControlPoints = unchecked((System.Int32)(59)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith28ControlPoints = unchecked((System.Int32)(60)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith29ControlPoints = unchecked((System.Int32)(61)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith30ControlPoints = unchecked((System.Int32)(62)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith31ControlPoints = unchecked((System.Int32)(63)),
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST</unmanaged>
        /// <unmanaged-short>D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST</unmanaged-short>
        PatchListWith32ControlPoints = unchecked((System.Int32)(64))
    }
}
