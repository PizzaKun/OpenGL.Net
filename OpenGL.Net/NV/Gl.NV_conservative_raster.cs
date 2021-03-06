
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
		/// [GL] Value of GL_CONSERVATIVE_RASTERIZATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTERIZATION_NV = 0x9346;

		/// <summary>
		/// [GL] Value of GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
		public const int SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;

		/// <summary>
		/// [GL] Value of GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
		public const int SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;

		/// <summary>
		/// [GL] Value of GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
		public const int MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;

		/// <summary>
		/// [GL] Binding for glSubpixelPrecisionBiasNV.
		/// </summary>
		/// <param name="xbits">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="ybits">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
		public static void SubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits)
		{
			Debug.Assert(Delegates.pglSubpixelPrecisionBiasNV != null, "pglSubpixelPrecisionBiasNV not implemented");
			Delegates.pglSubpixelPrecisionBiasNV(xbits, ybits);
			LogCommand("glSubpixelPrecisionBiasNV", null, xbits, ybits			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glSubpixelPrecisionBiasNV", ExactSpelling = true)]
			internal extern static void glSubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits);

			[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glSubpixelPrecisionBiasNV pglSubpixelPrecisionBiasNV;

		}
	}

}
