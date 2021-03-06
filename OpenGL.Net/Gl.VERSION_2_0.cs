
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating whether the RGB blend equation is 
		/// Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN or Gl.MAX. See Gl.BlendEquationSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_RGB_EXT")]
		[AliasOf("GL_BLEND_EQUATION_RGB_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
		public const int BLEND_EQUATION_RGB = 0x8009;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if the vertex attribute array 
		/// for index is enabled and 0 (false) if it is disabled. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value, the size of the vertex attribute array for index. The 
		/// size is the number of values for each element of the vertex attribute array, and it will be 1, 2, 3, or 4. The initial 
		/// value is 4.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value, the array stride for (number of bytes between 
		/// successive elements in) the vertex attribute array for index. A value of 0 indicates that the array elements are stored 
		/// sequentially in memory. The initial value is 0.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetVertexAttrib: params returns a single value, a symbolic constant indicating the array type for the vertex 
		/// attribute array for index. Possible values are Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.UNSIGNED_SHORT, Gl.INT, 
		/// Gl.UNSIGNED_INT, Gl.FLOAT, and Gl.DOUBLE. The initial value is Gl.FLOAT.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetVertexAttrib: params returns a single value, a symbolic constant indicating the array type for the 
		/// vertex attribute array for index. Possible values are Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, Gl.UNSIGNED_SHORT, Gl.INT, 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT, Gl.FIXED, Gl.HALF_FLOAT, and Gl.FLOAT. The initial value is Gl.FLOAT.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetVertexAttrib: params returns four values that represent the current value for the generic vertex attribute 
		/// specified by index. Generic vertex attribute 0 is unique in that it has no current state, so an error will be generated 
		/// if index is 0. The initial value for all other generic vertex attributes is (0,0,0,1).glGetVertexAttribdv and 
		/// glGetVertexAttribfv return the current attribute values as four single-precision floating-point values; 
		/// glGetVertexAttribiv reads them as floating-point values and converts them to four integer values; glGetVertexAttribIiv 
		/// and glGetVertexAttribIuiv read and return them as signed or unsigned integer values, respectively; glGetVertexAttribLdv 
		/// reads and returns them as four double-precision floating-point values.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetVertexAttrib: params returns four values that represent the current value for the generic vertex 
		/// attribute specified by index. The initial value for all generic vertex attributes is (0,0,0,1).
		/// </para>
		/// </summary>
		[AliasOf("GL_CURRENT_VERTEX_ATTRIB_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int CURRENT_VERTEX_ATTRIB = 0x8626;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Enable: If enabled and a vertex shader is active, then the derived point size is taken from the (potentially 
		/// clipped) shader builtin Gl.PointSize and clamped to the implementation-dependent point size range.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether vertex program point size mode is enabled. If 
		/// enabled, and a vertex shader is active, then the point size is taken from the shader built-in gl_PointSize. If disabled, 
		/// and a vertex shader is active, then the point size is taken from the point state as specified by Gl.PointSize. The 
		/// initial value is Gl.FALSE.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_POINT_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_POINTER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what function is used for back-facing 
		/// polygons to compare the stencil reference value with the stencil buffer value. The initial value is Gl.ALWAYS. See 
		/// Gl.StencilFuncSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FUNC_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FUNC = 0x8800;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing 
		/// polygons when the stencil test fails. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FAIL = 0x8801;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing 
		/// polygons when the stencil test passes, but the depth test fails. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken for back-facing 
		/// polygons when the stencil test passes and the depth test passes. The initial value is Gl.KEEP. See Gl.StencilOpSeparate.
		/// </summary>
		[AliasOf("GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum number of simultaneous outputs that may be written in a fragment 
		/// shader. The value must be at least 8. See Gl.DrawBuffers.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of simultaneous outputs that may be written in a fragment 
		/// shader. The value must be at least 4. See Gl.DrawBuffers.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_DRAW_BUFFERS_ARB")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_ATI")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_EXT")]
		[AliasOf("GL_MAX_DRAW_BUFFERS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int MAX_DRAW_BUFFERS = 0x8824;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER0 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER0_ARB")]
		[AliasOf("GL_DRAW_BUFFER0_ATI")]
		[AliasOf("GL_DRAW_BUFFER0_EXT")]
		[AliasOf("GL_DRAW_BUFFER0_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER0 = 0x8825;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER1 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER1_ARB")]
		[AliasOf("GL_DRAW_BUFFER1_ATI")]
		[AliasOf("GL_DRAW_BUFFER1_EXT")]
		[AliasOf("GL_DRAW_BUFFER1_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER1 = 0x8826;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER2 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER2_ARB")]
		[AliasOf("GL_DRAW_BUFFER2_ATI")]
		[AliasOf("GL_DRAW_BUFFER2_EXT")]
		[AliasOf("GL_DRAW_BUFFER2_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER2 = 0x8827;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER3 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER3_ARB")]
		[AliasOf("GL_DRAW_BUFFER3_ATI")]
		[AliasOf("GL_DRAW_BUFFER3_EXT")]
		[AliasOf("GL_DRAW_BUFFER3_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER3 = 0x8828;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER4 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER4_ARB")]
		[AliasOf("GL_DRAW_BUFFER4_ATI")]
		[AliasOf("GL_DRAW_BUFFER4_EXT")]
		[AliasOf("GL_DRAW_BUFFER4_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER4 = 0x8829;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER5 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER5_ARB")]
		[AliasOf("GL_DRAW_BUFFER5_ATI")]
		[AliasOf("GL_DRAW_BUFFER5_EXT")]
		[AliasOf("GL_DRAW_BUFFER5_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER5 = 0x882A;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER6 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER6_ARB")]
		[AliasOf("GL_DRAW_BUFFER6_ATI")]
		[AliasOf("GL_DRAW_BUFFER6_EXT")]
		[AliasOf("GL_DRAW_BUFFER6_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER6 = 0x882B;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER7 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER7_ARB")]
		[AliasOf("GL_DRAW_BUFFER7_ATI")]
		[AliasOf("GL_DRAW_BUFFER7_EXT")]
		[AliasOf("GL_DRAW_BUFFER7_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER7 = 0x882C;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER8 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER8_ARB")]
		[AliasOf("GL_DRAW_BUFFER8_ATI")]
		[AliasOf("GL_DRAW_BUFFER8_EXT")]
		[AliasOf("GL_DRAW_BUFFER8_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER8 = 0x882D;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER9 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER9_ARB")]
		[AliasOf("GL_DRAW_BUFFER9_ATI")]
		[AliasOf("GL_DRAW_BUFFER9_EXT")]
		[AliasOf("GL_DRAW_BUFFER9_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER9 = 0x882E;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER10 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER10_ARB")]
		[AliasOf("GL_DRAW_BUFFER10_ATI")]
		[AliasOf("GL_DRAW_BUFFER10_EXT")]
		[AliasOf("GL_DRAW_BUFFER10_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER10 = 0x882F;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER11 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER11_ARB")]
		[AliasOf("GL_DRAW_BUFFER11_ATI")]
		[AliasOf("GL_DRAW_BUFFER11_EXT")]
		[AliasOf("GL_DRAW_BUFFER11_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER11 = 0x8830;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER12 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER12_ARB")]
		[AliasOf("GL_DRAW_BUFFER12_ATI")]
		[AliasOf("GL_DRAW_BUFFER12_EXT")]
		[AliasOf("GL_DRAW_BUFFER12_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER12 = 0x8831;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER13 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER13_ARB")]
		[AliasOf("GL_DRAW_BUFFER13_ATI")]
		[AliasOf("GL_DRAW_BUFFER13_EXT")]
		[AliasOf("GL_DRAW_BUFFER13_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER13 = 0x8832;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER14 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER14_ARB")]
		[AliasOf("GL_DRAW_BUFFER14_ATI")]
		[AliasOf("GL_DRAW_BUFFER14_EXT")]
		[AliasOf("GL_DRAW_BUFFER14_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER14 = 0x8833;

		/// <summary>
		/// [GL] Value of GL_DRAW_BUFFER15 symbol.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER15_ARB")]
		[AliasOf("GL_DRAW_BUFFER15_ATI")]
		[AliasOf("GL_DRAW_BUFFER15_EXT")]
		[AliasOf("GL_DRAW_BUFFER15_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER15 = 0x8834;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating whether the Alpha blend equation is 
		/// Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN or Gl.MAX. See Gl.BlendEquationSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_ALPHA_EXT")]
		[AliasOf("GL_BLEND_EQUATION_ALPHA_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
		public const int BLEND_EQUATION_ALPHA = 0x883D;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of 4-component generic vertex attributes accessible to 
		/// a vertex shader. The value must be at least 16. See Gl.VertexAttrib.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_ATTRIBS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_ATTRIBS = 0x8869;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetVertexAttrib: params returns a single value that is non-zero (true) if fixed-point data types for 
		/// the vertex attribute array indicated by index are normalized when they are converted to floating point, and 0 (false) 
		/// otherwise. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
		/// texture maps from the fragment shader. The value must be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_IMAGE_UNITS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_SHADER symbol.
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		public const int FRAGMENT_SHADER = 0x8B30;

		/// <summary>
		/// [GL] Value of GL_VERTEX_SHADER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_SHADER_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_SHADER = 0x8B31;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that 
		/// can be held in uniform variable storage for a fragment shader. The value must be at least 1024. See Gl.Uniform.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values 
		/// that can be held in uniform variable storage for a fragment shader. The value must be at least 896. See Gl.Uniform.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean 
		/// values that can be held in uniform variable storage for a vertex shader. The value must be at least 1024. See 
		/// Gl.Uniform.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the maximum number of interpolators available for processing varying variables 
		/// used by vertex and fragment shaders. This value represents the number of individual floating-point values that can be 
		/// interpolated; varying variables declared as vectors, matrices, and arrays will all consume multiple interpolators. The 
		/// value must be at least 32.
		/// </summary>
		[AliasOf("GL_MAX_VARYING_FLOATS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VARYING_FLOATS = 0x8B4B;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
		/// texture maps from the vertex shader. The value may be at least 16. See Gl.ActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program3")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps 
		/// from the vertex shader and the fragment processor combined. If both the vertex shader and the fragment processing stage 
		/// access the same texture image unit, then that counts as using two texture image units against this limit. The value must 
		/// be at least 48. See Gl.ActiveTexture.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture 
		/// maps from the all the shader stages combined. If both the vertex shader and the fragment processing stage access the 
		/// same texture image unit, then that counts as using two texture image units against this limit. The value must be at 
		/// least 96. See Gl.ActiveTexture.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetShader: params returns Gl.VERTEX_SHADER if shader is a vertex shader object, Gl.GEOMETRY_SHADER if shader is 
		/// a geometry shader object, and Gl.FRAGMENT_SHADER if shader is a fragment shader object.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetShader: params returns Gl.VERTEX_SHADER if shader is a vertex shader object, Gl.TESS_CONTROL_SHADER if 
		/// shader is a tesselation control shader object,Gl.TESS_EVALUATION_SHADER if shader is a tesselation evaluation shader 
		/// object,Gl.GEOMETRY_SHADER if shader is a geometry shader object, Gl.FRAGMENT_SHADER if shader is a fragment shader, and 
		/// Gl.COMPUTE_SHADER if shader is a compute shader object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int SHADER_TYPE = 0x8B4F;

		/// <summary>
		/// [GL] Value of GL_FLOAT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC2 = 0x8B50;

		/// <summary>
		/// [GL] Value of GL_FLOAT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC3 = 0x8B51;

		/// <summary>
		/// [GL] Value of GL_FLOAT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC4 = 0x8B52;

		/// <summary>
		/// [GL] Value of GL_INT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC2 = 0x8B53;

		/// <summary>
		/// [GL] Value of GL_INT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC3 = 0x8B54;

		/// <summary>
		/// [GL] Value of GL_INT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_INT_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC4 = 0x8B55;

		/// <summary>
		/// [GL] Value of GL_BOOL symbol.
		/// </summary>
		[AliasOf("GL_BOOL_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL = 0x8B56;

		/// <summary>
		/// [GL] Value of GL_BOOL_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC2 = 0x8B57;

		/// <summary>
		/// [GL] Value of GL_BOOL_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC3 = 0x8B58;

		/// <summary>
		/// [GL] Value of GL_BOOL_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_BOOL_VEC4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC4 = 0x8B59;

		/// <summary>
		/// [GL] Value of GL_FLOAT_MAT2 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT2_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT2 = 0x8B5A;

		/// <summary>
		/// [GL] Value of GL_FLOAT_MAT3 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT3_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT3 = 0x8B5B;

		/// <summary>
		/// [GL] Value of GL_FLOAT_MAT4 symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_MAT4_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT4 = 0x8B5C;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D = 0x8B5D;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D = 0x8B5E;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_3D_ARB")]
		[AliasOf("GL_SAMPLER_3D_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		public const int SAMPLER_3D = 0x8B5F;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_CUBE = 0x8B60;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_1D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D_SHADOW = 0x8B61;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_2D_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_SHADOW_ARB")]
		[AliasOf("GL_SAMPLER_2D_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		public const int SAMPLER_2D_SHADOW = 0x8B62;

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns Gl.TRUE if program is currently flagged for deletion, and Gl.FALSE 
		/// otherwise.
		/// </para>
		/// <para>
		/// [GL4|GLES3.2] Gl.GetShader: params returns Gl.TRUE if shader is currently flagged for deletion, and Gl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DELETE_STATUS = 0x8B80;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetShader: params returns Gl.TRUE if the last compile operation on shader was successful, and Gl.FALSE 
		/// otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int COMPILE_STATUS = 0x8B81;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns Gl.TRUE if the last link operation on program was successful, and Gl.FALSE 
		/// otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public const int LINK_STATUS = 0x8B82;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns Gl.TRUE or if the last validation operation on program was successful, and 
		/// Gl.FALSE otherwise.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int VALIDATE_STATUS = 0x8B83;

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the number of characters in the information log for program including the 
		/// null termination character (i.e., the size of the character buffer required to store the information log). If program 
		/// has no information log, a value of 0 is returned.
		/// </para>
		/// <para>
		/// [GL4|GLES3.2] Gl.GetShader: params returns the number of characters in the information log for shader including the null 
		/// termination character (i.e., the size of the character buffer required to store the information log). If shader has no 
		/// information log, a value of 0 is returned.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INFO_LOG_LENGTH = 0x8B84;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the number of shader objects attached to program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ATTACHED_SHADERS = 0x8B85;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the number of active uniform variables for program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_UNIFORMS = 0x8B86;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the length of the longest active uniform variable name for program, 
		/// including the null termination character (i.e., the size of the character buffer required to store the longest uniform 
		/// variable name). If no active uniform variables exist, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetShader: params returns the length of the concatenation of the source strings that make up the shader 
		/// source for the shader, including the null termination character. (i.e., the size of the character buffer required to 
		/// store the shader source). If no source code exists, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int SHADER_SOURCE_LENGTH = 0x8B88;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the number of active attribute variables for program.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_ATTRIBUTES = 0x8B89;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetProgram: params returns the length of the longest active attribute name for program, including the 
		/// null termination character (i.e., the size of the character buffer required to store the longest attribute name). If no 
		/// active attributes exist, 0 is returned.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating the mode of the derivative accuracy hint 
		/// for fragment shaders. The initial value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// [GL4|GLES3.2] Gl.Hint: Indicates the accuracy of the derivative calculation for the GL shading language fragment 
		/// processing built-in functions: Gl.x, Gl.y, and Gl.dth.
		/// </para>
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
		[AliasOf("GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		[RequiredByFeature("GL_OES_standard_derivatives", Api = "gles2|glsc2")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetString: Returns a version or release number for the shading language.
		/// </summary>
		[AliasOf("GL_SHADING_LANGUAGE_VERSION_ARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shading_language_100")]
		public const int SHADING_LANGUAGE_VERSION = 0x8B8C;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the name of the program object that is currently active, or 0 if no 
		/// program object is active. See Gl.UseProgram.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public const int CURRENT_PROGRAM = 0x8B8D;

		/// <summary>
		/// [GL4] Gl.PointParameter: params is a single enum specifying the point sprite texture coordinate origin, either 
		/// Gl.LOWER_LEFT or Gl.UPPER_LEFT. The default value is Gl.UPPER_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		public const int POINT_SPRITE_COORD_ORIGIN = 0x8CA0;

		/// <summary>
		/// [GL] Value of GL_LOWER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int LOWER_LEFT = 0x8CA1;

		/// <summary>
		/// [GL] Value of GL_UPPER_LEFT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int UPPER_LEFT = 0x8CA2;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the reference value that is compared with the contents of the stencil 
		/// buffer for back-facing polygons. The initial value is 0. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public const int STENCIL_BACK_REF = 0x8CA3;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the mask that is used for back-facing polygons to mask both the stencil 
		/// reference value and the stencil buffer value before they are compared. The initial value is all 1's. See 
		/// Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;

		/// <summary>
		/// [GL4|GLES3.2] Gl.Get: data returns one value, the mask that controls writing of the stencil bitplanes for back-facing 
		/// polygons. The initial value is all 1's. See Gl.StencilMaskSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public const int STENCIL_BACK_WRITEMASK = 0x8CA5;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Enable: If enabled and a vertex shader is active, it specifies that the GL will choose between front and back 
		/// colors based on the polygon's face direction of which the vertex being shaded is a part. It has no effect on points or 
		/// lines.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether vertex program two-sided color mode is enabled. 
		/// If enabled, and a vertex shader is active, then the GL chooses the back color output for back-facing polygons, and the 
		/// front color output for non-polygons and front-facing polygons. If disabled, and a vertex shader is active, then the 
		/// front color output is always selected. The initial value is Gl.FALSE.
		/// </para>
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
		[AliasOf("GL_VERTEX_PROGRAM_TWO_SIDE_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int VERTEX_PROGRAM_TWO_SIDE = 0x8643;

		/// <summary>
		/// <para>
		/// [GL2.1] Gl.Enable: If enabled, calculate texture coordinates for points based on texture environment and point parameter 
		/// settings. Otherwise texture coordinates are constant across points.
		/// </para>
		/// <para>
		/// [GL2.1] Gl.Get: params returns a single boolean value indicating whether point sprite is enabled. The initial value is 
		/// Gl.FALSE.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_SPRITE_ARB")]
		[AliasOf("GL_POINT_SPRITE_NV")]
		[AliasOf("GL_POINT_SPRITE_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_point_sprite")]
		[RequiredByFeature("GL_NV_point_sprite")]
		[RequiredByFeature("GL_OES_point_sprite", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POINT_SPRITE = 0x8861;

		/// <summary>
		/// [GL2.1] Gl.GetTexEnv: params returns a single boolean value representing the current point sprite texture coordinate 
		/// replacement enable state. The initial value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_COORD_REPLACE_ARB")]
		[AliasOf("GL_COORD_REPLACE_NV")]
		[AliasOf("GL_COORD_REPLACE_OES")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_point_sprite")]
		[RequiredByFeature("GL_NV_point_sprite")]
		[RequiredByFeature("GL_OES_point_sprite", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COORD_REPLACE = 0x8862;

		/// <summary>
		/// [GL2.1] Gl.Get: params returns one value, the maximum number of texture coordinate sets available to vertex and fragment 
		/// shaders. The value must be at least 2. See Gl.ActiveTexture and Gl.ClientActiveTexture.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_COORDS_ARB")]
		[AliasOf("GL_MAX_TEXTURE_COORDS_NV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_fragment_program")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_TEXTURE_COORDS = 0x8871;

		/// <summary>
		/// [GL2.1] set the RGB blend equation and the alpha blend equation separately
		/// </summary>
		/// <param name="modeRGB">
		/// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are 
		/// combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <param name="modeAlpha">
		/// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must 
		/// be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="modeRGB"/> or <paramref name="modeAlpha"/> is not one of 
		/// Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, Gl.FUNC_REVERSE_SUBTRACT, Gl.MAX, or Gl.MIN.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.BlendEquationSeparate is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		[AliasOf("glBlendEquationSeparateEXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		public static void BlendEquationSeparate(BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparate != null, "pglBlendEquationSeparate not implemented");
			Delegates.pglBlendEquationSeparate((Int32)modeRGB, (Int32)modeAlpha);
			LogCommand("glBlendEquationSeparate", null, modeRGB, modeAlpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies a list of color buffers to be drawn into
		/// </para>
		/// </summary>
		/// <param name="bufs">
		/// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be 
		/// written.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffers if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if one of the values in <paramref name="bufs"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if the API call refers to the default framebuffer and one or more of the values in 
		/// <paramref name="bufs"/> is one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if the API call refers to a framebuffer object and one or more of the values in <paramref 
		/// name="bufs"/> is anything other than Gl.NONE or one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="n"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a symbolic constant other than Gl.NONE appears more than once in <paramref 
		/// name="bufs"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any of the entries in <paramref name="bufs"/> (other than Gl.NONE ) indicates a 
		/// color buffer that does not exist in the current GL context.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="bufs"/> is Gl.BACK, and <paramref name="n"/> is not 
		/// one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is greater than Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[AliasOf("glDrawBuffersARB")]
		[AliasOf("glDrawBuffersATI")]
		[AliasOf("glDrawBuffersEXT")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_buffers")]
		[RequiredByFeature("GL_ATI_draw_buffers")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		public static void DrawBuffers(params Int32[] bufs)
		{
			unsafe {
				fixed (Int32* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffers != null, "pglDrawBuffers not implemented");
					Delegates.pglDrawBuffers((Int32)bufs.Length, p_bufs);
					LogCommand("glDrawBuffers", null, bufs.Length, bufs					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] set front and/or back stencil test actions
		/// </para>
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO, 
		/// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. <paramref name="dpfail"/> accepts 
		/// the same symbolic constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. <paramref name="dppass"/> accepts the same symbolic 
		/// constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> is any value other than Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="sfail"/>, <paramref name="dpfail"/>, or <paramref name="dppass"/> is any 
		/// value other than the eight defined constant values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		[AliasOf("glStencilOpSeparateATI")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOpSeparate != null, "pglStencilOpSeparate not implemented");
			Delegates.pglStencilOpSeparate((Int32)face, (Int32)sfail, (Int32)dpfail, (Int32)dppass);
			LogCommand("glStencilOpSeparate", null, face, sfail, dpfail, dppass			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] set front and/or back function and reference value for stencil testing
		/// </para>
		/// </summary>
		/// <param name="face">
		/// Specifies whether front and/or back stencil state is updated. Three symbolic constants are valid: Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL, 
		/// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value for the stencil test. <paramref name="ref"/> is clamped to the range 02n-1, where n is the 
		/// number of bitplanes in the stencil buffer. The initial value is 0.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not one of the eight accepted values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparate != null, "pglStencilFuncSeparate not implemented");
			Delegates.pglStencilFuncSeparate((Int32)face, (Int32)func, @ref, mask);
			LogCommand("glStencilFuncSeparate", null, face, func, @ref, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] control the front and/or back writing of individual bits in the stencil planes
		/// </para>
		/// </summary>
		/// <param name="face">
		/// Specifies whether the front and/or back stencil writemask is updated. Three symbolic constants are valid: Gl.FRONT, 
		/// Gl.BACK, and Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public static void StencilMaskSeparate(StencilFaceDirection face, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMaskSeparate != null, "pglStencilMaskSeparate not implemented");
			Delegates.pglStencilMaskSeparate((Int32)face, mask);
			LogCommand("glStencilMaskSeparate", null, face, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Attaches a shader object to a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to which a shader object will be attached.
		/// </param>
		/// <param name="shader">
		/// Specifies the shader object that is to be attached.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="program"/> or <paramref name="shader"/> is not a value generated 
		/// by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is already attached to <paramref name="program"/>.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glAttachObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void AttachShader(UInt32 program, UInt32 shader)
		{
			Debug.Assert(Delegates.pglAttachShader != null, "pglAttachShader not implemented");
			Delegates.pglAttachShader(program, shader);
			LogCommand("glAttachShader", null, program, shader			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Associates a generic vertex attribute index with a named attribute variable
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object in which the association is to be made.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be bound.
		/// </param>
		/// <param name="name">
		/// Specifies a null terminated string containing the name of the vertex shader attribute variable to which <paramref 
		/// name="index"/> is to be bound.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> starts with the reserved prefix "gl_".
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glBindAttribLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void BindAttribLocation(UInt32 program, UInt32 index, String name)
		{
			Debug.Assert(Delegates.pglBindAttribLocation != null, "pglBindAttribLocation not implemented");
			Delegates.pglBindAttribLocation(program, index, name);
			LogCommand("glBindAttribLocation", null, program, index, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Compiles a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be compiled.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glCompileShaderARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void CompileShader(UInt32 shader)
		{
			Debug.Assert(Delegates.pglCompileShader != null, "pglCompileShader not implemented");
			Delegates.pglCompileShader(shader);
			LogCommand("glCompileShader", null, shader			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Creates a program object
		/// </para>
		/// </summary>
		/// <exception cref="KhronosException">
		/// This function returns 0 if an error occurs creating the program object.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[AliasOf("glCreateProgramObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 CreateProgram()
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateProgram != null, "pglCreateProgram not implemented");
			retValue = Delegates.pglCreateProgram();
			LogCommand("glCreateProgram", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Creates a shader object
		/// </para>
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// This function returns 0 if an error occurs creating the shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glCreateShaderObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 CreateShader(ShaderType type)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShader != null, "pglCreateShader not implemented");
			retValue = Delegates.pglCreateShader((Int32)type);
			LogCommand("glCreateShader", retValue, type			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Deletes a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be deleted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DeleteProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglDeleteProgram != null, "pglDeleteProgram not implemented");
			Delegates.pglDeleteProgram(program);
			LogCommand("glDeleteProgram", null, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Deletes a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be deleted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DeleteShader(UInt32 shader)
		{
			Debug.Assert(Delegates.pglDeleteShader != null, "pglDeleteShader not implemented");
			Delegates.pglDeleteShader(shader);
			LogCommand("glDeleteShader", null, shader			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Detaches a shader object from a program object to which it is attached
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object from which to detach the shader object.
		/// </param>
		/// <param name="shader">
		/// Specifies the shader object to be detached.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="program"/> or <paramref name="shader"/> is a value that was not 
		/// generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not attached to <paramref name="program"/>.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		[AliasOf("glDetachObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void DetachShader(UInt32 program, UInt32 shader)
		{
			Debug.Assert(Delegates.pglDetachShader != null, "pglDetachShader not implemented");
			Delegates.pglDetachShader(program, shader);
			LogCommand("glDetachShader", null, program, shader			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Enable or disable a generic vertex attribute array
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glDisableVertexAttribArrayARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void DisableVertexAttribArray(UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexAttribArray != null, "pglDisableVertexAttribArray not implemented");
			Delegates.pglDisableVertexAttribArray(index);
			LogCommand("glDisableVertexAttribArray", null, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Enable or disable a generic vertex attribute array
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glEnableVertexAttribArrayARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void EnableVertexAttribArray(UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexAttribArray != null, "pglEnableVertexAttribArray not implemented");
			Delegates.pglEnableVertexAttribArray(index);
			LogCommand("glEnableVertexAttribArray", null, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns information about an active attribute variable for the specified program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the attribute variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by <paramref name="name"/> 
		/// (excluding the null terminator) if a value other than Gl.L is passed.
		/// </param>
		/// <param name="size">
		/// Returns the size of the attribute variable.
		/// </param>
		/// <param name="type">
		/// Returns the data type of the attribute variable.
		/// </param>
		/// <param name="name">
		/// Returns a null terminated string containing the name of the attribute variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of active attribute 
		/// variables in <paramref name="program"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetActiveAttribARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveAttrib != null, "pglGetActiveAttrib not implemented");
					Delegates.pglGetActiveAttrib(program, index, bufSize, p_length, p_size, p_type, name);
					LogCommand("glGetActiveAttrib", null, program, index, bufSize, length, size, type, name					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns information about an active uniform variable for the specified program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters OpenGL is allowed to write in the character buffer indicated by <paramref 
		/// name="name"/>.
		/// </param>
		/// <param name="length">
		/// Returns the number of characters actually written by OpenGL in the string indicated by <paramref name="name"/> 
		/// (excluding the null terminator) if a value other than Gl.L is passed.
		/// </param>
		/// <param name="size">
		/// Returns the size of the uniform variable.
		/// </param>
		/// <param name="type">
		/// Returns the data type of the uniform variable.
		/// </param>
		/// <param name="name">
		/// Returns a null terminated string containing the name of the uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of active uniform 
		/// variables in <paramref name="program"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glGetActiveUniformARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveUniform != null, "pglGetActiveUniform not implemented");
					Delegates.pglGetActiveUniform(program, index, bufSize, p_length, p_size, p_type, name);
					LogCommand("glGetActiveUniform", null, program, index, bufSize, length, size, type, name					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the handles of the shader objects attached to a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="count">
		/// Returns the number of names actually returned in <paramref name="shaders"/>.
		/// </param>
		/// <param name="shaders">
		/// Specifies an array that is used to return the names of attached shader objects.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxCount"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetAttachedShaders(UInt32 program, out Int32 count, [Out] UInt32[] shaders)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglGetAttachedShaders != null, "pglGetAttachedShaders not implemented");
					Delegates.pglGetAttachedShaders(program, (Int32)shaders.Length, p_count, p_shaders);
					LogCommand("glGetAttachedShaders", null, program, shaders.Length, count, shaders					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the location of an attribute variable
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="name">
		/// Points to a null terminated string containing the name of the attribute variable whose location is to be queried.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetAttribLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static Int32 GetAttribLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetAttribLocation != null, "pglGetAttribLocation not implemented");
			retValue = Delegates.pglGetAttribLocation(program, name);
			LogCommand("glGetAttribLocation", retValue, program, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns a parameter from a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.DELETE_STATUS, Gl.LINK_STATUS, Gl.VALIDATE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.ATTACHED_SHADERS, Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS, Gl.ACTIVE_ATTRIBUTES, 
		/// Gl.ACTIVE_ATTRIBUTE_MAX_LENGTH, Gl.ACTIVE_UNIFORMS, Gl.ACTIVE_UNIFORM_BLOCKS, Gl.ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
		/// Gl.ACTIVE_UNIFORM_MAX_LENGTH, Gl.COMPUTE_WORK_GROUP_SIZEGl.PROGRAM_BINARY_LENGTH, Gl.TRANSFORM_FEEDBACK_BUFFER_MODE, 
		/// Gl.TRANSFORM_FEEDBACK_VARYINGS, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, Gl.GEOMETRY_VERTICES_OUT, 
		/// Gl.GEOMETRY_INPUT_TYPE, and Gl.GEOMETRY_OUTPUT_TYPE.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.GEOMETRY_VERTICES_OUT, Gl.GEOMETRY_INPUT_TYPE, or 
		/// Gl.GEOMETRY_OUTPUT_TYPE, and <paramref name="program"/> does not contain a geometry shader.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.COMPUTE_WORK_GROUP_SIZE and <paramref 
		/// name="program"/> does not contain a binary for the compute shader stage.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public static void GetProgram(UInt32 program, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramiv != null, "pglGetProgramiv not implemented");
					Delegates.pglGetProgramiv(program, pname, p_params);
					LogCommand("glGetProgramiv", null, program, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns a parameter from a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.DELETE_STATUS, Gl.LINK_STATUS, Gl.VALIDATE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.ATTACHED_SHADERS, Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS, Gl.ACTIVE_ATTRIBUTES, 
		/// Gl.ACTIVE_ATTRIBUTE_MAX_LENGTH, Gl.ACTIVE_UNIFORMS, Gl.ACTIVE_UNIFORM_BLOCKS, Gl.ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH, 
		/// Gl.ACTIVE_UNIFORM_MAX_LENGTH, Gl.COMPUTE_WORK_GROUP_SIZEGl.PROGRAM_BINARY_LENGTH, Gl.TRANSFORM_FEEDBACK_BUFFER_MODE, 
		/// Gl.TRANSFORM_FEEDBACK_VARYINGS, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, Gl.GEOMETRY_VERTICES_OUT, 
		/// Gl.GEOMETRY_INPUT_TYPE, and Gl.GEOMETRY_OUTPUT_TYPE.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.GEOMETRY_VERTICES_OUT, Gl.GEOMETRY_INPUT_TYPE, or 
		/// Gl.GEOMETRY_OUTPUT_TYPE, and <paramref name="program"/> does not contain a geometry shader.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is Gl.COMPUTE_WORK_GROUP_SIZE and <paramref 
		/// name="program"/> does not contain a binary for the compute shader stage.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		public static void GetProgram(UInt32 program, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetProgramiv != null, "pglGetProgramiv not implemented");
					Delegates.pglGetProgramiv(program, pname, p_params);
					LogCommand("glGetProgramiv", null, program, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the information log for a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object whose information log is to be queried.
		/// </param>
		/// <param name="maxLength">
		/// Specifies the size of the character buffer for storing the returned information log.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="infoLog"/> (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxLength"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetProgramInfoLog(UInt32 program, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramInfoLog != null, "pglGetProgramInfoLog not implemented");
					Delegates.pglGetProgramInfoLog(program, maxLength, p_length, infoLog);
					LogCommand("glGetProgramInfoLog", null, program, maxLength, length, infoLog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns a parameter from a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.SHADER_TYPE, Gl.DELETE_STATUS, Gl.COMPILE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.SHADER_SOURCE_LENGTH.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> does not refer to a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShader(UInt32 shader, ShaderParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetShaderiv != null, "pglGetShaderiv not implemented");
					Delegates.pglGetShaderiv(shader, (Int32)pname, p_params);
					LogCommand("glGetShaderiv", null, shader, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns a parameter from a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the object parameter. Accepted symbolic names are Gl.SHADER_TYPE, Gl.DELETE_STATUS, Gl.COMPILE_STATUS, 
		/// Gl.INFO_LOG_LENGTH, Gl.SHADER_SOURCE_LENGTH.
		/// </param>
		/// <param name="params">
		/// Returns the requested object parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> does not refer to a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShader(UInt32 shader, ShaderParameterName pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetShaderiv != null, "pglGetShaderiv not implemented");
					Delegates.pglGetShaderiv(shader, (Int32)pname, p_params);
					LogCommand("glGetShaderiv", null, shader, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the information log for a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object whose information log is to be queried.
		/// </param>
		/// <param name="maxLength">
		/// Specifies the size of the character buffer for storing the returned information log.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="infoLog"/> (excluding the null terminator).
		/// </param>
		/// <param name="infoLog">
		/// Specifies an array of characters that is used to return the information log.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="maxLength"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetShaderInfoLog(UInt32 shader, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderInfoLog != null, "pglGetShaderInfoLog not implemented");
					Delegates.pglGetShaderInfoLog(shader, maxLength, p_length, infoLog);
					LogCommand("glGetShaderInfoLog", null, shader, maxLength, length, infoLog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the source code string from a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the shader object to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the character buffer for storing the returned source code string.
		/// </param>
		/// <param name="length">
		/// Returns the length of the string returned in <paramref name="source"/> (excluding the null terminator).
		/// </param>
		/// <param name="source">
		/// Specifies an array of characters that is used to return the source code string.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[AliasOf("glGetShaderSourceARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetShaderSource(UInt32 shader, Int32 bufSize, out Int32 length, [Out] StringBuilder source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderSource != null, "pglGetShaderSource not implemented");
					Delegates.pglGetShaderSource(shader, bufSize, p_length, source);
					LogCommand("glGetShaderSource", null, shader, bufSize, length, source					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the location of a uniform variable
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="name">
		/// Points to a null terminated string containing the name of the uniform variable whose location is to be queried.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformLocationARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static Int32 GetUniformLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetUniformLocation != null, "pglGetUniformLocation not implemented");
			retValue = Delegates.pglGetUniformLocation(program, name);
			LogCommand("glGetUniformLocation", retValue, program, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the value of a uniform variable
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformfvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformfv != null, "pglGetUniformfv not implemented");
					Delegates.pglGetUniformfv(program, location, p_params);
					LogCommand("glGetUniformfv", null, program, location, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Returns the value of a uniform variable
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetUniformivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetUniform(UInt32 program, Int32 location, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformiv != null, "pglGetUniformiv not implemented");
					Delegates.pglGetUniformiv(program, location, p_params);
					LogCommand("glGetUniformiv", null, program, location, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribdvARB")]
		[AliasOf("glGetVertexAttribdvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribdv != null, "pglGetVertexAttribdv not implemented");
					Delegates.pglGetVertexAttribdv(index, pname, p_params);
					LogCommand("glGetVertexAttribdv", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Return a generic vertex attribute parameter
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribfvARB")]
		[AliasOf("glGetVertexAttribfvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribfv != null, "pglGetVertexAttribfv not implemented");
					Delegates.pglGetVertexAttribfv(index, pname, p_params);
					LogCommand("glGetVertexAttribfv", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Return a generic vertex attribute parameter
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribivARB")]
		[AliasOf("glGetVertexAttribivNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					LogCommand("glGetVertexAttribiv", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Return a generic vertex attribute parameter
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribivARB")]
		[AliasOf("glGetVertexAttribivNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttrib(UInt32 index, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribiv != null, "pglGetVertexAttribiv not implemented");
					Delegates.pglGetVertexAttribiv(index, pname, p_params);
					LogCommand("glGetVertexAttribiv", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the address of the specified generic vertex attribute pointer
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be returned.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be 
		/// Gl.VERTEX_ATTRIB_ARRAY_POINTER.
		/// </param>
		/// <param name="pointer">
		/// Returns the pointer value.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if no vertex array object is currently bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribPointervARB")]
		[AliasOf("glGetVertexAttribPointervNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttribPointer(UInt32 index, Int32 pname, out IntPtr pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = &pointer)
				{
					Debug.Assert(Delegates.pglGetVertexAttribPointerv != null, "pglGetVertexAttribPointerv not implemented");
					Delegates.pglGetVertexAttribPointerv(index, pname, p_pointer);
					LogCommand("glGetVertexAttribPointerv", null, index, pname, pointer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] return the address of the specified generic vertex attribute pointer
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be returned.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the generic vertex attribute parameter to be returned. Must be 
		/// Gl.VERTEX_ATTRIB_ARRAY_POINTER.
		/// </param>
		/// <param name="pointer">
		/// Returns the pointer value.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if no vertex array object is currently bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribPointervARB")]
		[AliasOf("glGetVertexAttribPointervNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GetVertexAttribPointer(UInt32 index, Int32 pname, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				GetVertexAttribPointer(index, pname, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Determines if a name corresponds to a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies a potential program object.
		/// </param>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsProgram(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgram != null, "pglIsProgram not implemented");
			retValue = Delegates.pglIsProgram(program);
			LogCommand("glIsProgram", retValue, program			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Determines if a name corresponds to a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies a potential shader object.
		/// </param>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.ShaderSource"/>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsShader(UInt32 shader)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsShader != null, "pglIsShader not implemented");
			retValue = Delegates.pglIsShader(shader);
			LogCommand("glIsShader", retValue, shader			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Links a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be linked.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is the currently active program object and transform 
		/// feedback mode is active.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		[AliasOf("glLinkProgramARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void LinkProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglLinkProgram != null, "pglLinkProgram not implemented");
			Delegates.pglLinkProgram(program);
			LogCommand("glLinkProgram", null, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Replaces the source code in a shader object
		/// </para>
		/// </summary>
		/// <param name="shader">
		/// Specifies the handle of the shader object whose source code is to be replaced.
		/// </param>
		/// <param name="string">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <param name="length">
		/// Specifies an array of string lengths.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shader"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="shader"/> is not a shader object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.DeleteShader"/>
		[AliasOf("glShaderSourceARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void ShaderSource(UInt32 shader, String[] @string, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglShaderSource != null, "pglShaderSource not implemented");
					Delegates.pglShaderSource(shader, (Int32)@string.Length, @string, p_length);
					LogCommand("glShaderSource", null, shader, @string.Length, @string, length					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Installs a program object as part of current rendering state
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object whose executables are to be used as part of current rendering state.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is neither 0 nor a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> could not be made part of current state.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if transform feedback mode is active.
		/// </exception>
		/// <seealso cref="Gl.AttachShader"/>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.DeleteProgram"/>
		/// <seealso cref="Gl.DetachShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.ValidateProgram"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glUseProgramObjectARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UseProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgram != null, "pglUseProgram not implemented");
			Delegates.pglUseProgram(program);
			LogCommand("glUseProgram", null, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, float v0)
		{
			Debug.Assert(Delegates.pglUniform1f != null, "pglUniform1f not implemented");
			Delegates.pglUniform1f(location, v0);
			LogCommand("glUniform1f", null, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, float v0, float v1)
		{
			Debug.Assert(Delegates.pglUniform2f != null, "pglUniform2f not implemented");
			Delegates.pglUniform2f(location, v0, v1);
			LogCommand("glUniform2f", null, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, float v0, float v1, float v2)
		{
			Debug.Assert(Delegates.pglUniform3f != null, "pglUniform3f not implemented");
			Delegates.pglUniform3f(location, v0, v1, v2);
			LogCommand("glUniform3f", null, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, float v0, float v1, float v2, float v3)
		{
			Debug.Assert(Delegates.pglUniform4f != null, "pglUniform4f not implemented");
			Delegates.pglUniform4f(location, v0, v1, v2, v3);
			LogCommand("glUniform4f", null, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 v0)
		{
			Debug.Assert(Delegates.pglUniform1i != null, "pglUniform1i not implemented");
			Delegates.pglUniform1i(location, v0);
			LogCommand("glUniform1i", null, location, v0			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 v0, Int32 v1)
		{
			Debug.Assert(Delegates.pglUniform2i != null, "pglUniform2i not implemented");
			Delegates.pglUniform2i(location, v0, v1);
			LogCommand("glUniform2i", null, location, v0, v1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			Debug.Assert(Delegates.pglUniform3i != null, "pglUniform3i not implemented");
			Delegates.pglUniform3i(location, v0, v1, v2);
			LogCommand("glUniform3i", null, location, v0, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4iARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			Debug.Assert(Delegates.pglUniform4i != null, "pglUniform4i not implemented");
			Delegates.pglUniform4i(location, v0, v1, v2, v3);
			LogCommand("glUniform4i", null, location, v0, v1, v2, v3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1fv != null, "pglUniform1fv not implemented");
					Delegates.pglUniform1fv(location, count, p_value);
					LogCommand("glUniform1fv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform1(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform1fv != null, "pglUniform1fv not implemented");
			Delegates.pglUniform1fv(location, count, value);
			LogCommand("glUniform1fv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2fv != null, "pglUniform2fv not implemented");
					Delegates.pglUniform2fv(location, count, p_value);
					LogCommand("glUniform2fv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform2(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform2fv != null, "pglUniform2fv not implemented");
			Delegates.pglUniform2fv(location, count, value);
			LogCommand("glUniform2fv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3fv != null, "pglUniform3fv not implemented");
					Delegates.pglUniform3fv(location, count, p_value);
					LogCommand("glUniform3fv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform3(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform3fv != null, "pglUniform3fv not implemented");
			Delegates.pglUniform3fv(location, count, value);
			LogCommand("glUniform3fv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4fv != null, "pglUniform4fv not implemented");
					Delegates.pglUniform4fv(location, count, p_value);
					LogCommand("glUniform4fv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform4(Int32 location, Int32 count, float* value)
		{
			Debug.Assert(Delegates.pglUniform4fv != null, "pglUniform4fv not implemented");
			Delegates.pglUniform4fv(location, count, value);
			LogCommand("glUniform4fv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform1(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1iv != null, "pglUniform1iv not implemented");
					Delegates.pglUniform1iv(location, count, p_value);
					LogCommand("glUniform1iv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform1ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform1(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform1iv != null, "pglUniform1iv not implemented");
			Delegates.pglUniform1iv(location, count, value);
			LogCommand("glUniform1iv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform2(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2iv != null, "pglUniform2iv not implemented");
					Delegates.pglUniform2iv(location, count, p_value);
					LogCommand("glUniform2iv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform2ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform2(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform2iv != null, "pglUniform2iv not implemented");
			Delegates.pglUniform2iv(location, count, value);
			LogCommand("glUniform2iv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform3(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3iv != null, "pglUniform3iv not implemented");
					Delegates.pglUniform3iv(location, count, p_value);
					LogCommand("glUniform3iv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform3ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform3(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform3iv != null, "pglUniform3iv not implemented");
			Delegates.pglUniform3iv(location, count, value);
			LogCommand("glUniform3iv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void Uniform4(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4iv != null, "pglUniform4iv not implemented");
					Delegates.pglUniform4iv(location, count, p_value);
					LogCommand("glUniform4iv", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniform4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void Uniform4(Int32 location, Int32 count, Int32* value)
		{
			Debug.Assert(Delegates.pglUniform4iv != null, "pglUniform4iv not implemented");
			Delegates.pglUniform4iv(location, count, value);
			LogCommand("glUniform4iv", null, location, count, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2fv != null, "pglUniformMatrix2fv not implemented");
					Delegates.pglUniformMatrix2fv(location, count, transpose, p_value);
					LogCommand("glUniformMatrix2fv", null, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix2fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void UniformMatrix2(Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglUniformMatrix2fv != null, "pglUniformMatrix2fv not implemented");
			Delegates.pglUniformMatrix2fv(location, count, transpose, value);
			LogCommand("glUniformMatrix2fv", null, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3fv != null, "pglUniformMatrix3fv not implemented");
					Delegates.pglUniformMatrix3fv(location, count, transpose, p_value);
					LogCommand("glUniformMatrix3fv", null, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix3fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void UniformMatrix3(Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglUniformMatrix3fv != null, "pglUniformMatrix3fv not implemented");
			Delegates.pglUniformMatrix3fv(location, count, transpose, value);
			LogCommand("glUniformMatrix3fv", null, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void UniformMatrix4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4fv != null, "pglUniformMatrix4fv not implemented");
					Delegates.pglUniformMatrix4fv(location, count, transpose, p_value);
					LogCommand("glUniformMatrix4fv", null, location, count, transpose, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specify the value of a uniform variable for the current program object
		/// </para>
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (Gl.Uniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if 
		/// the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no current program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.Uniform command.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for the current program 
		/// object and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.Uniform1i and Gl.Uniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glUniformMatrix4fvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static unsafe void UniformMatrix4(Int32 location, Int32 count, bool transpose, float* value)
		{
			Debug.Assert(Delegates.pglUniformMatrix4fv != null, "pglUniformMatrix4fv not implemented");
			Delegates.pglUniformMatrix4fv(location, count, transpose, value);
			LogCommand("glUniformMatrix4fv", null, location, count, transpose, new IntPtr(value).ToString("X8")			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Validates a program object
		/// </para>
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program object to be validated.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glValidateProgramARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void ValidateProgram(UInt32 program)
		{
			Debug.Assert(Delegates.pglValidateProgram != null, "pglValidateProgram not implemented");
			Delegates.pglValidateProgram(program);
			LogCommand("glValidateProgram", null, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1dARB")]
		[AliasOf("glVertexAttrib1dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1d != null, "pglVertexAttrib1d not implemented");
			Delegates.pglVertexAttrib1d(index, x);
			LogCommand("glVertexAttrib1d", null, index, x			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1dvARB")]
		[AliasOf("glVertexAttrib1dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1dv != null, "pglVertexAttrib1dv not implemented");
					Delegates.pglVertexAttrib1dv(index, p_v);
					LogCommand("glVertexAttrib1dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1fARB")]
		[AliasOf("glVertexAttrib1fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, float x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1f != null, "pglVertexAttrib1f not implemented");
			Delegates.pglVertexAttrib1f(index, x);
			LogCommand("glVertexAttrib1f", null, index, x			);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1fvARB")]
		[AliasOf("glVertexAttrib1fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1fv != null, "pglVertexAttrib1fv not implemented");
					Delegates.pglVertexAttrib1fv(index, p_v);
					LogCommand("glVertexAttrib1fv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1sARB")]
		[AliasOf("glVertexAttrib1sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, Int16 x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1s != null, "pglVertexAttrib1s not implemented");
			Delegates.pglVertexAttrib1s(index, x);
			LogCommand("glVertexAttrib1s", null, index, x			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib1svARB")]
		[AliasOf("glVertexAttrib1svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib1(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1sv != null, "pglVertexAttrib1sv not implemented");
					Delegates.pglVertexAttrib1sv(index, p_v);
					LogCommand("glVertexAttrib1sv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2dARB")]
		[AliasOf("glVertexAttrib2dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2d != null, "pglVertexAttrib2d not implemented");
			Delegates.pglVertexAttrib2d(index, x, y);
			LogCommand("glVertexAttrib2d", null, index, x, y			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2dvARB")]
		[AliasOf("glVertexAttrib2dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2dv != null, "pglVertexAttrib2dv not implemented");
					Delegates.pglVertexAttrib2dv(index, p_v);
					LogCommand("glVertexAttrib2dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2fARB")]
		[AliasOf("glVertexAttrib2fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, float x, float y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2f != null, "pglVertexAttrib2f not implemented");
			Delegates.pglVertexAttrib2f(index, x, y);
			LogCommand("glVertexAttrib2f", null, index, x, y			);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2fvARB")]
		[AliasOf("glVertexAttrib2fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2fv != null, "pglVertexAttrib2fv not implemented");
					Delegates.pglVertexAttrib2fv(index, p_v);
					LogCommand("glVertexAttrib2fv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2sARB")]
		[AliasOf("glVertexAttrib2sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2s != null, "pglVertexAttrib2s not implemented");
			Delegates.pglVertexAttrib2s(index, x, y);
			LogCommand("glVertexAttrib2s", null, index, x, y			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib2svARB")]
		[AliasOf("glVertexAttrib2svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib2(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2sv != null, "pglVertexAttrib2sv not implemented");
					Delegates.pglVertexAttrib2sv(index, p_v);
					LogCommand("glVertexAttrib2sv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3dARB")]
		[AliasOf("glVertexAttrib3dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3d != null, "pglVertexAttrib3d not implemented");
			Delegates.pglVertexAttrib3d(index, x, y, z);
			LogCommand("glVertexAttrib3d", null, index, x, y, z			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3dvARB")]
		[AliasOf("glVertexAttrib3dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3dv != null, "pglVertexAttrib3dv not implemented");
					Delegates.pglVertexAttrib3dv(index, p_v);
					LogCommand("glVertexAttrib3dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3fARB")]
		[AliasOf("glVertexAttrib3fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3f != null, "pglVertexAttrib3f not implemented");
			Delegates.pglVertexAttrib3f(index, x, y, z);
			LogCommand("glVertexAttrib3f", null, index, x, y, z			);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3fvARB")]
		[AliasOf("glVertexAttrib3fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3fv != null, "pglVertexAttrib3fv not implemented");
					Delegates.pglVertexAttrib3fv(index, p_v);
					LogCommand("glVertexAttrib3fv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3sARB")]
		[AliasOf("glVertexAttrib3sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3s != null, "pglVertexAttrib3s not implemented");
			Delegates.pglVertexAttrib3s(index, x, y, z);
			LogCommand("glVertexAttrib3s", null, index, x, y, z			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib3svARB")]
		[AliasOf("glVertexAttrib3svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib3(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3sv != null, "pglVertexAttrib3sv not implemented");
					Delegates.pglVertexAttrib3sv(index, p_v);
					LogCommand("glVertexAttrib3sv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NbvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nbv != null, "pglVertexAttrib4Nbv not implemented");
					Delegates.pglVertexAttrib4Nbv(index, p_v);
					LogCommand("glVertexAttrib4Nbv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Niv != null, "pglVertexAttrib4Niv not implemented");
					Delegates.pglVertexAttrib4Niv(index, p_v);
					LogCommand("glVertexAttrib4Niv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NsvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nsv != null, "pglVertexAttrib4Nsv not implemented");
					Delegates.pglVertexAttrib4Nsv(index, p_v);
					LogCommand("glVertexAttrib4Nsv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NubARB")]
		[AliasOf("glVertexAttrib4ubNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4N(UInt32 index, byte x, byte y, byte z, byte w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4Nub != null, "pglVertexAttrib4Nub not implemented");
			Delegates.pglVertexAttrib4Nub(index, x, y, z, w);
			LogCommand("glVertexAttrib4Nub", null, index, x, y, z, w			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NubvARB")]
		[AliasOf("glVertexAttrib4ubvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4N(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nubv != null, "pglVertexAttrib4Nubv not implemented");
					Delegates.pglVertexAttrib4Nubv(index, p_v);
					LogCommand("glVertexAttrib4Nubv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NuivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nuiv != null, "pglVertexAttrib4Nuiv not implemented");
					Delegates.pglVertexAttrib4Nuiv(index, p_v);
					LogCommand("glVertexAttrib4Nuiv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4NusvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4N(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4Nusv != null, "pglVertexAttrib4Nusv not implemented");
					Delegates.pglVertexAttrib4Nusv(index, p_v);
					LogCommand("glVertexAttrib4Nusv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4bvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4bv != null, "pglVertexAttrib4bv not implemented");
					Delegates.pglVertexAttrib4bv(index, p_v);
					LogCommand("glVertexAttrib4bv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4dARB")]
		[AliasOf("glVertexAttrib4dNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4d != null, "pglVertexAttrib4d not implemented");
			Delegates.pglVertexAttrib4d(index, x, y, z, w);
			LogCommand("glVertexAttrib4d", null, index, x, y, z, w			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4dvARB")]
		[AliasOf("glVertexAttrib4dvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4dv != null, "pglVertexAttrib4dv not implemented");
					Delegates.pglVertexAttrib4dv(index, p_v);
					LogCommand("glVertexAttrib4dv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4fARB")]
		[AliasOf("glVertexAttrib4fNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4f != null, "pglVertexAttrib4f not implemented");
			Delegates.pglVertexAttrib4f(index, x, y, z, w);
			LogCommand("glVertexAttrib4f", null, index, x, y, z, w			);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] Specifies the value of a generic vertex attribute
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4fvARB")]
		[AliasOf("glVertexAttrib4fvNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4fv != null, "pglVertexAttrib4fv not implemented");
					Delegates.pglVertexAttrib4fv(index, p_v);
					LogCommand("glVertexAttrib4fv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4ivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4iv != null, "pglVertexAttrib4iv not implemented");
					Delegates.pglVertexAttrib4iv(index, p_v);
					LogCommand("glVertexAttrib4iv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4sARB")]
		[AliasOf("glVertexAttrib4sNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4s != null, "pglVertexAttrib4s not implemented");
			Delegates.pglVertexAttrib4s(index, x, y, z, w);
			LogCommand("glVertexAttrib4s", null, index, x, y, z, w			);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4svARB")]
		[AliasOf("glVertexAttrib4svNV")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void VertexAttrib4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4sv != null, "pglVertexAttrib4sv not implemented");
					Delegates.pglVertexAttrib4sv(index, p_v);
					LogCommand("glVertexAttrib4sv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4ubvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4ub(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4ubv != null, "pglVertexAttrib4ubv not implemented");
					Delegates.pglVertexAttrib4ubv(index, p_v);
					LogCommand("glVertexAttrib4ubv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4uivARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4uiv != null, "pglVertexAttrib4uiv not implemented");
					Delegates.pglVertexAttrib4uiv(index, p_v);
					LogCommand("glVertexAttrib4uiv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL4] Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttrib4usvARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttrib4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4usv != null, "pglVertexAttrib4usv not implemented");
					Delegates.pglVertexAttrib4usv(index, p_v);
					LogCommand("glVertexAttrib4usv", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] define an array of generic vertex attribute data
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For Gl.VertexAttribPointer, specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted 
		/// directly as fixed-point values (Gl.FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribPointerARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, VertexAttribType type, bool normalized, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribPointer != null, "pglVertexAttribPointer not implemented");
			Delegates.pglVertexAttribPointer(index, size, (Int32)type, normalized, stride, pointer);
			LogCommand("glVertexAttribPointer", null, index, size, type, normalized, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// <para>
		/// [GL4|GLES3.2] define an array of generic vertex attribute data
		/// </para>
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="normalized">
		/// For Gl.VertexAttribPointer, specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted 
		/// directly as fixed-point values (Gl.FALSE) when they are accessed.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribPointerARB")]
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public static void VertexAttribPointer(UInt32 index, Int32 size, VertexAttribType type, bool normalized, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribPointer(index, size, type, normalized, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparate(Int32 modeRGB, Int32 modeAlpha);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
			internal extern static unsafe void glDrawBuffers(Int32 n, Int32* bufs);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
			internal extern static void glStencilOpSeparate(Int32 face, Int32 sfail, Int32 dpfail, Int32 dppass);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
			internal extern static void glStencilFuncSeparate(Int32 face, Int32 func, Int32 @ref, UInt32 mask);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
			internal extern static void glStencilMaskSeparate(Int32 face, UInt32 mask);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
			internal extern static void glAttachShader(UInt32 program, UInt32 shader);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
			internal extern static void glBindAttribLocation(UInt32 program, UInt32 index, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
			internal extern static void glCompileShader(UInt32 shader);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
			internal extern static UInt32 glCreateProgram();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
			internal extern static UInt32 glCreateShader(Int32 type);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
			internal extern static void glDeleteProgram(UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
			internal extern static void glDeleteShader(UInt32 shader);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
			internal extern static void glDetachShader(UInt32 program, UInt32 shader);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
			internal extern static void glDisableVertexAttribArray(UInt32 index);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
			internal extern static void glEnableVertexAttribArray(UInt32 index);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
			internal extern static unsafe void glGetAttachedShaders(UInt32 program, Int32 maxCount, Int32* count, UInt32* shaders);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
			internal extern static Int32 glGetAttribLocation(UInt32 program, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramiv(UInt32 program, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramInfoLog(UInt32 program, Int32 bufSize, Int32* length, String infoLog);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderiv(UInt32 shader, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, Int32* length, String infoLog);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
			internal extern static unsafe void glGetShaderSource(UInt32 shader, Int32 bufSize, Int32* length, String source);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
			internal extern static Int32 glGetUniformLocation(UInt32 program, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformfv(UInt32 program, Int32 location, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformiv(UInt32 program, Int32 location, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribdv(UInt32 index, Int32 pname, double* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribfv(UInt32 index, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribiv(UInt32 index, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribPointerv(UInt32 index, Int32 pname, IntPtr* pointer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsProgram(UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsShader", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsShader(UInt32 shader);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
			internal extern static void glLinkProgram(UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
			internal extern static unsafe void glShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
			internal extern static void glUseProgram(UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
			internal extern static void glUniform1f(Int32 location, float v0);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
			internal extern static void glUniform2f(Int32 location, float v0, float v1);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
			internal extern static void glUniform3f(Int32 location, float v0, float v1, float v2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
			internal extern static void glUniform4f(Int32 location, float v0, float v1, float v2, float v3);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
			internal extern static void glUniform1i(Int32 location, Int32 v0);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
			internal extern static void glUniform2i(Int32 location, Int32 v0, Int32 v1);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
			internal extern static void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
			internal extern static void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1fv(Int32 location, Int32 count, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2fv(Int32 location, Int32 count, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3fv(Int32 location, Int32 count, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4fv(Int32 location, Int32 count, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform1iv(Int32 location, Int32 count, Int32* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform2iv(Int32 location, Int32 count, Int32* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform3iv(Int32 location, Int32 count, Int32* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
			internal extern static unsafe void glUniform4iv(Int32 location, Int32 count, Int32* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix2fv(Int32 location, Int32 count, bool transpose, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix3fv(Int32 location, Int32 count, bool transpose, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
			internal extern static unsafe void glUniformMatrix4fv(Int32 location, Int32 count, bool transpose, float* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
			internal extern static void glValidateProgram(UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
			internal extern static void glVertexAttrib1d(UInt32 index, double x);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1dv(UInt32 index, double* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
			internal extern static void glVertexAttrib1f(UInt32 index, float x);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1fv(UInt32 index, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
			internal extern static void glVertexAttrib1s(UInt32 index, Int16 x);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1sv(UInt32 index, Int16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
			internal extern static void glVertexAttrib2d(UInt32 index, double x, double y);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2dv(UInt32 index, double* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
			internal extern static void glVertexAttrib2f(UInt32 index, float x, float y);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2fv(UInt32 index, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
			internal extern static void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2sv(UInt32 index, Int16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
			internal extern static void glVertexAttrib3d(UInt32 index, double x, double y, double z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3dv(UInt32 index, double* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
			internal extern static void glVertexAttrib3f(UInt32 index, float x, float y, float z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3fv(UInt32 index, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
			internal extern static void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3sv(UInt32 index, Int16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nbv(UInt32 index, sbyte* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Niv(UInt32 index, Int32* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nsv(UInt32 index, Int16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
			internal extern static void glVertexAttrib4Nub(UInt32 index, byte x, byte y, byte z, byte w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nubv(UInt32 index, byte* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nuiv(UInt32 index, UInt32* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4Nusv(UInt32 index, UInt16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4bv(UInt32 index, sbyte* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
			internal extern static void glVertexAttrib4d(UInt32 index, double x, double y, double z, double w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4dv(UInt32 index, double* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
			internal extern static void glVertexAttrib4f(UInt32 index, float x, float y, float z, float w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4fv(UInt32 index, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4iv(UInt32 index, Int32* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
			internal extern static void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4sv(UInt32 index, Int16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4ubv(UInt32 index, byte* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4uiv(UInt32 index, UInt32* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4usv(UInt32 index, UInt16* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_EXT_blend_equation_separate")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBlendEquationSeparate(Int32 modeRGB, Int32 modeAlpha);

			[AliasOf("glBlendEquationSeparate")]
			[AliasOf("glBlendEquationSeparateEXT")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_EXT_blend_equation_separate")]
			[ThreadStatic]
			internal static glBlendEquationSeparate pglBlendEquationSeparate;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_buffers")]
			[RequiredByFeature("GL_ATI_draw_buffers")]
			[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDrawBuffers(Int32 n, Int32* bufs);

			[AliasOf("glDrawBuffers")]
			[AliasOf("glDrawBuffersARB")]
			[AliasOf("glDrawBuffersATI")]
			[AliasOf("glDrawBuffersEXT")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_buffers")]
			[RequiredByFeature("GL_ATI_draw_buffers")]
			[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
			[ThreadStatic]
			internal static glDrawBuffers pglDrawBuffers;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ATI_separate_stencil")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glStencilOpSeparate(Int32 face, Int32 sfail, Int32 dpfail, Int32 dppass);

			[AliasOf("glStencilOpSeparate")]
			[AliasOf("glStencilOpSeparateATI")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ATI_separate_stencil")]
			[ThreadStatic]
			internal static glStencilOpSeparate pglStencilOpSeparate;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glStencilFuncSeparate(Int32 face, Int32 func, Int32 @ref, UInt32 mask);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[ThreadStatic]
			internal static glStencilFuncSeparate pglStencilFuncSeparate;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glStencilMaskSeparate(Int32 face, UInt32 mask);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[ThreadStatic]
			internal static glStencilMaskSeparate pglStencilMaskSeparate;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glAttachShader(UInt32 program, UInt32 shader);

			[AliasOf("glAttachShader")]
			[AliasOf("glAttachObjectARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glAttachShader pglAttachShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBindAttribLocation(UInt32 program, UInt32 index, String name);

			[AliasOf("glBindAttribLocation")]
			[AliasOf("glBindAttribLocationARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glBindAttribLocation pglBindAttribLocation;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glCompileShader(UInt32 shader);

			[AliasOf("glCompileShader")]
			[AliasOf("glCompileShaderARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glCompileShader pglCompileShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate UInt32 glCreateProgram();

			[AliasOf("glCreateProgram")]
			[AliasOf("glCreateProgramObjectARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glCreateProgram pglCreateProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate UInt32 glCreateShader(Int32 type);

			[AliasOf("glCreateShader")]
			[AliasOf("glCreateShaderObjectARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glCreateShader pglCreateShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDeleteProgram(UInt32 program);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glDeleteProgram pglDeleteProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDeleteShader(UInt32 shader);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glDeleteShader pglDeleteShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDetachShader(UInt32 program, UInt32 shader);

			[AliasOf("glDetachShader")]
			[AliasOf("glDetachObjectARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glDetachShader pglDetachShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDisableVertexAttribArray(UInt32 index);

			[AliasOf("glDisableVertexAttribArray")]
			[AliasOf("glDisableVertexAttribArrayARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glDisableVertexAttribArray pglDisableVertexAttribArray;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glEnableVertexAttribArray(UInt32 index);

			[AliasOf("glEnableVertexAttribArray")]
			[AliasOf("glEnableVertexAttribArrayARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glEnableVertexAttribArray pglEnableVertexAttribArray;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[AliasOf("glGetActiveAttrib")]
			[AliasOf("glGetActiveAttribARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glGetActiveAttrib pglGetActiveAttrib;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[AliasOf("glGetActiveUniform")]
			[AliasOf("glGetActiveUniformARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetActiveUniform pglGetActiveUniform;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetAttachedShaders(UInt32 program, Int32 maxCount, Int32* count, UInt32* shaders);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetAttachedShaders pglGetAttachedShaders;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glGetAttribLocation(UInt32 program, String name);

			[AliasOf("glGetAttribLocation")]
			[AliasOf("glGetAttribLocationARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glGetAttribLocation pglGetAttribLocation;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramiv(UInt32 program, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[ThreadStatic]
			internal static glGetProgramiv pglGetProgramiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramInfoLog(UInt32 program, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramInfoLog pglGetProgramInfoLog;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetShaderiv(UInt32 shader, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetShaderiv pglGetShaderiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glGetShaderInfoLog pglGetShaderInfoLog;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetShaderSource(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder source);

			[AliasOf("glGetShaderSource")]
			[AliasOf("glGetShaderSourceARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetShaderSource pglGetShaderSource;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glGetUniformLocation(UInt32 program, String name);

			[AliasOf("glGetUniformLocation")]
			[AliasOf("glGetUniformLocationARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetUniformLocation pglGetUniformLocation;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetUniformfv(UInt32 program, Int32 location, float* @params);

			[AliasOf("glGetUniformfv")]
			[AliasOf("glGetUniformfvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetUniformfv pglGetUniformfv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetUniformiv(UInt32 program, Int32 location, Int32* @params);

			[AliasOf("glGetUniformiv")]
			[AliasOf("glGetUniformivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glGetUniformiv pglGetUniformiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribdv(UInt32 index, Int32 pname, double* @params);

			[AliasOf("glGetVertexAttribdv")]
			[AliasOf("glGetVertexAttribdvARB")]
			[AliasOf("glGetVertexAttribdvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetVertexAttribdv pglGetVertexAttribdv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribfv(UInt32 index, Int32 pname, float* @params);

			[AliasOf("glGetVertexAttribfv")]
			[AliasOf("glGetVertexAttribfvARB")]
			[AliasOf("glGetVertexAttribfvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetVertexAttribfv pglGetVertexAttribfv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribiv(UInt32 index, Int32 pname, Int32* @params);

			[AliasOf("glGetVertexAttribiv")]
			[AliasOf("glGetVertexAttribivARB")]
			[AliasOf("glGetVertexAttribivNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetVertexAttribiv pglGetVertexAttribiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribPointerv(UInt32 index, Int32 pname, IntPtr* pointer);

			[AliasOf("glGetVertexAttribPointerv")]
			[AliasOf("glGetVertexAttribPointervARB")]
			[AliasOf("glGetVertexAttribPointervNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGetVertexAttribPointerv pglGetVertexAttribPointerv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsProgram(UInt32 program);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glIsProgram pglIsProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsShader(UInt32 shader);

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[ThreadStatic]
			internal static glIsShader pglIsShader;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glLinkProgram(UInt32 program);

			[AliasOf("glLinkProgram")]
			[AliasOf("glLinkProgramARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glLinkProgram pglLinkProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);

			[AliasOf("glShaderSource")]
			[AliasOf("glShaderSourceARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glShaderSource pglShaderSource;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUseProgram(UInt32 program);

			[AliasOf("glUseProgram")]
			[AliasOf("glUseProgramObjectARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUseProgram pglUseProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform1f(Int32 location, float v0);

			[AliasOf("glUniform1f")]
			[AliasOf("glUniform1fARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform1f pglUniform1f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform2f(Int32 location, float v0, float v1);

			[AliasOf("glUniform2f")]
			[AliasOf("glUniform2fARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform2f pglUniform2f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform3f(Int32 location, float v0, float v1, float v2);

			[AliasOf("glUniform3f")]
			[AliasOf("glUniform3fARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform3f pglUniform3f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform4f(Int32 location, float v0, float v1, float v2, float v3);

			[AliasOf("glUniform4f")]
			[AliasOf("glUniform4fARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform4f pglUniform4f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform1i(Int32 location, Int32 v0);

			[AliasOf("glUniform1i")]
			[AliasOf("glUniform1iARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform1i pglUniform1i;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform2i(Int32 location, Int32 v0, Int32 v1);

			[AliasOf("glUniform2i")]
			[AliasOf("glUniform2iARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform2i pglUniform2i;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);

			[AliasOf("glUniform3i")]
			[AliasOf("glUniform3iARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform3i pglUniform3i;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);

			[AliasOf("glUniform4i")]
			[AliasOf("glUniform4iARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform4i pglUniform4i;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform1fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform1fv")]
			[AliasOf("glUniform1fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform1fv pglUniform1fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform2fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform2fv")]
			[AliasOf("glUniform2fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform2fv pglUniform2fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform3fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform3fv")]
			[AliasOf("glUniform3fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform3fv pglUniform3fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform4fv(Int32 location, Int32 count, float* value);

			[AliasOf("glUniform4fv")]
			[AliasOf("glUniform4fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform4fv pglUniform4fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform1iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform1iv")]
			[AliasOf("glUniform1ivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform1iv pglUniform1iv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform2iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform2iv")]
			[AliasOf("glUniform2ivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform2iv pglUniform2iv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform3iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform3iv")]
			[AliasOf("glUniform3ivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform3iv pglUniform3iv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniform4iv(Int32 location, Int32 count, Int32* value);

			[AliasOf("glUniform4iv")]
			[AliasOf("glUniform4ivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniform4iv pglUniform4iv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniformMatrix2fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix2fv")]
			[AliasOf("glUniformMatrix2fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniformMatrix2fv pglUniformMatrix2fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniformMatrix3fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix3fv")]
			[AliasOf("glUniformMatrix3fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniformMatrix3fv pglUniformMatrix3fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glUniformMatrix4fv(Int32 location, Int32 count, bool transpose, float* value);

			[AliasOf("glUniformMatrix4fv")]
			[AliasOf("glUniformMatrix4fvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glUniformMatrix4fv pglUniformMatrix4fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glValidateProgram(UInt32 program);

			[AliasOf("glValidateProgram")]
			[AliasOf("glValidateProgramARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_objects")]
			[ThreadStatic]
			internal static glValidateProgram pglValidateProgram;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib1d(UInt32 index, double x);

			[AliasOf("glVertexAttrib1d")]
			[AliasOf("glVertexAttrib1dARB")]
			[AliasOf("glVertexAttrib1dNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1d pglVertexAttrib1d;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib1dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib1dv")]
			[AliasOf("glVertexAttrib1dvARB")]
			[AliasOf("glVertexAttrib1dvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1dv pglVertexAttrib1dv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib1f(UInt32 index, float x);

			[AliasOf("glVertexAttrib1f")]
			[AliasOf("glVertexAttrib1fARB")]
			[AliasOf("glVertexAttrib1fNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1f pglVertexAttrib1f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib1fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib1fv")]
			[AliasOf("glVertexAttrib1fvARB")]
			[AliasOf("glVertexAttrib1fvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1fv pglVertexAttrib1fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib1s(UInt32 index, Int16 x);

			[AliasOf("glVertexAttrib1s")]
			[AliasOf("glVertexAttrib1sARB")]
			[AliasOf("glVertexAttrib1sNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1s pglVertexAttrib1s;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib1sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib1sv")]
			[AliasOf("glVertexAttrib1svARB")]
			[AliasOf("glVertexAttrib1svNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib1sv pglVertexAttrib1sv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib2d(UInt32 index, double x, double y);

			[AliasOf("glVertexAttrib2d")]
			[AliasOf("glVertexAttrib2dARB")]
			[AliasOf("glVertexAttrib2dNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2d pglVertexAttrib2d;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib2dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib2dv")]
			[AliasOf("glVertexAttrib2dvARB")]
			[AliasOf("glVertexAttrib2dvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2dv pglVertexAttrib2dv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib2f(UInt32 index, float x, float y);

			[AliasOf("glVertexAttrib2f")]
			[AliasOf("glVertexAttrib2fARB")]
			[AliasOf("glVertexAttrib2fNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2f pglVertexAttrib2f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib2fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib2fv")]
			[AliasOf("glVertexAttrib2fvARB")]
			[AliasOf("glVertexAttrib2fvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2fv pglVertexAttrib2fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);

			[AliasOf("glVertexAttrib2s")]
			[AliasOf("glVertexAttrib2sARB")]
			[AliasOf("glVertexAttrib2sNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2s pglVertexAttrib2s;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib2sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib2sv")]
			[AliasOf("glVertexAttrib2svARB")]
			[AliasOf("glVertexAttrib2svNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib2sv pglVertexAttrib2sv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib3d(UInt32 index, double x, double y, double z);

			[AliasOf("glVertexAttrib3d")]
			[AliasOf("glVertexAttrib3dARB")]
			[AliasOf("glVertexAttrib3dNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3d pglVertexAttrib3d;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib3dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib3dv")]
			[AliasOf("glVertexAttrib3dvARB")]
			[AliasOf("glVertexAttrib3dvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3dv pglVertexAttrib3dv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib3f(UInt32 index, float x, float y, float z);

			[AliasOf("glVertexAttrib3f")]
			[AliasOf("glVertexAttrib3fARB")]
			[AliasOf("glVertexAttrib3fNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3f pglVertexAttrib3f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib3fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib3fv")]
			[AliasOf("glVertexAttrib3fvARB")]
			[AliasOf("glVertexAttrib3fvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3fv pglVertexAttrib3fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);

			[AliasOf("glVertexAttrib3s")]
			[AliasOf("glVertexAttrib3sARB")]
			[AliasOf("glVertexAttrib3sNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3s pglVertexAttrib3s;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib3sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib3sv")]
			[AliasOf("glVertexAttrib3svARB")]
			[AliasOf("glVertexAttrib3svNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib3sv pglVertexAttrib3sv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Nbv(UInt32 index, sbyte* v);

			[AliasOf("glVertexAttrib4Nbv")]
			[AliasOf("glVertexAttrib4NbvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4Nbv pglVertexAttrib4Nbv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Niv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttrib4Niv")]
			[AliasOf("glVertexAttrib4NivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4Niv pglVertexAttrib4Niv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Nsv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib4Nsv")]
			[AliasOf("glVertexAttrib4NsvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4Nsv pglVertexAttrib4Nsv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib4Nub(UInt32 index, byte x, byte y, byte z, byte w);

			[AliasOf("glVertexAttrib4Nub")]
			[AliasOf("glVertexAttrib4NubARB")]
			[AliasOf("glVertexAttrib4ubNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4Nub pglVertexAttrib4Nub;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Nubv(UInt32 index, byte* v);

			[AliasOf("glVertexAttrib4Nubv")]
			[AliasOf("glVertexAttrib4NubvARB")]
			[AliasOf("glVertexAttrib4ubvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4Nubv pglVertexAttrib4Nubv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Nuiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttrib4Nuiv")]
			[AliasOf("glVertexAttrib4NuivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4Nuiv pglVertexAttrib4Nuiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4Nusv(UInt32 index, UInt16* v);

			[AliasOf("glVertexAttrib4Nusv")]
			[AliasOf("glVertexAttrib4NusvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4Nusv pglVertexAttrib4Nusv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4bv(UInt32 index, sbyte* v);

			[AliasOf("glVertexAttrib4bv")]
			[AliasOf("glVertexAttrib4bvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4bv pglVertexAttrib4bv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib4d(UInt32 index, double x, double y, double z, double w);

			[AliasOf("glVertexAttrib4d")]
			[AliasOf("glVertexAttrib4dARB")]
			[AliasOf("glVertexAttrib4dNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4d pglVertexAttrib4d;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4dv(UInt32 index, double* v);

			[AliasOf("glVertexAttrib4dv")]
			[AliasOf("glVertexAttrib4dvARB")]
			[AliasOf("glVertexAttrib4dvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4dv pglVertexAttrib4dv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib4f(UInt32 index, float x, float y, float z, float w);

			[AliasOf("glVertexAttrib4f")]
			[AliasOf("glVertexAttrib4fARB")]
			[AliasOf("glVertexAttrib4fNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4f pglVertexAttrib4f;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4fv(UInt32 index, float* v);

			[AliasOf("glVertexAttrib4fv")]
			[AliasOf("glVertexAttrib4fvARB")]
			[AliasOf("glVertexAttrib4fvNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4fv pglVertexAttrib4fv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4iv(UInt32 index, Int32* v);

			[AliasOf("glVertexAttrib4iv")]
			[AliasOf("glVertexAttrib4ivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4iv pglVertexAttrib4iv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);

			[AliasOf("glVertexAttrib4s")]
			[AliasOf("glVertexAttrib4sARB")]
			[AliasOf("glVertexAttrib4sNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4s pglVertexAttrib4s;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4sv(UInt32 index, Int16* v);

			[AliasOf("glVertexAttrib4sv")]
			[AliasOf("glVertexAttrib4svARB")]
			[AliasOf("glVertexAttrib4svNV")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glVertexAttrib4sv pglVertexAttrib4sv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4ubv(UInt32 index, byte* v);

			[AliasOf("glVertexAttrib4ubv")]
			[AliasOf("glVertexAttrib4ubvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4ubv pglVertexAttrib4ubv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4uiv(UInt32 index, UInt32* v);

			[AliasOf("glVertexAttrib4uiv")]
			[AliasOf("glVertexAttrib4uivARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4uiv pglVertexAttrib4uiv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttrib4usv(UInt32 index, UInt16* v);

			[AliasOf("glVertexAttrib4usv")]
			[AliasOf("glVertexAttrib4usvARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttrib4usv pglVertexAttrib4usv;

			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexAttribPointer(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr pointer);

			[AliasOf("glVertexAttribPointer")]
			[AliasOf("glVertexAttribPointerARB")]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[ThreadStatic]
			internal static glVertexAttribPointer pglVertexAttribPointer;

		}
	}

}
