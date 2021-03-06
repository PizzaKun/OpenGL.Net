
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
		/// [GL] Value of GL_VERTEX_PROGRAM_ARB symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_PROGRAM_NV")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int VERTEX_PROGRAM_ARB = 0x8620;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_LENGTH_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_LENGTH_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_LENGTH_ARB = 0x8627;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_STRING_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_STRING_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_STRING_ARB = 0x8628;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_MATRICES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_MATRICES_ARB = 0x862F;

		/// <summary>
		/// [GL] Value of GL_CURRENT_MATRIX_STACK_DEPTH_ARB symbol.
		/// </summary>
		[AliasOf("GL_CURRENT_MATRIX_STACK_DEPTH_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;

		/// <summary>
		/// [GL] Value of GL_CURRENT_MATRIX_ARB symbol.
		/// </summary>
		[AliasOf("GL_CURRENT_MATRIX_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int CURRENT_MATRIX_ARB = 0x8641;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_ERROR_POSITION_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_ERROR_POSITION_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public const int PROGRAM_ERROR_POSITION_ARB = 0x864B;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_BINDING_ARB = 0x8677;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_ERROR_STRING_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_ERROR_STRING_NV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_fragment_program")]
		public const int PROGRAM_ERROR_STRING_ARB = 0x8874;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_FORMAT_ASCII_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_FORMAT_ASCII_ARB = 0x8875;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_FORMAT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_FORMAT_ARB = 0x8876;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_INSTRUCTIONS_ARB = 0x88A0;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_TEMPORARIES_ARB = 0x88A4;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_NATIVE_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_PARAMETERS_ARB = 0x88A8;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_NATIVE_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ATTRIBS_ARB = 0x88AC;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_NATIVE_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_ENV_PARAMETERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;

		/// <summary>
		/// [GL] Value of GL_TRANSPOSE_CURRENT_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;

		/// <summary>
		/// [GL] Value of GL_MATRIX0_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX0_ARB = 0x88C0;

		/// <summary>
		/// [GL] Value of GL_MATRIX1_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX1_ARB = 0x88C1;

		/// <summary>
		/// [GL] Value of GL_MATRIX2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX2_ARB = 0x88C2;

		/// <summary>
		/// [GL] Value of GL_MATRIX3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX3_ARB = 0x88C3;

		/// <summary>
		/// [GL] Value of GL_MATRIX4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX4_ARB = 0x88C4;

		/// <summary>
		/// [GL] Value of GL_MATRIX5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX5_ARB = 0x88C5;

		/// <summary>
		/// [GL] Value of GL_MATRIX6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX6_ARB = 0x88C6;

		/// <summary>
		/// [GL] Value of GL_MATRIX7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX7_ARB = 0x88C7;

		/// <summary>
		/// [GL] Value of GL_MATRIX8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX8_ARB = 0x88C8;

		/// <summary>
		/// [GL] Value of GL_MATRIX9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX9_ARB = 0x88C9;

		/// <summary>
		/// [GL] Value of GL_MATRIX10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX10_ARB = 0x88CA;

		/// <summary>
		/// [GL] Value of GL_MATRIX11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX11_ARB = 0x88CB;

		/// <summary>
		/// [GL] Value of GL_MATRIX12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX12_ARB = 0x88CC;

		/// <summary>
		/// [GL] Value of GL_MATRIX13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX13_ARB = 0x88CD;

		/// <summary>
		/// [GL] Value of GL_MATRIX14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX14_ARB = 0x88CE;

		/// <summary>
		/// [GL] Value of GL_MATRIX15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX15_ARB = 0x88CF;

		/// <summary>
		/// [GL] Value of GL_MATRIX16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX16_ARB = 0x88D0;

		/// <summary>
		/// [GL] Value of GL_MATRIX17_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX17_ARB = 0x88D1;

		/// <summary>
		/// [GL] Value of GL_MATRIX18_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX18_ARB = 0x88D2;

		/// <summary>
		/// [GL] Value of GL_MATRIX19_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX19_ARB = 0x88D3;

		/// <summary>
		/// [GL] Value of GL_MATRIX20_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX20_ARB = 0x88D4;

		/// <summary>
		/// [GL] Value of GL_MATRIX21_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX21_ARB = 0x88D5;

		/// <summary>
		/// [GL] Value of GL_MATRIX22_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX22_ARB = 0x88D6;

		/// <summary>
		/// [GL] Value of GL_MATRIX23_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX23_ARB = 0x88D7;

		/// <summary>
		/// [GL] Value of GL_MATRIX24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX24_ARB = 0x88D8;

		/// <summary>
		/// [GL] Value of GL_MATRIX25_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX25_ARB = 0x88D9;

		/// <summary>
		/// [GL] Value of GL_MATRIX26_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX26_ARB = 0x88DA;

		/// <summary>
		/// [GL] Value of GL_MATRIX27_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX27_ARB = 0x88DB;

		/// <summary>
		/// [GL] Value of GL_MATRIX28_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX28_ARB = 0x88DC;

		/// <summary>
		/// [GL] Value of GL_MATRIX29_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX29_ARB = 0x88DD;

		/// <summary>
		/// [GL] Value of GL_MATRIX30_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX30_ARB = 0x88DE;

		/// <summary>
		/// [GL] Value of GL_MATRIX31_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public const int MATRIX31_ARB = 0x88DF;

		/// <summary>
		/// [GL] Binding for glProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramStringARB(Int32 target, Int32 format, Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglProgramStringARB != null, "pglProgramStringARB not implemented");
			Delegates.pglProgramStringARB(target, format, len, @string);
			LogCommand("glProgramStringARB", null, target, format, len, @string			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramStringARB(Int32 target, Int32 format, Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				ProgramStringARB(target, format, len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glBindProgramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glBindProgramNV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void BindProgramARB(Int32 target, UInt32 program)
		{
			Debug.Assert(Delegates.pglBindProgramARB != null, "pglBindProgramARB not implemented");
			Delegates.pglBindProgramARB(target, program);
			LogCommand("glBindProgramARB", null, target, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDeleteProgramsARB.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[AliasOf("glDeleteProgramsNV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void DeleteProgramsARB(UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					Debug.Assert(Delegates.pglDeleteProgramsARB != null, "pglDeleteProgramsARB not implemented");
					Delegates.pglDeleteProgramsARB((Int32)programs.Length, p_programs);
					LogCommand("glDeleteProgramsARB", null, programs.Length, programs					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenProgramsARB.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[AliasOf("glGenProgramsNV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static void GenProgramsARB(UInt32[] programs)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				{
					Debug.Assert(Delegates.pglGenProgramsARB != null, "pglGenProgramsARB not implemented");
					Delegates.pglGenProgramsARB((Int32)programs.Length, p_programs);
					LogCommand("glGenProgramsARB", null, programs.Length, programs					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenProgramsARB.
		/// </summary>
		[AliasOf("glGenProgramsNV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static UInt32 GenProgramsARB()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramsARB(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] Binding for glProgramEnvParameter4dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(Int32 target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameter4dARB != null, "pglProgramEnvParameter4dARB not implemented");
			Delegates.pglProgramEnvParameter4dARB(target, index, x, y, z, w);
			LogCommand("glProgramEnvParameter4dARB", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramEnvParameter4dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(Int32 target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameter4dvARB != null, "pglProgramEnvParameter4dvARB not implemented");
					Delegates.pglProgramEnvParameter4dvARB(target, index, p_params);
					LogCommand("glProgramEnvParameter4dvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramEnvParameter4fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(Int32 target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameter4fARB != null, "pglProgramEnvParameter4fARB not implemented");
			Delegates.pglProgramEnvParameter4fARB(target, index, x, y, z, w);
			LogCommand("glProgramEnvParameter4fARB", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramEnvParameter4fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramEnvParameter4ARB(Int32 target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameter4fvARB != null, "pglProgramEnvParameter4fvARB not implemented");
					Delegates.pglProgramEnvParameter4fvARB(target, index, p_params);
					LogCommand("glProgramEnvParameter4fvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramLocalParameter4dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(Int32 target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameter4dARB != null, "pglProgramLocalParameter4dARB not implemented");
			Delegates.pglProgramLocalParameter4dARB(target, index, x, y, z, w);
			LogCommand("glProgramLocalParameter4dARB", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramLocalParameter4dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(Int32 target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameter4dvARB != null, "pglProgramLocalParameter4dvARB not implemented");
					Delegates.pglProgramLocalParameter4dvARB(target, index, p_params);
					LogCommand("glProgramLocalParameter4dvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramLocalParameter4fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(Int32 target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameter4fARB != null, "pglProgramLocalParameter4fARB not implemented");
			Delegates.pglProgramLocalParameter4fARB(target, index, x, y, z, w);
			LogCommand("glProgramLocalParameter4fARB", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramLocalParameter4fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void ProgramLocalParameter4ARB(Int32 target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameter4fvARB != null, "pglProgramLocalParameter4fvARB not implemented");
					Delegates.pglProgramLocalParameter4fvARB(target, index, p_params);
					LogCommand("glProgramLocalParameter4fvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramEnvParameterdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramEnvParameterARB(Int32 target, UInt32 index, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterdvARB != null, "pglGetProgramEnvParameterdvARB not implemented");
					Delegates.pglGetProgramEnvParameterdvARB(target, index, p_params);
					LogCommand("glGetProgramEnvParameterdvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramEnvParameterfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramEnvParameterARB(Int32 target, UInt32 index, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterfvARB != null, "pglGetProgramEnvParameterfvARB not implemented");
					Delegates.pglGetProgramEnvParameterfvARB(target, index, p_params);
					LogCommand("glGetProgramEnvParameterfvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramLocalParameterdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramLocalParameterARB(Int32 target, UInt32 index, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterdvARB != null, "pglGetProgramLocalParameterdvARB not implemented");
					Delegates.pglGetProgramLocalParameterdvARB(target, index, p_params);
					LogCommand("glGetProgramLocalParameterdvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramLocalParameterfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramLocalParameterARB(Int32 target, UInt32 index, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterfvARB != null, "pglGetProgramLocalParameterfvARB not implemented");
					Delegates.pglGetProgramLocalParameterfvARB(target, index, p_params);
					LogCommand("glGetProgramLocalParameterfvARB", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramARB(Int32 target, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetProgramivARB != null, "pglGetProgramivARB not implemented");
					Delegates.pglGetProgramivARB(target, pname, p_params);
					LogCommand("glGetProgramivARB", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramStringARB(Int32 target, Int32 pname, IntPtr @string)
		{
			Debug.Assert(Delegates.pglGetProgramStringARB != null, "pglGetProgramStringARB not implemented");
			Delegates.pglGetProgramStringARB(target, pname, @string);
			LogCommand("glGetProgramStringARB", null, target, pname, @string			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramStringARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		public static void GetProgramStringARB(Int32 target, Int32 pname, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				GetProgramStringARB(target, pname, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glIsProgramARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glIsProgramNV")]
		[RequiredByFeature("GL_ARB_fragment_program")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_NV_vertex_program")]
		public static bool IsProgramARB(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramARB != null, "pglIsProgramARB not implemented");
			retValue = Delegates.pglIsProgramARB(program);
			LogCommand("glIsProgramARB", retValue, program			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramStringARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramStringARB(Int32 target, Int32 format, Int32 len, IntPtr @string);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBindProgramARB", ExactSpelling = true)]
			internal extern static void glBindProgramARB(Int32 target, UInt32 program);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteProgramsARB", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramsARB(Int32 n, UInt32* programs);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGenProgramsARB", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramsARB(Int32 n, UInt32* programs);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramEnvParameter4dARB", ExactSpelling = true)]
			internal extern static void glProgramEnvParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramEnvParameter4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameter4dvARB(Int32 target, UInt32 index, double* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramEnvParameter4fARB", ExactSpelling = true)]
			internal extern static void glProgramEnvParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramEnvParameter4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramEnvParameter4fvARB(Int32 target, UInt32 index, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramLocalParameter4dARB", ExactSpelling = true)]
			internal extern static void glProgramLocalParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramLocalParameter4dvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameter4dvARB(Int32 target, UInt32 index, double* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramLocalParameter4fARB", ExactSpelling = true)]
			internal extern static void glProgramLocalParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glProgramLocalParameter4fvARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramLocalParameter4fvARB(Int32 target, UInt32 index, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterdvARB(Int32 target, UInt32 index, double* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramEnvParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramEnvParameterfvARB(Int32 target, UInt32 index, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterdvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterdvARB(Int32 target, UInt32 index, double* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramLocalParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramLocalParameterfvARB(Int32 target, UInt32 index, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramivARB(Int32 target, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetProgramStringARB", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramStringARB(Int32 target, Int32 pname, IntPtr @string);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsProgramARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsProgramARB(UInt32 program);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramStringARB(Int32 target, Int32 format, Int32 len, IntPtr @string);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramStringARB pglProgramStringARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBindProgramARB(Int32 target, UInt32 program);

			[AliasOf("glBindProgramARB")]
			[AliasOf("glBindProgramNV")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glBindProgramARB pglBindProgramARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDeleteProgramsARB(Int32 n, UInt32* programs);

			[AliasOf("glDeleteProgramsARB")]
			[AliasOf("glDeleteProgramsNV")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glDeleteProgramsARB pglDeleteProgramsARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGenProgramsARB(Int32 n, UInt32* programs);

			[AliasOf("glGenProgramsARB")]
			[AliasOf("glGenProgramsNV")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glGenProgramsARB pglGenProgramsARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProgramEnvParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramEnvParameter4dARB pglProgramEnvParameter4dARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramEnvParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramEnvParameter4dvARB pglProgramEnvParameter4dvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProgramEnvParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramEnvParameter4fARB pglProgramEnvParameter4fARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramEnvParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramEnvParameter4fvARB pglProgramEnvParameter4fvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProgramLocalParameter4dARB(Int32 target, UInt32 index, double x, double y, double z, double w);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramLocalParameter4dARB pglProgramLocalParameter4dARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramLocalParameter4dvARB(Int32 target, UInt32 index, double* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramLocalParameter4dvARB pglProgramLocalParameter4dvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glProgramLocalParameter4fARB(Int32 target, UInt32 index, float x, float y, float z, float w);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramLocalParameter4fARB pglProgramLocalParameter4fARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glProgramLocalParameter4fvARB(Int32 target, UInt32 index, float* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glProgramLocalParameter4fvARB pglProgramLocalParameter4fvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramEnvParameterdvARB(Int32 target, UInt32 index, double* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramEnvParameterdvARB pglGetProgramEnvParameterdvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramEnvParameterfvARB(Int32 target, UInt32 index, float* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramEnvParameterfvARB pglGetProgramEnvParameterfvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramLocalParameterdvARB(Int32 target, UInt32 index, double* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramLocalParameterdvARB pglGetProgramLocalParameterdvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramLocalParameterfvARB(Int32 target, UInt32 index, float* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramLocalParameterfvARB pglGetProgramLocalParameterfvARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramivARB(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramivARB pglGetProgramivARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetProgramStringARB(Int32 target, Int32 pname, IntPtr @string);

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[ThreadStatic]
			internal static glGetProgramStringARB pglGetProgramStringARB;

			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsProgramARB(UInt32 program);

			[AliasOf("glIsProgramARB")]
			[AliasOf("glIsProgramNV")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_NV_vertex_program")]
			[ThreadStatic]
			internal static glIsProgramARB pglIsProgramARB;

		}
	}

}
