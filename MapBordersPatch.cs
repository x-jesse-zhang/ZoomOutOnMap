using HarmonyLib;
using SandBox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZoomOutOnMap
{
    [HarmonyPatch]
    internal class MapBordersPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(MapScene), "GetMapBorders")]
        public static void GetMapBorders(out float maximumHeight)
        {
            maximumHeight = 1000f;
        }
    }
}
