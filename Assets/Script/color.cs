using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
      public Material material_1;

    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<MeshRenderer>().material = material_1;
    }
}
