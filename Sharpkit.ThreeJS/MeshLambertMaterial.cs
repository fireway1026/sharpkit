﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class MeshLambertMaterial : Material
    {
        public MeshLambertMaterial(MeshLambertMaterialOptions parameters) { }

        public Color color { get; set; }
    
    }
}