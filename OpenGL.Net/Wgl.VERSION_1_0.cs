
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
		/// [WGL] Value of WGL_FONT_LINES symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int FONT_LINES = 0;

		/// <summary>
		/// [WGL] Value of WGL_FONT_POLYGONS symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int FONT_POLYGONS = 1;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_MAIN_PLANE symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_MAIN_PLANE = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY1 = 0x00000002;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY2 = 0x00000004;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY3 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY3 = 0x00000008;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY4 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY4 = 0x00000010;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY5 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY5 = 0x00000020;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY6 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY6 = 0x00000040;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY7 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY7 = 0x00000080;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY8 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY8 = 0x00000100;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY9 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY9 = 0x00000200;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY10 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY10 = 0x00000400;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY11 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY11 = 0x00000800;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY12 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY12 = 0x00001000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY13 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY13 = 0x00002000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY14 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY14 = 0x00004000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_OVERLAY15 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_OVERLAY15 = 0x00008000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY1 = 0x00010000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY2 = 0x00020000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY3 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY3 = 0x00040000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY4 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY4 = 0x00080000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY5 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY5 = 0x00100000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY6 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY6 = 0x00200000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY7 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY7 = 0x00400000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY8 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY8 = 0x00800000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY9 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY9 = 0x01000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY10 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY10 = 0x02000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY11 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY11 = 0x04000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY12 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY12 = 0x08000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY13 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY13 = 0x10000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY14 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY14 = 0x20000000;

		/// <summary>
		/// [WGL] Value of WGL_SWAP_UNDERLAY15 symbol.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLLayerPlaneMask")]
		public const uint SWAP_UNDERLAY15 = 0x40000000;

		/// <summary>
		/// [WGL] Binding for wglCopyContext.
		/// </summary>
		/// <param name="hglrcSrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hglrcDst">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglCopyContext != null, "pwglCopyContext not implemented");
			retValue = Delegates.pwglCopyContext(hglrcSrc, hglrcDst, mask);
			LogCommand("wglCopyContext", retValue, hglrcSrc, hglrcDst, mask			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglCreateContext.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static IntPtr CreateContext(IntPtr hDc)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateContext != null, "pwglCreateContext not implemented");
			retValue = Delegates.pwglCreateContext(hDc);
			LogCommand("wglCreateContext", retValue, hDc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglCreateLayerContext.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static IntPtr CreateLayerContext(IntPtr hDc, int level)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateLayerContext != null, "pwglCreateLayerContext not implemented");
			retValue = Delegates.pwglCreateLayerContext(hDc, level);
			LogCommand("wglCreateLayerContext", retValue, hDc, level			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDeleteContext.
		/// </summary>
		/// <param name="oldContext">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool DeleteContext(IntPtr oldContext)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDeleteContext != null, "pwglDeleteContext not implemented");
			retValue = Delegates.pwglDeleteContext(oldContext);
			LogCommand("wglDeleteContext", retValue, oldContext			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDescribeLayerPlane.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="layerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nBytes">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="plpd">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, IntPtr[] plpd)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_plpd = plpd)
				{
					Debug.Assert(Delegates.pwglDescribeLayerPlane != null, "pwglDescribeLayerPlane not implemented");
					retValue = Delegates.pwglDescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, p_plpd);
					LogCommand("wglDescribeLayerPlane", retValue, hDc, pixelFormat, layerPlane, nBytes, plpd					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetCurrentContext.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static IntPtr GetCurrentContext()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentContext != null, "pwglGetCurrentContext not implemented");
			retValue = Delegates.pwglGetCurrentContext();
			LogCommand("wglGetCurrentContext", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetCurrentDC.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static IntPtr GetCurrentDC()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentDC != null, "pwglGetCurrentDC not implemented");
			retValue = Delegates.pwglGetCurrentDC();
			LogCommand("wglGetCurrentDC", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetLayerPaletteEntries.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iStart">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="cEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pcr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr)
		{
			int retValue;

			Debug.Assert(Delegates.pwglGetLayerPaletteEntries != null, "pwglGetLayerPaletteEntries not implemented");
			retValue = Delegates.pwglGetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr);
			LogCommand("wglGetLayerPaletteEntries", retValue, hdc, iLayerPlane, iStart, cEntries, pcr			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetProcAddress.
		/// </summary>
		/// <param name="lpszProc">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static IntPtr GetProcAddress(String lpszProc)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetProcAddress != null, "pwglGetProcAddress not implemented");
			retValue = Delegates.pwglGetProcAddress(lpszProc);
			LogCommand("wglGetProcAddress", retValue, lpszProc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglMakeCurrent.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="newContext">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		private static bool MakeCurrentCore(IntPtr hDc, IntPtr newContext)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeCurrent != null, "pwglMakeCurrent not implemented");
			retValue = Delegates.pwglMakeCurrent(hDc, newContext);
			LogCommand("wglMakeCurrent", retValue, hDc, newContext			);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglRealizeLayerPalette.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bRealize">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool RealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglRealizeLayerPalette != null, "pwglRealizeLayerPalette not implemented");
			retValue = Delegates.pwglRealizeLayerPalette(hdc, iLayerPlane, bRealize);
			LogCommand("wglRealizeLayerPalette", retValue, hdc, iLayerPlane, bRealize			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglSetLayerPaletteEntries.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iStart">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="cEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pcr">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr)
		{
			int retValue;

			Debug.Assert(Delegates.pwglSetLayerPaletteEntries != null, "pwglSetLayerPaletteEntries not implemented");
			retValue = Delegates.pwglSetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr);
			LogCommand("wglSetLayerPaletteEntries", retValue, hdc, iLayerPlane, iStart, cEntries, pcr			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglShareLists.
		/// </summary>
		/// <param name="hrcSrvShare">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hrcSrvSource">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglShareLists != null, "pwglShareLists not implemented");
			retValue = Delegates.pwglShareLists(hrcSrvShare, hrcSrvSource);
			LogCommand("wglShareLists", retValue, hrcSrvShare, hrcSrvSource			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglSwapLayerBuffers.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fuFlags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSwapLayerBuffers != null, "pwglSwapLayerBuffers not implemented");
			retValue = Delegates.pwglSwapLayerBuffers(hdc, fuFlags);
			LogCommand("wglSwapLayerBuffers", retValue, hdc, fuFlags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontBitmaps.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFont(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontBitmaps != null, "pwglUseFontBitmaps not implemented");
			retValue = Delegates.pwglUseFontBitmaps(hDC, first, count, listBase);
			LogCommand("wglUseFontBitmaps", retValue, hDC, first, count, listBase			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontBitmapsA.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontBitmapsA != null, "pwglUseFontBitmapsA not implemented");
			retValue = Delegates.pwglUseFontBitmapsA(hDC, first, count, listBase);
			LogCommand("wglUseFontBitmapsA", retValue, hDC, first, count, listBase			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontBitmapsW.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontBitmapsW != null, "pwglUseFontBitmapsW not implemented");
			retValue = Delegates.pwglUseFontBitmapsW(hDC, first, count, listBase);
			LogCommand("wglUseFontBitmapsW", retValue, hDC, first, count, listBase			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontOutlines.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="deviation">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="extrusion">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lpgmf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFont(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontOutlines != null, "pwglUseFontOutlines not implemented");
			retValue = Delegates.pwglUseFontOutlines(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
			LogCommand("wglUseFontOutlines", retValue, hDC, first, count, listBase, deviation, extrusion, format, lpgmf			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontOutlinesA.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="deviation">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="extrusion">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lpgmf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontOutlinesA != null, "pwglUseFontOutlinesA not implemented");
			retValue = Delegates.pwglUseFontOutlinesA(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
			LogCommand("wglUseFontOutlinesA", retValue, hDC, first, count, listBase, deviation, extrusion, format, lpgmf			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglUseFontOutlinesW.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="listBase">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="deviation">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="extrusion">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lpgmf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public static bool UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglUseFontOutlinesW != null, "pwglUseFontOutlinesW not implemented");
			retValue = Delegates.pwglUseFontOutlinesW(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
			LogCommand("wglUseFontOutlinesW", retValue, hDC, first, count, listBase, deviation, extrusion, format, lpgmf			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCopyContext", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateContext(IntPtr hDc);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreateLayerContext", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateLayerContext(IntPtr hDc, int level);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteContext(IntPtr oldContext);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDescribeLayerPlane", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, IntPtr* plpd);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentContext();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentDC();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetProcAddress(String lpszProc);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeCurrent(IntPtr hDc, IntPtr newContext);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglRealizeLayerPalette", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglSetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglSwapLayerBuffers", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontBitmaps", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmaps(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontBitmapsA", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontBitmapsW", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontOutlines", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlines(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontOutlinesA", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglUseFontOutlinesW", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglCopyContext pwglCopyContext;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreateContext(IntPtr hDc);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglCreateContext pwglCreateContext;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreateLayerContext(IntPtr hDc, int level);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglCreateLayerContext pwglCreateLayerContext;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDeleteContext(IntPtr oldContext);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglDeleteContext pwglDeleteContext;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, IntPtr* plpd);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglDescribeLayerPlane pwglDescribeLayerPlane;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr wglGetCurrentContext();

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglGetCurrentContext pwglGetCurrentContext;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr wglGetCurrentDC();

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglGetCurrentDC pwglGetCurrentDC;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglGetLayerPaletteEntries pwglGetLayerPaletteEntries;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr wglGetProcAddress(String lpszProc);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglGetProcAddress pwglGetProcAddress;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglMakeCurrent(IntPtr hDc, IntPtr newContext);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglMakeCurrent pwglMakeCurrent;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglRealizeLayerPalette pwglRealizeLayerPalette;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglSetLayerPaletteEntries pwglSetLayerPaletteEntries;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglShareLists pwglShareLists;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglSwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglSwapLayerBuffers pwglSwapLayerBuffers;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontBitmaps(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontBitmaps pwglUseFontBitmaps;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontBitmapsA pwglUseFontBitmapsA;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontBitmapsW pwglUseFontBitmapsW;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontOutlines(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontOutlines pwglUseFontOutlines;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontOutlinesA pwglUseFontOutlinesA;

			[RequiredByFeature("WGL_VERSION_1_0")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglUseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[RequiredByFeature("WGL_VERSION_1_0")]
			[ThreadStatic]
			internal static wglUseFontOutlinesW pwglUseFontOutlinesW;

		}
	}

}
