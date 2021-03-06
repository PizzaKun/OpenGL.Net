
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_OPTIMAL_PBUFFER_WIDTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int OPTIMAL_PBUFFER_WIDTH_EXT = 0x2031;

		/// <summary>
		/// [WGL] Value of WGL_OPTIMAL_PBUFFER_HEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int OPTIMAL_PBUFFER_HEIGHT_EXT = 0x2032;

		/// <summary>
		/// [WGL] Binding for wglCreatePbufferEXT.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iWidth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iHeight">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglCreatePbufferEXT != null, "pwglCreatePbufferEXT not implemented");
					retValue = Delegates.pwglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, p_piAttribList);
					LogCommand("wglCreatePbufferEXT", retValue, hDC, iPixelFormat, iWidth, iHeight, piAttribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetPbufferDCEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static IntPtr GetPbufferDCEXT(IntPtr hPbuffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetPbufferDCEXT != null, "pwglGetPbufferDCEXT not implemented");
			retValue = Delegates.pwglGetPbufferDCEXT(hPbuffer);
			LogCommand("wglGetPbufferDCEXT", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglReleasePbufferDCEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC)
		{
			int retValue;

			Debug.Assert(Delegates.pwglReleasePbufferDCEXT != null, "pwglReleasePbufferDCEXT not implemented");
			retValue = Delegates.pwglReleasePbufferDCEXT(hPbuffer, hDC);
			LogCommand("wglReleasePbufferDCEXT", retValue, hPbuffer, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDestroyPbufferEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static bool DestroyPbufferEXT(IntPtr hPbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyPbufferEXT != null, "pwglDestroyPbufferEXT not implemented");
			retValue = Delegates.pwglDestroyPbufferEXT(hPbuffer);
			LogCommand("wglDestroyPbufferEXT", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglQueryPbufferEXT.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public static bool QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryPbufferEXT != null, "pwglQueryPbufferEXT not implemented");
					retValue = Delegates.pwglQueryPbufferEXT(hPbuffer, iAttribute, p_piValue);
					LogCommand("wglQueryPbufferEXT", retValue, hPbuffer, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreatePbufferEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetPbufferDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetPbufferDCEXT(IntPtr hPbuffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglReleasePbufferDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDestroyPbufferEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyPbufferEXT(IntPtr hPbuffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryPbufferEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[RequiredByFeature("WGL_EXT_pbuffer")]
			[ThreadStatic]
			internal static wglCreatePbufferEXT pwglCreatePbufferEXT;

			[RequiredByFeature("WGL_EXT_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglGetPbufferDCEXT(IntPtr hPbuffer);

			[RequiredByFeature("WGL_EXT_pbuffer")]
			[ThreadStatic]
			internal static wglGetPbufferDCEXT pwglGetPbufferDCEXT;

			[RequiredByFeature("WGL_EXT_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int wglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);

			[RequiredByFeature("WGL_EXT_pbuffer")]
			[ThreadStatic]
			internal static wglReleasePbufferDCEXT pwglReleasePbufferDCEXT;

			[RequiredByFeature("WGL_EXT_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDestroyPbufferEXT(IntPtr hPbuffer);

			[RequiredByFeature("WGL_EXT_pbuffer")]
			[ThreadStatic]
			internal static wglDestroyPbufferEXT pwglDestroyPbufferEXT;

			[RequiredByFeature("WGL_EXT_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_EXT_pbuffer")]
			[ThreadStatic]
			internal static wglQueryPbufferEXT pwglQueryPbufferEXT;

		}
	}

}
