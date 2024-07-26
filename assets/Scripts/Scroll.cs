using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speedScroll;
    public MeshRenderer mesh;

    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * speedScroll);
        mesh.material.mainTextureOffset = offset;

    }
}