using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportToOrigin : MonoBehaviour
{

    public InputActionReference teleportButton;
    public Transform head;
    // Start is called before the first frame update
    void Start()
    {
        teleportButton.action.canceled += ButtonReleased;
    }

    void ButtonReleased(InputAction.CallbackContext context)
    {
        head.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
