using UnityEngine;
using UnityEngine.UI;

public class PasekZycia : MonoBehaviour
{
    public Slider slider;

    public void UstawMaxHP(float health){
        slider.maxValue = health;
    }

    public void UstawHP(float health){
        float currentHealth = slider.value;
        if (currentHealth <= health)
            slider.value = 0;
        slider.value = health;
    }

    public void Heal(float health){
        slider.value += health;
    }
}
