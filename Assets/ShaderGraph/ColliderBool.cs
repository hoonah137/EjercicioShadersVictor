using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBool : MonoBehaviour
{
    public Material _shaderGraph;
    // Start is called before the first frame update
    void Start()
    {
        //_shaderGraph = gameObject.GetComponentInChildren<Material>();
    }

    void OnTriggerEnter(Collider other)
    {
        _shaderGraph.SetFloat("_collider",0);
    }

    void OnTriggerStay(Collider other)
    {
        _shaderGraph.SetFloat("_collider",0);
    }

    void OnTriggerExit(Collider other)
    {
        _shaderGraph.SetFloat("_collider",1);
    }
}
