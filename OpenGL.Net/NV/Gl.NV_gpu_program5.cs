
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
		/// [GL] Value of GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_NUM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;

		/// <summary>
		/// [GL] Binding for glProgramSubroutineParametersuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public static void ProgramSubroutineParametersNV(Int32 target, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramSubroutineParametersuivNV != null, "pglProgramSubroutineParametersuivNV not implemented");
					Delegates.pglProgramSubroutineParametersuivNV(target, (Int32)@params.Length, p_params);
					LogCommand("glProgramSubroutineParametersuivNV", null, target, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramSubroutineParameteruivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public static void GetProgramSubroutineParameterNV(Int32 target, UInt32 index, [Out] UInt32[] param)
		{
			unsafe {
				fixed (UInt32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetProgramSubroutineParameteruivNV != null, "pglGetProgramSubroutineParameteruivNV not implemented");
					Delegates.pglGetProgramSubroutineParameteruivNV(target, index, p_param);
					LogCommand("glGetProgramSubroutineParameteruivNV", null, target, index, param					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramSubroutineParametersuivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramSubroutineParametersuivNV(Int32 target, Int32 count, UInt32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramSubroutineParameteruivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramSubroutineParameteruivNV(Int32 target, UInt32 index, UInt32* param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_gpu_program5")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramSubroutineParametersuivNV(Int32 target, Int32 count, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program5")]
			[ThreadStatic]
			internal static glProgramSubroutineParametersuivNV pglProgramSubroutineParametersuivNV;

			[RequiredByFeature("GL_NV_gpu_program5")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramSubroutineParameteruivNV(Int32 target, UInt32 index, UInt32* param);

			[RequiredByFeature("GL_NV_gpu_program5")]
			[ThreadStatic]
			internal static glGetProgramSubroutineParameteruivNV pglGetProgramSubroutineParameteruivNV;

		}
	}

}
