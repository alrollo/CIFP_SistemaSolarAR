using UnityEngine;

public class HideCanvas : MonoBehaviour
{
    public Canvas Canvas;

    public void Hide()
    {
        this.Canvas.gameObject.SetActive(false);
    }
}
