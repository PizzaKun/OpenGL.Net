
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
		/// [GL] Binding for glGenQueriesEXT.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GenQueriesEXT(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesEXT != null, "pglGenQueriesEXT not implemented");
					Delegates.pglGenQueriesEXT((Int32)ids.Length, p_ids);
					LogCommand("glGenQueriesEXT", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenQueriesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static UInt32 GenQueriesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenQueriesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] Binding for glDeleteQueriesEXT.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void DeleteQueriesEXT(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesEXT != null, "pglDeleteQueriesEXT not implemented");
					Delegates.pglDeleteQueriesEXT((Int32)ids.Length, p_ids);
					LogCommand("glDeleteQueriesEXT", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIsQueryEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static bool IsQueryEXT(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQueryEXT != null, "pglIsQueryEXT not implemented");
			retValue = Delegates.pglIsQueryEXT(id);
			LogCommand("glIsQueryEXT", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glBeginQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void BeginQueryEXT(QueryTarget target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryEXT != null, "pglBeginQueryEXT not implemented");
			Delegates.pglBeginQueryEXT((Int32)target, id);
			LogCommand("glBeginQueryEXT", null, target, id			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEndQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void EndQueryEXT(QueryTarget target)
		{
			Debug.Assert(Delegates.pglEndQueryEXT != null, "pglEndQueryEXT not implemented");
			Delegates.pglEndQueryEXT((Int32)target);
			LogCommand("glEndQueryEXT", null, target			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetQueryivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryEXT(QueryTarget target, QueryParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetQueryivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetQueryivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryEXT(QueryTarget target, QueryParameterName pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetQueryivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryObjectuivEXT(UInt32 id, QueryObjectParameterName pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, (Int32)pname, p_params);
					LogCommand("glGetQueryObjectuivEXT", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryObjectuivEXT(UInt32 id, QueryObjectParameterName pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, (Int32)pname, p_params);
					LogCommand("glGetQueryObjectuivEXT", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGenQueriesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenQueriesEXT(Int32 n, UInt32* ids);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteQueriesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteQueriesEXT(Int32 n, UInt32* ids);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsQueryEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsQueryEXT(UInt32 id);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBeginQueryEXT", ExactSpelling = true)]
			internal extern static void glBeginQueryEXT(Int32 target, UInt32 id);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEndQueryEXT", ExactSpelling = true)]
			internal extern static void glEndQueryEXT(Int32 target);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetQueryivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryivEXT(Int32 target, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetQueryObjectuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectuivEXT(UInt32 id, Int32 pname, UInt32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGenQueriesEXT(Int32 n, UInt32* ids);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGenQueriesEXT pglGenQueriesEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDeleteQueriesEXT(Int32 n, UInt32* ids);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glDeleteQueriesEXT pglDeleteQueriesEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsQueryEXT(UInt32 id);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glIsQueryEXT pglIsQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBeginQueryEXT(Int32 target, UInt32 id);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glBeginQueryEXT pglBeginQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glEndQueryEXT(Int32 target);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glEndQueryEXT pglEndQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetQueryivEXT(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGetQueryivEXT pglGetQueryivEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetQueryObjectuivEXT(UInt32 id, Int32 pname, UInt32* @params);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGetQueryObjectuivEXT pglGetQueryObjectuivEXT;

		}
	}

}
