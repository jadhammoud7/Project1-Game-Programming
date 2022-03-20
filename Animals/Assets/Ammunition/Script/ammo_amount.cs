
using UnityEngine;
[CreateAssetMenu(fileName ="New Ammo Amount container",menuName ="Ammo Amount",order =1)]
public class ammo_amount : ScriptableObject
{
    [Tooltip("The ammos available in the ammo object")]
    public int ammo_counter=3;
}
