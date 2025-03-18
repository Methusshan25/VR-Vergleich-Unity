using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SetTurnType : MonoBehaviour
{
    [SerializeField] public ActionBasedSnapTurnProvider snapTurnProvider;
    [SerializeField] public ActionBasedContinuousMoveProvider continuousMoveProvider;
    [SerializeField] public TeleportationProvider teleportationProvider;
    [SerializeField] public XRRayInteractor teleportRay;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapTurnProvider.enabled = false;
            continuousMoveProvider.enabled = false;
            teleportationProvider.enabled = true;
            teleportRay.enabled = true;
        }
        else if(index == 1)
        {
            snapTurnProvider.enabled = true;
            continuousMoveProvider.enabled = true;
            teleportationProvider.enabled = false;
            teleportRay.enabled = false;
        }
    }
}
