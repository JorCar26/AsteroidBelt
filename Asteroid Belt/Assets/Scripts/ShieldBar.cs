using UnityEngine;
using UnityEngine.UI;

public class ShieldBar : MonoBehaviour
{
    public Slider slider;

    public void SetShieldMax(float Shield)
    {
        slider.maxValue = Shield;
        slider.value = Shield;
    }
    public void SetShield(float Shield)
    {
        slider.value = Shield;
    }
}
