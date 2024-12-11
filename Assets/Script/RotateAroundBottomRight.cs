using UnityEngine;

public class RotateAroundBottomRight : MonoBehaviour
{
    public float rotationSpeed = 10f; // ‰ñ“]‘¬“xi“x/•bj
    public float rotationAngle = 10f; // ‰ñ“]Šp“xiÅ‘åŠp“xj

    private RectTransform rectTransform;
    private float currentAngle = 0f;
    private bool isIncreasing = true;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        if (rectTransform == null)
        {
            Debug.LogError("This script requires a RectTransform. Please attach it to a UI element.");
        }
    }

    void Update()
    {
        if (rectTransform == null) return;

        // ‰ñ“]Šp“x‚ğ‘Œ¸‚³‚¹‚é
        if (isIncreasing)
        {
            currentAngle += rotationSpeed * Time.deltaTime;
            if (currentAngle >= rotationAngle)
            {
                currentAngle = rotationAngle;
                isIncreasing = false;
            }
        }
        else
        {
            currentAngle -= rotationSpeed * Time.deltaTime;
            if (currentAngle <= -rotationAngle)
            {
                currentAngle = -rotationAngle;
                isIncreasing = true;
            }
        }

        // ‰E‰º‚ğ²‚É‰ñ“]‚³‚¹‚é
        rectTransform.pivot = new Vector2(1f, 0f); // ‰E‰º
        rectTransform.localRotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
}
