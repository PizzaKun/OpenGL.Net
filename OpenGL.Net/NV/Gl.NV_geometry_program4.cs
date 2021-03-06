
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
		/// [GL] Value of GL_GEOMETRY_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_PROGRAM_NV = 0x8C26;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_OUTPUT_VERTICES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;

		/// <summary>
		/// [GL] Binding for glProgramVertexLimitNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="limit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void ProgramVertexLimitNV(Int32 target, Int32 limit)
		{
			Debug.Assert(Delegates.pglProgramVertexLimitNV != null, "pglProgramVertexLimitNV not implemented");
			Delegates.pglProgramVertexLimitNV(target, limit);
			LogCommand("glProgramVertexLimitNV", null, target, limit			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramVertexLimitNV", ExactSpelling = true)]
			internal extern static void glProgramVertexLimitNV(Int32 target, Int32 limit);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_geometry_program4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProgramVertexLimitNV(Int32 target, Int32 limit);

			[RequiredByFeature("GL_NV_geometry_program4")]
			[ThreadStatic]
			internal static glProgramVertexLimitNV pglProgramVertexLimitNV;

		}
	}

}
