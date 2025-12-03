using UnityEngine;

public class Rotate : MonoBehaviour, IInteractable
{
    public GameObject cube;

    public void RotateCube()
    {
        cube.transform.Rotate(0f, 90f, 0f);
    }

    public void InteractLogic()
    {
        RotateCube();
    }
}
