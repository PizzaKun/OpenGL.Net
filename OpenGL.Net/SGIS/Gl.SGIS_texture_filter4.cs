
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
		/// [GL] Value of GL_FILTER4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int FILTER4_SGIS = 0x8146;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_FILTER4_SIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int TEXTURE_FILTER4_SIZE_SGIS = 0x8147;

		/// <summary>
		/// [GL] Binding for glGetTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void GetTexFilterFuncSGIS(TextureTarget target, Int32 filter, [Out] float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglGetTexFilterFuncSGIS != null, "pglGetTexFilterFuncSGIS not implemented");
					Delegates.pglGetTexFilterFuncSGIS((Int32)target, filter, p_weights);
					LogCommand("glGetTexFilterFuncSGIS", null, target, filter, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, Int32 n, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, n, p_weights);
					LogCommand("glTexFilterFuncSGIS", null, target, filter, n, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, (Int32)weights.Length, p_weights);
					LogCommand("glTexFilterFuncSGIS", null, target, filter, weights.Length, weights					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexFilterFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetTexFilterFuncSGIS(Int32 target, Int32 filter, float* weights);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexFilterFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glTexFilterFuncSGIS(Int32 target, Int32 filter, Int32 n, float* weights);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_texture_filter4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexFilterFuncSGIS(Int32 target, Int32 filter, float* weights);

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[ThreadStatic]
			internal static glGetTexFilterFuncSGIS pglGetTexFilterFuncSGIS;

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexFilterFuncSGIS(Int32 target, Int32 filter, Int32 n, float* weights);

			[RequiredByFeature("GL_SGIS_texture_filter4")]
			[ThreadStatic]
			internal static glTexFilterFuncSGIS pglTexFilterFuncSGIS;

		}
	}

}
