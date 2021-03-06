
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
		/// [GL] Value of GL_DETAIL_TEXTURE_2D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_2D_SGIS = 0x8095;

		/// <summary>
		/// [GL] Value of GL_DETAIL_TEXTURE_2D_BINDING_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;

		/// <summary>
		/// [GL] Value of GL_LINEAR_DETAIL_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_SGIS = 0x8097;

		/// <summary>
		/// [GL] Value of GL_LINEAR_DETAIL_ALPHA_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_ALPHA_SGIS = 0x8098;

		/// <summary>
		/// [GL] Value of GL_LINEAR_DETAIL_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_COLOR_SGIS = 0x8099;

		/// <summary>
		/// [GL] Value of GL_DETAIL_TEXTURE_LEVEL_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;

		/// <summary>
		/// [GL] Value of GL_DETAIL_TEXTURE_MODE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_MODE_SGIS = 0x809B;

		/// <summary>
		/// [GL] Value of GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;

		/// <summary>
		/// [GL] Binding for glDetailTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public static void DetailTexFuncSGIS(TextureTarget target, Int32 n, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglDetailTexFuncSGIS != null, "pglDetailTexFuncSGIS not implemented");
					Delegates.pglDetailTexFuncSGIS((Int32)target, n, p_points);
					LogCommand("glDetailTexFuncSGIS", null, target, n, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetDetailTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public static void GetDetailTexFuncSGIS(TextureTarget target, [Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetDetailTexFuncSGIS != null, "pglGetDetailTexFuncSGIS not implemented");
					Delegates.pglGetDetailTexFuncSGIS((Int32)target, p_points);
					LogCommand("glGetDetailTexFuncSGIS", null, target, points					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDetailTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glDetailTexFuncSGIS(Int32 target, Int32 n, float* points);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetDetailTexFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetDetailTexFuncSGIS(Int32 target, float* points);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_detail_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDetailTexFuncSGIS(Int32 target, Int32 n, float* points);

			[RequiredByFeature("GL_SGIS_detail_texture")]
			[ThreadStatic]
			internal static glDetailTexFuncSGIS pglDetailTexFuncSGIS;

			[RequiredByFeature("GL_SGIS_detail_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetDetailTexFuncSGIS(Int32 target, float* points);

			[RequiredByFeature("GL_SGIS_detail_texture")]
			[ThreadStatic]
			internal static glGetDetailTexFuncSGIS pglGetDetailTexFuncSGIS;

		}
	}

}
