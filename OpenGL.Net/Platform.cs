﻿
// Copyright (C) 2016-2017 Luca Piccioni
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

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Detected platforms.
	/// </summary>
	public static class Platform
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static Platform()
		{
			// Cache platform ID
			_CurrentPlatformId = GetCurrentPlatform();
			// Detect Mono environment
			_MonoVersion = DetectMonoEnvironment();
		}

		/// <summary>
		/// Platform identifiers.
		/// </summary>
		public enum Id
		{
			/// <summary>
			/// Microsoft Windows NT.
			/// </summary>
			WindowsNT,

			/// <summary>
			/// GNU/Linux.
			/// </summary>
			Linux,

			/// <summary>
			/// Apple MacOS.
			/// </summary>
			MacOS,

			/// <summary>
			/// Android.
			/// </summary>
			Android,

			/// <summary>
			/// Unknown platform.
			/// </summary>
			Unknown,
		}

		/// <summary>
		/// Get the current platform ID.
		/// </summary>
		public static Id CurrentPlatformId { get { return (_CurrentPlatformId); } }
		
		/// <summary>
		/// The current platform ID.
		/// </summary>
		private static Id _CurrentPlatformId;

		/// <summary>
		/// Detected the current platform at runtime.
		/// </summary>
		/// <returns>
		/// It returns the detected platform.
		/// </returns>
		private static Id GetCurrentPlatform()
		{
#if !NETCORE
			// Framework platform
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
					return (Id.WindowsNT);
				case PlatformID.Unix:
					// Android special case
					if (Type.GetType("Android.OS.Build, Mono.Android.dll") != null)
						return (Id.Android);

					// Other cases: Linux, MacOS
					string unixName = DetectUnixKernel();

					switch (unixName) {
						case "Darwin":
							return (Id.MacOS);
						default:
							return (Id.Linux);
					}
				case PlatformID.MacOSX:
					return (Id.MacOS);
				default:
					return (Id.Unknown);
			}
			
#else
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
				return (Id.WindowsNT);
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
				return (Id.Linux);
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
				return (Id.MacOS);
			else
				return (Id.Unknown);
#endif
		}

		/// <summary>
		/// Executes "uname" which returns a string representing the name of the
		/// underlying Unix kernel.
		/// </summary>
		/// <returns>
		/// "Unix", "Linux", "Darwin" or null.
		/// </returns>
		/// <remarks>
		/// Source code from "Mono: A Developer's Notebook"
		/// </remarks>
		private static string DetectUnixKernel()
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();

			startInfo.Arguments = "-s";
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;

			foreach (string unameprog in new string[] { "/usr/bin/uname", "/bin/uname", "uname" }) {
				// Avoid exception handling
				if (File.Exists(unameprog) == false)
					continue;

				try {
					startInfo.FileName = unameprog;
					using (Process uname = Process.Start(startInfo)) {
						return (uname.StandardOutput.ReadLine().Trim());
					}
				} catch (FileNotFoundException) {
					// The requested executable doesn't exist, try next one.
					continue;
				} catch (System.ComponentModel.Win32Exception) {
					continue;
				}
			}

			return (null);
		}

		/// <summary>
		/// Get whether the running runtime is Mono.
		/// </summary>
		public static bool RunningMono { get { return (_MonoVersion != null); } }

		/// <summary>
		/// The Mono display name, if any.
		/// </summary>
		private static readonly string _MonoVersion;

		/// <summary>
		/// Detect the Mono environment.
		/// </summary>
		/// <returns>
		/// It returns the version string of Mono, if running with it.
		/// </returns>
		private static string DetectMonoEnvironment()
		{
			Type monoRuntime = Type.GetType("Mono.Runtime", false);

			if (monoRuntime != null) {
				string runningVersion = "generic";
				try {
					MethodInfo getDisplayName = monoRuntime.GetMethod("GetDisplayName", BindingFlags.Static | BindingFlags.NonPublic);
					if (getDisplayName != null)
						runningVersion = getDisplayName.Invoke(null, new object[0]) as string;
				} catch { /* Ignore */ }

				return (runningVersion);
			} else
				return (null);
		}
	}
}
