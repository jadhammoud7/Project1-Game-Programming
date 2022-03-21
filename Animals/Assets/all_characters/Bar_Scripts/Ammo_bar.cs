using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo_bar : MonoBehaviour
{
    [Tooltip("The slider is the slider of the ammo bar that moves according to the current health of the animal")]
    public Slider slider;

    [Tooltip("The fill is the current color of the ammo bar that will be either green, yellow, or red according to the animal health")]
    public Image fill;
    public void setMaxAmmo(int ammo_nb)//set the slider to the max value
    {
        slider.maxValue = ammo_nb;
        slider.value =3;

    }
    public void setAmountNumber(int ammo_nb)//set the slider to the current value of the health
    {
        slider.value = ammo_nb;
        Debug.Log(slider.value);
    }
    void Start()
    {
       //setMaxAmmo(25);//initial max value is 25
       //setAmountNummber(3);
    }
        public int getNumber_of_Ammo(){
        return (int)slider.value;
    }
}