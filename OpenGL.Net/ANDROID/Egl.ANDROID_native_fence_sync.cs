
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_ANDROID = 0x3144;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_FD_ANDROID = 0x3145;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_SIGNALED_ANDROID = 0x3146;

		/// <summary>
		/// [EGL] Value of EGL_NO_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int NO_NATIVE_FENCE_FD_ANDROID = -1;

		/// <summary>
		/// [EGL] Binding for eglDupNativeFenceFDANDROID.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public static int DupNativeFenceANDROID(IntPtr dpy, IntPtr sync)
		{
			int retValue;

			Debug.Assert(Delegates.peglDupNativeFenceFDANDROID != null, "peglDupNativeFenceFDANDROID not implemented");
			retValue = Delegates.peglDupNativeFenceFDANDROID(dpy, sync);
			LogCommand("eglDupNativeFenceFDANDROID", retValue, dpy, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglDupNativeFenceFDANDROID", ExactSpelling = true)]
			internal extern static unsafe int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
			internal static eglDupNativeFenceFDANDROID peglDupNativeFenceFDANDROID;

		}
	}

}
