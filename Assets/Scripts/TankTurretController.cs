using UnityEngine;

public class TankTurretController : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("Чутливість повороту башти в залежності від руху мишки.")]
    public float rotationSensitivity = 5f;

    [Tooltip("Мінімальний кут повороту башти.")]
    public float minRotationAngle = -45f;

    [Tooltip("Максимальний кут повороту башти.")]
    public float maxRotationAngle = 45f;

    // Поточний кут повороту башти
    private float currentRotationY = 0f;

    void Update()
    {
        if (Time.timeScale > 0)
        {
            RotateTurret();
        }
    }

    private void RotateTurret()
    {
        // Отримуємо горизонтальний рух миші
        float mouseX = Input.GetAxis("Mouse X");


        // Обчислюємо новий кут повороту
        currentRotationY += mouseX * rotationSensitivity;

        // Обмежуємо кут повороту в заданих межах
        currentRotationY = Mathf.Clamp(currentRotationY, minRotationAngle, maxRotationAngle);

        // Застосовуємо обертання до башти
        transform.localRotation = Quaternion.Euler(0, currentRotationY, 0);
    }
}
