using UnityEngine;
using UnityEngine.Events;
public class InputAxisController : MonoBehaviour
{
    [SerializeField] private string horizontal;
    [SerializeField] private string vertical;
    [SerializeField] private string mouseX;
    [SerializeField] private string mouseY;
    public UnityEvent<float, float> onAxisChanged;
    public UnityEvent<float, float> onAxisRotateChanged;
    private void Awake()
    {
        horizontal = "Horizontal";
        vertical = "Vertical";
        mouseX = "Mouse X";
        mouseY = "Mouse Y";
    }

    private void Update()
    {
        float horizontalAxis = Input.GetAxis(horizontal);
        float verticalAxis = Input.GetAxis(vertical);
        float mouseXAxis = Input.GetAxis(mouseX);
        float mouseYAxis = Input.GetAxis(mouseY);
        onAxisChanged?.Invoke(horizontalAxis, verticalAxis);
        onAxisRotateChanged?.Invoke(mouseXAxis, mouseYAxis);
    }

}
