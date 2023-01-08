using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class    Bg1 : MonoBehaviour
{ 
    public float speed;

    float offset;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += speed;
        material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
