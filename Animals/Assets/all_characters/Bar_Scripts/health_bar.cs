using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health_bar : MonoBehaviour
{
    [Tooltip("The slider is the slider of the health bar that moves according to the current health of the animal")]
    public Slider slider;
    [Tooltip("Gradient is the set of colors of the health bar that will be changed along the movement of the slider")]
    public Gradient gradient;
    [Tooltip("The fill is the current color of the health bar that will be either green, yellow, or red according to the animal health")]
    public Image fill;
    public void setMaxHealth(int health)//set the slider to the max value
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
    public void setHealth(int health)//set the slider to the current value of the health
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        Debug.Log(slider.value);
    }
    public int getCurrentHealth(){
        return (int)slider.value;
    }
    void Start()
    {
       setMaxHealth(50);//initial max value is 50
    }

}
