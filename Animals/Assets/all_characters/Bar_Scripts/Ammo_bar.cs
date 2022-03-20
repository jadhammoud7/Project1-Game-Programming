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

    [Tooltip("The Scriptable Object ammo_amount that container ammo_counter")]
    [SerializeField]
    ammo_amount amount;
    
    public void setMaxAmmo(int ammo_nb)//set the slider to the max value
    {
        slider.maxValue = ammo_nb;
    }
    public void setAmountNumber()//set the slider to the current value of the health
    {
        slider.value = amount.ammo_counter;
    }
    void Start()
    {
       setMaxAmmo(25);//Max ammos is 25
    }
    void Update(){
        setAmountNumber();
    }
    public int getNumber_of_Ammo(){//returns number of ammos currently
        return (int)slider.value;
    }
}
