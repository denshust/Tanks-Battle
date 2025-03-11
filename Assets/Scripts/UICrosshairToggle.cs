using UnityEngine;

public class UICrosshairToggle : MonoBehaviour
{
    public GameObject crosshairUI; // Посилання на UI-приціл
    public KeyCode toggleKey = KeyCode.R; // Клавіша для перемикання

    public Camera aimCamera;
    public Camera defaultCamera;
    void Start()
    {
        if (crosshairUI == null)
        {
            Debug.LogError("❌ UI Приціл не призначено в Inspector!");
            return;
        }

        crosshairUI.SetActive(false); // Спочатку ховаємо приціл
        Debug.Log("✅ Приціл вимкнено при старті.");
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            Debug.Log("✅ Клавіша R натиснута!");

            if (crosshairUI != null)
            {
                bool newState = !crosshairUI.activeSelf;
                crosshairUI.SetActive(newState);
                aimCamera.gameObject.SetActive(newState);
                defaultCamera.gameObject.SetActive(!newState);
                Debug.Log("🔄 Приціл активний: " + newState);
            }
        }
    }
}