
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
		/// [GL] Binding for glVertexAttribArrayObjectATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexAttribType"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void VertexAttribArrayObjectATI(UInt32 index, Int32 size, VertexAttribType type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglVertexAttribArrayObjectATI != null, "pglVertexAttribArrayObjectATI not implemented");
			Delegates.pglVertexAttribArrayObjectATI(index, size, (Int32)type, normalized, stride, buffer, offset);
			LogCommand("glVertexAttribArrayObjectATI", null, index, size, type, normalized, stride, buffer, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVertexAttribArrayObjectfvATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void GetVertexAttribArrayObjectATI(UInt32 index, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribArrayObjectfvATI != null, "pglGetVertexAttribArrayObjectfvATI not implemented");
					Delegates.pglGetVertexAttribArrayObjectfvATI(index, pname, p_params);
					LogCommand("glGetVertexAttribArrayObjectfvATI", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVertexAttribArrayObjectivATI.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
		public static void GetVertexAttribArrayObjectATI(UInt32 index, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribArrayObjectivATI != null, "pglGetVertexAttribArrayObjectivATI not implemented");
					Delegates.pglGetVertexAttribArrayObjectivATI(index, pname, p_params);
					LogCommand("glGetVertexAttribArrayObjectivATI", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertexAttribArrayObjectATI", ExactSpelling = true)]
			internal extern static void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribArrayObjectfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribArrayObjectfvATI(UInt32 index, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVertexAttribArrayObjectivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribArrayObjectivATI(UInt32 index, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glVertexAttribArrayObjectATI pglVertexAttribArrayObjectATI;

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribArrayObjectfvATI(UInt32 index, Int32 pname, float* @params);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectfvATI pglGetVertexAttribArrayObjectfvATI;

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetVertexAttribArrayObjectivATI(UInt32 index, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ATI_vertex_attrib_array_object")]
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectivATI pglGetVertexAttribArrayObjectivATI;

		}
	}

}
