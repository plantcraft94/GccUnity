using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    [SerializeField] Hello2 hello2;
    public int hp;
    [SerializeField] private int speed;
    private void Start()
    {
        Debug.Log(hello2.hp);
    }
    public void SayHello()
    {
        Debug.Log("Hello");
    }
}
