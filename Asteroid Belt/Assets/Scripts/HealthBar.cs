using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetStartingHealth(float Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
    }
    public void SetHealth(float Health)
    {
        slider.value = Health;
    }

}
