using UnityEngine;

public class XROriginSpawner : MonoBehaviour
{
    public GameObject xrOrigin; // Reference to the XR Origin GameObject
    public Terrain terrain; // Reference to the Terrain component
    public float heightOffset = 0.1f; // Optional height offset above the terrain

    void Start()
    {
        SpawnAtTerrainSurface();
    }

    void Update()
    {
        UpdateXROriginPosition();
    }

    void SpawnAtTerrainSurface()
    {
        if (xrOrigin != null && terrain != null)
        {
            // Get the terrain's height at the XR Origin's current position
            Vector3 originPosition = xrOrigin.transform.position;
            float terrainHeight = terrain.SampleHeight(originPosition);

            // Set the XR Origin's position to the terrain surface with an optional offset
            xrOrigin.transform.position = new Vector3(originPosition.x, terrainHeight + heightOffset, originPosition.z);
        }
        else
        {
            Debug.LogError("XR Origin or Terrain is not assigned!");
        }
    }

    void UpdateXROriginPosition()
    {
        if (xrOrigin != null && terrain != null)
        {
            // Continuously update the XR Origin's position based on the terrain height
            Vector3 originPosition = xrOrigin.transform.position;
            float terrainHeight = terrain.SampleHeight(originPosition);

            // Update the XR Origin's position to the terrain surface with an optional offset
            xrOrigin.transform.position = new Vector3(originPosition.x, terrainHeight + heightOffset, originPosition.z);
        }
    }
}