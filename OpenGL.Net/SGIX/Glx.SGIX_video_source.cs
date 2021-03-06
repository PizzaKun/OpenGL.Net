
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Binding for glXCreateGLXVideoSourceSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="server">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="path">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nodeClass">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="drainNode">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_source")]
		public static IntPtr CreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXVideoSourceSGIX != null, "pglXCreateGLXVideoSourceSGIX not implemented");
			retValue = Delegates.pglXCreateGLXVideoSourceSGIX(display, screen, server, path, nodeClass, drainNode);
			LogCommand("glXCreateGLXVideoSourceSGIX", retValue, display, screen, server, path, nodeClass, drainNode			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXDestroyGLXVideoSourceSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="glxvideosource">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_source")]
		public static void DestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource)
		{
			Debug.Assert(Delegates.pglXDestroyGLXVideoSourceSGIX != null, "pglXDestroyGLXVideoSourceSGIX not implemented");
			Delegates.pglXDestroyGLXVideoSourceSGIX(dpy, glxvideosource);
			LogCommand("glXDestroyGLXVideoSourceSGIX", null, dpy, glxvideosource			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateGLXVideoSourceSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXDestroyGLXVideoSourceSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_video_source")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode);

			[RequiredByFeature("GLX_SGIX_video_source")]
			internal static glXCreateGLXVideoSourceSGIX pglXCreateGLXVideoSourceSGIX;

			[RequiredByFeature("GLX_SGIX_video_source")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXDestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource);

			[RequiredByFeature("GLX_SGIX_video_source")]
			internal static glXDestroyGLXVideoSourceSGIX pglXDestroyGLXVideoSourceSGIX;

		}
	}

}
