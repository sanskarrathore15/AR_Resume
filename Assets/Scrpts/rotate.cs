using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rot;

    private void Update()
    {
        transform.Rotate(rot*Time.deltaTime);
    }
}
