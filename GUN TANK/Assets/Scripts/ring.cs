using UnityEngine;

public class ring : MonoBehaviour
{
    public GameObject prefab; // Prefab to instantiate
    public int numberOfObjects; // Number of objects in the ring
    public float radius; // Radius of the ring
    public Vector3 spawnPoint = new Vector3(10f, 0f, 5f); // Custom spawn point

    void Start()
    {
        MakeRing();
    }

    void MakeRing()
    {
        float angleIncrement = 360f / numberOfObjects;

        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = angleIncrement * i;
            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            float z = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            Vector3 position = spawnPoint + new Vector3(x, 0.5f, z); // Offset by (x, 0.5f, z)
            Quaternion rotation = Quaternion.Euler(0f, angle, 0f);
            Instantiate(prefab, position, rotation);
        }
    }
}
