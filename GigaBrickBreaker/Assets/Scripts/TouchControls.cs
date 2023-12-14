using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControls : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isLeftButton; // Set this to true in the inspector for the left button

    public static bool isLeftPressed;
    public static bool isRightPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (isLeftButton)
        {
            isLeftPressed = true;
        }
        else
        {
            isRightPressed = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isLeftButton)
        {
            isLeftPressed = false;
        }
        else
        {
            isRightPressed = false;
        }
    }
}