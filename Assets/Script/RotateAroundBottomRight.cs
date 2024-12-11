using UnityEngine;

public class RotateAroundBottomRight : MonoBehaviour
{
    public float rotationSpeed = 10f; // ��]���x�i�x/�b�j
    public float rotationAngle = 10f; // ��]�p�x�i�ő�p�x�j

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

        // ��]�p�x�𑝌�������
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

        // �E�������ɉ�]������
        rectTransform.pivot = new Vector2(1f, 0f); // �E��
        rectTransform.localRotation = Quaternion.Euler(0f, 0f, currentAngle);
    }
}
