
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gamemanager;
    public PlayerMove movement;

    void OnTriggerEnter()
    {
        gamemanager.Completelevel();
        movement.enabled = false;
    }
}
