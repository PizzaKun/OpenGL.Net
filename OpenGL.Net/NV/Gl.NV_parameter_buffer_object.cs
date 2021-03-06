
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
		/// [GL] Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;

		/// <summary>
		/// [GL] Value of GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;

		/// <summary>
		/// [GL] Binding for glProgramBufferParametersfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersfvNV != null, "pglProgramBufferParametersfvNV not implemented");
					Delegates.pglProgramBufferParametersfvNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogCommand("glProgramBufferParametersfvNV", null, target, bindingIndex, wordIndex, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramBufferParametersIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersINV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersIivNV != null, "pglProgramBufferParametersIivNV not implemented");
					Delegates.pglProgramBufferParametersIivNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogCommand("glProgramBufferParametersIivNV", null, target, bindingIndex, wordIndex, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramBufferParametersIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersINV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersIuivNV != null, "pglProgramBufferParametersIuivNV not implemented");
					Delegates.pglProgramBufferParametersIuivNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogCommand("glProgramBufferParametersIuivNV", null, target, bindingIndex, wordIndex, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramBufferParametersfvNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersfvNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramBufferParametersIivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersIivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramBufferParametersIuivNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramBufferParametersIuivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, UInt32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramBufferParametersfvNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, float* @params);

			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			[ThreadStatic]
			internal static glProgramBufferParametersfvNV pglProgramBufferParametersfvNV;

			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramBufferParametersIivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, Int32* @params);

			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			[ThreadStatic]
			internal static glProgramBufferParametersIivNV pglProgramBufferParametersIivNV;

			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramBufferParametersIuivNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, UInt32* @params);

			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			[ThreadStatic]
			internal static glProgramBufferParametersIuivNV pglProgramBufferParametersIuivNV;

		}
	}

}
