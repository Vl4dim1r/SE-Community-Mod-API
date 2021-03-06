﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Sandbox.Common.ObjectBuilders;

using SEModAPIInternal.API.Common;
using SEModAPIInternal.Support;

namespace SEModAPIInternal.API.Entity.Sector.SectorObject.CubeGrid.CubeBlock
{
	public class ConveyorBlockEntity : CubeBlockEntity
	{
		#region "Attributes"

		public static string ConveyorBlockNamespace = "5BCAC68007431E61367F5B2CF24E2D6F";
		public static string ConveyorBlockClass = "D995E2F0C72D87529534369061DB78CF";

		#endregion

		#region "Constructors and Intializers"

		public ConveyorBlockEntity(CubeGridEntity parent, MyObjectBuilder_Conveyor definition)
			: base(parent, definition)
		{
		}

		public ConveyorBlockEntity(CubeGridEntity parent, MyObjectBuilder_Conveyor definition, Object backingObject)
			: base(parent, definition, backingObject)
		{
		}

		#endregion

		#region "Properties"
		#endregion

		#region "Methods"

		/// <summary>
		/// Method to get the casted instance from parent signature
		/// </summary>
		/// <returns>The casted instance into the class type</returns>
		new internal MyObjectBuilder_Conveyor GetSubTypeEntity()
		{
			return (MyObjectBuilder_Conveyor)ObjectBuilder;
		}

		#endregion
	}
}
