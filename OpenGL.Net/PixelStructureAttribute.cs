﻿
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	class PixelStructureAttribute : Attribute
	{
		/// <summary>
		/// Construct <see cref="OpenGL.PixelStructureAttribute"/> class.
		/// </summary>
		/// <param name="type">
		/// The structure type able to represent the pixel.
		/// </param>
		public PixelStructureAttribute(Type type)
		{
			PixelStructureType = type;
		}

		/// <summary>
		/// The number of bits to represent color component.
		/// </summary>
		public readonly Type PixelStructureType;
	}
}