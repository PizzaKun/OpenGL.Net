
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
		/// [GL] Value of GL_SYNC_CL_EVENT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_cl_event", Api = "gl|glcore")]
		public const int SYNC_CL_EVENT_ARB = 0x8240;

		/// <summary>
		/// [GL] Value of GL_SYNC_CL_EVENT_COMPLETE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_cl_event", Api = "gl|glcore")]
		public const int SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;

		/// <summary>
		/// [GL] Binding for glCreateSyncFromCLeventARB.
		/// </summary>
		/// <param name="context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_cl_event", Api = "gl|glcore")]
		public static Int32 CreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCreateSyncFromCLeventARB != null, "pglCreateSyncFromCLeventARB not implemented");
			retValue = Delegates.pglCreateSyncFromCLeventARB(context, @event, flags);
			LogCommand("glCreateSyncFromCLeventARB", retValue, context, @event, flags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCreateSyncFromCLeventARB", ExactSpelling = true)]
			internal extern static unsafe Int32 glCreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_cl_event", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate Int32 glCreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);

			[RequiredByFeature("GL_ARB_cl_event", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateSyncFromCLeventARB pglCreateSyncFromCLeventARB;

		}
	}

}
