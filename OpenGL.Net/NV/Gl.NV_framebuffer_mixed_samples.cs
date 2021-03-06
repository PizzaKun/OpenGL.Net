
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
		/// [GL] Value of GL_COVERAGE_MODULATION_TABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int COVERAGE_MODULATION_TABLE_NV = 0x9331;

		/// <summary>
		/// [GL] Value of GL_DEPTH_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int DEPTH_SAMPLES_NV = 0x932D;

		/// <summary>
		/// [GL] Value of GL_STENCIL_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int STENCIL_SAMPLES_NV = 0x932E;

		/// <summary>
		/// [GL] Value of GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;

		/// <summary>
		/// [GL] Value of GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_MODULATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int COVERAGE_MODULATION_NV = 0x9332;

		/// <summary>
		/// [GL] Value of GL_COVERAGE_MODULATION_TABLE_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public const int COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;

		/// <summary>
		/// [GL] Binding for glCoverageModulationTableNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public static void CoverageModulationTableNV(Int32 n, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglCoverageModulationTableNV != null, "pglCoverageModulationTableNV not implemented");
					Delegates.pglCoverageModulationTableNV(n, p_v);
					LogCommand("glCoverageModulationTableNV", null, n, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetCoverageModulationTableNV.
		/// </summary>
		/// <param name="bufsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public static void GetCoverageModulationTableNV(Int32 bufsize, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetCoverageModulationTableNV != null, "pglGetCoverageModulationTableNV not implemented");
					Delegates.pglGetCoverageModulationTableNV(bufsize, p_v);
					LogCommand("glGetCoverageModulationTableNV", null, bufsize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glCoverageModulationNV.
		/// </summary>
		/// <param name="components">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
		public static void CoverageNV(Int32 components)
		{
			Debug.Assert(Delegates.pglCoverageModulationNV != null, "pglCoverageModulationNV not implemented");
			Delegates.pglCoverageModulationNV(components);
			LogCommand("glCoverageModulationNV", null, components			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCoverageModulationTableNV", ExactSpelling = true)]
			internal extern static unsafe void glCoverageModulationTableNV(Int32 n, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetCoverageModulationTableNV", ExactSpelling = true)]
			internal extern static unsafe void glGetCoverageModulationTableNV(Int32 bufsize, float* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCoverageModulationNV", ExactSpelling = true)]
			internal extern static void glCoverageModulationNV(Int32 components);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glCoverageModulationTableNV(Int32 n, float* v);

			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glCoverageModulationTableNV pglCoverageModulationTableNV;

			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetCoverageModulationTableNV(Int32 bufsize, float* v);

			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetCoverageModulationTableNV pglGetCoverageModulationTableNV;

			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glCoverageModulationNV(Int32 components);

			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glCoverageModulationNV pglCoverageModulationNV;

		}
	}

}
