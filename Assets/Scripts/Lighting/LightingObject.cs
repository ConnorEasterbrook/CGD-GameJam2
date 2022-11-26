using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "LightingObject", menuName = "Lighting/LightingObject", order = 1)]
public class LightingObject : ScriptableObject
{
    public Gradient AmbientColour; // Ambient colour gradient
    public Gradient DirectionalColour; // Directional colour gradient
    public Gradient FogColour; // Fog colour gradient
}
