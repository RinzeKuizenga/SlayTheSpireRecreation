using UnityEngine;

public class ColourChange : MonoBehaviour, IInteractable
{
    public GameObject cube;

    public void ChangeColour()
    {
        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV();
    }
    public void InteractLogic()
    {
        ChangeColour();
    }
}
