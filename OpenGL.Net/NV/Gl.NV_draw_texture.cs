
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
		/// [GL] Binding for glDrawTextureNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="s0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="s1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t1">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_texture")]
		public static void DrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1)
		{
			Debug.Assert(Delegates.pglDrawTextureNV != null, "pglDrawTextureNV not implemented");
			Delegates.pglDrawTextureNV(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
			LogCommand("glDrawTextureNV", null, texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDrawTextureNV", ExactSpelling = true)]
			internal extern static void glDrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_draw_texture")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glDrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);

			[RequiredByFeature("GL_NV_draw_texture")]
			[ThreadStatic]
			internal static glDrawTextureNV pglDrawTextureNV;

		}
	}

}
