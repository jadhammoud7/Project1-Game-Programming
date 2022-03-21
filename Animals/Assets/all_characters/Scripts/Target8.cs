using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Target8 : MonoBehaviour
{
    [Tooltip("The max health of this animal is 50, and it is fixed.")]
    public int Maxhealth = 50;
    [Tooltip("The current health of the animal, and that will decrease when the animal is shot by a gun.")]
    public int currentHealth = 50;
    [Tooltip("The aim point which is the center of the screen")]
    public RectTransform AimPoint;
    [Tooltip("Damage health for the target enemy")]
    public int damage = 10;
    [Tooltip("Range for damage around the enemy")]
    public int range = 100;
    [Tooltip("Speed of the bullet fire")]
    public int impactForce = 30;
    [Tooltip("The health bar is the script of the health bar which is above the animal")]
    public health_bar health_bar1;
    [Tooltip("The ammo bar of the player")]
    public Ammo_bar ammo_incremting;
    [Tooltip("The score bar which displays the score of the player")]
    public score_bar score_Bar;
    [Tooltip("The destination of the nav mesh which is the hunter")]
    public GameObject PlayerHunter;
    [Tooltip("The health of the player hunter that will be decremented when the animal attacks him")]
    public health_bar PlayerHealth;

    NavMeshAgent agent;

    //the ammo script will be usef here
    public void TakeDamage(int amount)
    {
        agent.destination = PlayerHunter.transform.position;
        currentHealth -= amount;
        health_bar1.setHealth(currentHealth);//set the current health of the animal to be the new value
        Debug.Log("health of " + gameObject.name + " is now: " + currentHealth);
        if (currentHealth == 0)//when the health is 0, then the animal dies
        {
            //Destroy(gameObject);
            Destroy(gameObject);
            score_Bar.setScore(score_Bar.getScore()+1);
        }
    }
    void Start() {
        agent = GetComponent<NavMeshAgent>(); 
        PlayerHealth.setMaxHealth(100);   
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //check if there is ammo
            if (ammo_incremting.getNumber_of_Ammo() > 0)//if the nb of ammo is greater than 0 then he can simply shoot
            {
                RaycastHit hit;//get info about the hit object
                Ray ray = Camera.main.ScreenPointToRay(AimPoint.transform.position);
                if (Physics.Raycast(ray, out hit, range))
                {
                    if (hit.transform.name == gameObject.name)
                    {
                        Debug.Log("Current ammo is: "+ammo_incremting.getNumber_of_Ammo());

                        ammo_incremting.setAmountNumber(ammo_incremting.getNumber_of_Ammo()-1);
                        TakeDamage(damage);//enter take damage 
                    }
                    if (hit.rigidbody != null)
                    {
                        hit.rigidbody.AddForce(-hit.normal * impactForce);//add force on the rigid body of the target
                    }
                }
            }else if(ammo_incremting.getNumber_of_Ammo()<=0){
                 Debug.Log("Out of ammo");
            }

        }
        
    }
    private void OnCollisionEnter(Collision other) {//when the animal attacks the player 
        if(other.gameObject.tag == "Player"){
            PlayerHealth.setHealth(PlayerHealth.getCurrentHealth()-10);//decrease health of player by 10
        }
        if(PlayerHealth.getCurrentHealth() == 0){//if player died, then load the menu scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Go to the next scene level as in build settings
        }
    }
}

