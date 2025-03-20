using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public void spawnSphere()
    {
        this.gameObject.transform.position = new Vector3(0f, 1.5f, 2.5f);
    }
}
