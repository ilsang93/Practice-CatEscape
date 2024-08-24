
using UnityEngine;
using UnityEngine.EventSystems;

public class DirectionButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private bool isLeftButton;
    private bool isPressed;
    // Start is called before the first frame update

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData) {
        isPressed = false;
    }

    private void Update()
    {
        if (!isPressed) return;

        if (isLeftButton)
        {
            InputManager.instance.leftAction?.Invoke();
        }
        else
        {
            InputManager.instance.rightAction?.Invoke();
        }
    }
}
