using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public enum AxisLineName
{
    Horizontal, Vertical,
}
public class InputAxisController : MonoBehaviour
{
    [SerializeField] private string horizontal;
    [SerializeField] private string vertical;
    public UnityEvent<float, float> onAxisChanged;
    private void Awake()
    {
        horizontal = AxisLineName.Horizontal.ToString();
        vertical = AxisLineName.Vertical.ToString();
    }

    private void Update()
    {
        float newAxisValue = Input.GetAxis(horizontal);
        onAxisChanged?.Invoke(Input.GetAxis(horizontal), Input.GetAxis(vertical));
    }
}
