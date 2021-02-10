using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCube : MonoBehaviour
{
    [SerializeField]
    bool isRed=true;
    [SerializeField]
    bool isBlue=false;

    [SerializeField]
    GameObject effectBlue;
    [SerializeField]
    GameObject effectRed;

    [SerializeField]
    Material redMaterial;
    [SerializeField]
    Material blueMaterial;

    private void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PaintCube")
        {
            if (isRed)
            {
                isRed = false;
                isBlue = true;
                GetComponent<Renderer>().material = blueMaterial;
                Instantiate(effectBlue, transform.position, transform.rotation);

            }
            else if (isBlue)
            {
                isBlue = false;
                isRed = true;
                GetComponent<Renderer>().material = redMaterial;
                Instantiate(effectRed, transform.position, transform.rotation);
            }
            Destroy(other.transform.parent.gameObject);
        }
    }
}
