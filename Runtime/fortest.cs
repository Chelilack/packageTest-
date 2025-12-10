using UnityEngine;

public class fortest : MonoBehaviour
{
    private Renderer m_renderer;
    public Material target_material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_renderer = gameObject.GetComponent<Renderer>();
        m_renderer.sharedMaterial = target_material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
