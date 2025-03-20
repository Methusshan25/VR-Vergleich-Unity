using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SetTurnType : MonoBehaviour
{
    [SerializeField] public ActionBasedSnapTurnProvider snapTurnProvider;
    [SerializeField] public ActionBasedContinuousMoveProvider continuousMoveProvider;
    [SerializeField] public TeleportationProvider teleportationProvider;
    [SerializeField] public XRRayInteractor teleportRay;
    [SerializeField] public XRInteractorLineVisual xrInteractorLineVisual;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            continuousMoveProvider.enabled = false;
            teleportationProvider.enabled = true;
            teleportRay.enabled = true;
            xrInteractorLineVisual.reticle.SetActive(true);
        }
        else if(index == 1)
        {
            continuousMoveProvider.enabled = true;
            teleportationProvider.enabled = false;
            teleportRay.enabled = false;
            xrInteractorLineVisual.reticle.SetActive(false);
        }
    }
}
