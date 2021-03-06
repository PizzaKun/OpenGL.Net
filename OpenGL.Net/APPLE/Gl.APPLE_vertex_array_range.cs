
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
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_APPLE = 0x851D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ARRAY_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;

		/// <summary>
		/// [GL] Value of GL_STORAGE_CLIENT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CLIENT_APPLE = 0x85B4;

		/// <summary>
		/// [GL] Value of GL_STORAGE_CACHED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_CACHED_APPLE = 0x85BE;

		/// <summary>
		/// [GL] Value of GL_STORAGE_SHARED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public const int STORAGE_SHARED_APPLE = 0x85BF;

		/// <summary>
		/// [GL] Binding for glVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexArrayRangeAPPLE != null, "pglVertexArrayRangeAPPLE not implemented");
			Delegates.pglVertexArrayRangeAPPLE(length, pointer);
			LogCommand("glVertexArrayRangeAPPLE", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFlushVertexArrayRangeAPPLE.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void FlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFlushVertexArrayRangeAPPLE != null, "pglFlushVertexArrayRangeAPPLE not implemented");
			Delegates.pglFlushVertexArrayRangeAPPLE(length, pointer);
			LogCommand("glFlushVertexArrayRangeAPPLE", null, length, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexArrayParameteriAPPLE.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		public static void VertexArrayParameterAPPLE(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglVertexArrayParameteriAPPLE != null, "pglVertexArrayParameteriAPPLE not implemented");
			Delegates.pglVertexArrayParameteriAPPLE(pname, param);
			LogCommand("glVertexArrayParameteriAPPLE", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexArrayRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFlushVertexArrayRangeAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexArrayParameteriAPPLE", ExactSpelling = true)]
			internal extern static void glVertexArrayParameteriAPPLE(Int32 pname, Int32 param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayRangeAPPLE pglVertexArrayRangeAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glFlushVertexArrayRangeAPPLE pglFlushVertexArrayRangeAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexArrayParameteriAPPLE(Int32 pname, Int32 param);

			[RequiredByFeature("GL_APPLE_vertex_array_range")]
			[ThreadStatic]
			internal static glVertexArrayParameteriAPPLE pglVertexArrayParameteriAPPLE;

		}
	}

}
