using UnityEngine;

public class fortest : MonoBehaviour
{
    void Start()
    {
        var mat = GetComponent<Renderer>().material;

        if (mat.HasProperty("_Color"))
            mat.color =  Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
