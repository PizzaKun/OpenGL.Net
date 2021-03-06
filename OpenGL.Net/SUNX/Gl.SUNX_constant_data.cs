
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
		/// [GL] Value of GL_UNPACK_CONSTANT_DATA_SUNX symbol.
		/// </summary>
		[RequiredByFeature("GL_SUNX_constant_data")]
		public const int UNPACK_CONSTANT_DATA_SUNX = 0x81D5;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CONSTANT_DATA_SUNX symbol.
		/// </summary>
		[RequiredByFeature("GL_SUNX_constant_data")]
		public const int TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;

		/// <summary>
		/// [GL] Binding for glFinishTextureSUNX.
		/// </summary>
		[RequiredByFeature("GL_SUNX_constant_data")]
		public static void FinishTextureSUNX()
		{
			Debug.Assert(Delegates.pglFinishTextureSUNX != null, "pglFinishTextureSUNX not implemented");
			Delegates.pglFinishTextureSUNX();
			LogCommand("glFinishTextureSUNX", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFinishTextureSUNX", ExactSpelling = true)]
			internal extern static void glFinishTextureSUNX();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SUNX_constant_data")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFinishTextureSUNX();

			[RequiredByFeature("GL_SUNX_constant_data")]
			[ThreadStatic]
			internal static glFinishTextureSUNX pglFinishTextureSUNX;

		}
	}

}
