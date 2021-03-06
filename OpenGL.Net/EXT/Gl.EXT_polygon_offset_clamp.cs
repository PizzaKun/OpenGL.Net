
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
		/// [GL] Value of GL_POLYGON_OFFSET_CLAMP_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
		public const int POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;

		/// <summary>
		/// [GL] Binding for glPolygonOffsetClampEXT.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="clamp">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
		public static void PolygonOffsetClampEXT(float factor, float units, float clamp)
		{
			Debug.Assert(Delegates.pglPolygonOffsetClampEXT != null, "pglPolygonOffsetClampEXT not implemented");
			Delegates.pglPolygonOffsetClampEXT(factor, units, clamp);
			LogCommand("glPolygonOffsetClampEXT", null, factor, units, clamp			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPolygonOffsetClampEXT", ExactSpelling = true)]
			internal extern static void glPolygonOffsetClampEXT(float factor, float units, float clamp);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glPolygonOffsetClampEXT(float factor, float units, float clamp);

			[RequiredByFeature("GL_EXT_polygon_offset_clamp", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glPolygonOffsetClampEXT pglPolygonOffsetClampEXT;

		}
	}

}
