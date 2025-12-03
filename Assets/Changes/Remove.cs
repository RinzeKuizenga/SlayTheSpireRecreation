using UnityEngine;

public class Remove : MonoBehaviour, IInteractable
{
    public GameObject cube;

    public void Break()
    {
        cube.SetActive(false);
    }

    public void InteractLogic()
    {
        Break();
    }
}
