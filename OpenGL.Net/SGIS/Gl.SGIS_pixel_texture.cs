
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
		/// [GL] Value of GL_PIXEL_TEXTURE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_TEXTURE_SGIS = 0x8353;

		/// <summary>
		/// [GL] Value of GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;

		/// <summary>
		/// [GL] Value of GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;

		/// <summary>
		/// [GL] Value of GL_PIXEL_GROUP_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_GROUP_COLOR_SGIS = 0x8356;

		/// <summary>
		/// [GL] Binding for glPixelTexGenParameteriSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTexGenParameteriSGIS != null, "pglPixelTexGenParameteriSGIS not implemented");
			Delegates.pglPixelTexGenParameteriSGIS((Int32)pname, param);
			LogCommand("glPixelTexGenParameteriSGIS", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTexGenParameterivSGIS != null, "pglPixelTexGenParameterivSGIS not implemented");
					Delegates.pglPixelTexGenParameterivSGIS((Int32)pname, p_params);
					LogCommand("glPixelTexGenParameterivSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelTexGenParameterfSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTexGenParameterfSGIS != null, "pglPixelTexGenParameterfSGIS not implemented");
			Delegates.pglPixelTexGenParameterfSGIS((Int32)pname, param);
			LogCommand("glPixelTexGenParameterfSGIS", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelTexGenParameterfvSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTexGenParameterfvSGIS != null, "pglPixelTexGenParameterfvSGIS not implemented");
					Delegates.pglPixelTexGenParameterfvSGIS((Int32)pname, p_params);
					LogCommand("glPixelTexGenParameterfvSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void GetPixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTexGenParameterivSGIS != null, "pglGetPixelTexGenParameterivSGIS not implemented");
					Delegates.pglGetPixelTexGenParameterivSGIS((Int32)pname, p_params);
					LogCommand("glGetPixelTexGenParameterivSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetPixelTexGenParameterfvSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void GetPixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTexGenParameterfvSGIS != null, "pglGetPixelTexGenParameterfvSGIS not implemented");
					Delegates.pglGetPixelTexGenParameterfvSGIS((Int32)pname, p_params);
					LogCommand("glGetPixelTexGenParameterfvSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelTexGenParameteriSGIS", ExactSpelling = true)]
			internal extern static void glPixelTexGenParameteriSGIS(Int32 pname, Int32 param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelTexGenParameterivSGIS", ExactSpelling = true)]
			internal extern static unsafe void glPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelTexGenParameterfSGIS", ExactSpelling = true)]
			internal extern static void glPixelTexGenParameterfSGIS(Int32 pname, float param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelTexGenParameterfvSGIS", ExactSpelling = true)]
			internal extern static unsafe void glPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetPixelTexGenParameterivSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetPixelTexGenParameterfvSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glPixelTexGenParameteriSGIS(Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameteriSGIS pglPixelTexGenParameteriSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterivSGIS pglPixelTexGenParameterivSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glPixelTexGenParameterfSGIS(Int32 pname, float param);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterfSGIS pglPixelTexGenParameterfSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterfvSGIS pglPixelTexGenParameterfvSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetPixelTexGenParameterivSGIS(Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glGetPixelTexGenParameterivSGIS pglGetPixelTexGenParameterivSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetPixelTexGenParameterfvSGIS(Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glGetPixelTexGenParameterfvSGIS pglGetPixelTexGenParameterfvSGIS;

		}
	}

}
