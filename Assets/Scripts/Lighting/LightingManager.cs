using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways] // Execute in edit mode
public class LightingManager : MonoBehaviour
{
    public Light sunLight;
    public Light moonLight;
    public LightingObject preset;
    [Range(0, 24)] public float timeOfDay;
    [Tooltip ("Lower is faster.")] [Range (0.1f, 12f)] public float timeMultiplier = 10f;

    private void Update()
    {
        if (Application.isPlaying)
        {
            timeOfDay += Time.deltaTime / timeMultiplier;
            timeOfDay %= 24;
        }

        UpdateLighting(timeOfDay / 24f);
    }

    private void UpdateLighting(float hourOfDay)
    {
        RenderSettings.ambientLight = preset.AmbientColour.Evaluate(hourOfDay);

        if (sunLight != null)
        {
            sunLight.color = preset.DirectionalColour.Evaluate(hourOfDay);

            sunLight.transform.localRotation = Quaternion.Euler(new Vector3((hourOfDay * 360f) - 90f, 170f, 0));
            moonLight.transform.localRotation = Quaternion.Euler(new Vector3((hourOfDay * 360f) - 270f, 170f, 0));
        }
    }
}
