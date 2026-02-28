using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Camera _camera;

    [SerializeField] float _distance = 10f;

    [SerializeField] public Image interactionUI;

    private void Update()
    {
        InteractionRay();
    }

    public void InteractionRay() 
    {
        Ray ray = _camera.ViewportPointToRay(Vector3.one / 2f);

        RaycastHit hit;

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, _distance))
        {
            IInteraction interaction = hit.collider.GetComponent<IInteraction>();

            if (interaction != null)
            {
                interaction.Interact();
                hitSomething = true;
            }
        }

        interactionUI.gameObject.SetActive(hitSomething);
    }
}
