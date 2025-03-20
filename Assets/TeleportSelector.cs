using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportSelector : MonoBehaviour
{
    [SerializeField] private XRRayInteractor rayInteractor;
    // Start is called before the first frame update
    void Start()
    {
        rayInteractor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit))
        {
            rayInteractor.enabled = true;
        }
    }
}
