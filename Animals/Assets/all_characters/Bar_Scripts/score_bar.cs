using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_bar : MonoBehaviour
{
    public int current_score=0;

    [Tooltip("The slider is the slider of the health bar that moves according to the current health of the animal")]
    public Slider slider;

    [Tooltip("The fill is the current color of the ammo bar that will be either green, yellow, or red according to the animal health")]
    public Image fill;

    public void setMaxScore(int score)//set the slider to the max value
    {
        
        slider.maxValue = score;
        //slider.value = score;
    }
    public void setScore(int score)//set the slider to the current value of the health
    {
        current_score=score;
        slider.value = score;
        Debug.Log(slider.value);
    }
     void Start()
    {
        setScore(current_score);
        setMaxScore(100);//initial max value is 15
        Debug.Log(slider.value);
    }
    public int getScore(){
        return current_score;
    }
}
