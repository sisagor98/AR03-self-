using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject Objectspawn;
    private Detectplane detectplace;

    private void Start()
    {
        detectplace = FindObjectOfType<Detectplane>();
    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(Objectspawn, detectplace.transform.position, detectplace.transform.rotation);
        }
    }

}
