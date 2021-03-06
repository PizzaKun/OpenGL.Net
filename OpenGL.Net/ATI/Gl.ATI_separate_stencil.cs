
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
		/// [GL] Binding for glStencilFuncSeparateATI.
		/// </summary>
		/// <param name="frontfunc">
		/// A <see cref="T:StencilFunction"/>.
		/// </param>
		/// <param name="backfunc">
		/// A <see cref="T:StencilFunction"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparateATI != null, "pglStencilFuncSeparateATI not implemented");
			Delegates.pglStencilFuncSeparateATI((Int32)frontfunc, (Int32)backfunc, @ref, mask);
			LogCommand("glStencilFuncSeparateATI", null, frontfunc, backfunc, @ref, mask			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glStencilFuncSeparateATI", ExactSpelling = true)]
			internal extern static void glStencilFuncSeparateATI(Int32 frontfunc, Int32 backfunc, Int32 @ref, UInt32 mask);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_separate_stencil")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glStencilFuncSeparateATI(Int32 frontfunc, Int32 backfunc, Int32 @ref, UInt32 mask);

			[RequiredByFeature("GL_ATI_separate_stencil")]
			[ThreadStatic]
			internal static glStencilFuncSeparateATI pglStencilFuncSeparateATI;

		}
	}

}
