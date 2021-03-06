
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
		/// [GL] Binding for glGetProgramResourceLocationIndexEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="programInterface">
		/// A <see cref="T:ProgramInterface"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public static Int32 GetProgramResourceLocationIndexEXT(UInt32 program, ProgramInterface programInterface, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetProgramResourceLocationIndexEXT != null, "pglGetProgramResourceLocationIndexEXT not implemented");
			retValue = Delegates.pglGetProgramResourceLocationIndexEXT(program, (Int32)programInterface, name);
			LogCommand("glGetProgramResourceLocationIndexEXT", retValue, program, programInterface, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramResourceLocationIndexEXT", ExactSpelling = true)]
			internal extern static Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glGetProgramResourceLocationIndexEXT(UInt32 program, Int32 programInterface, String name);

			[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramResourceLocationIndexEXT pglGetProgramResourceLocationIndexEXT;

		}
	}

}
