using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.Events;
using TMPro;

public enum Animals
{
    Cat,
    Dog,
    Fish
}
public class Botoes : MonoBehaviour
{
    public TMP_InputField inputField;

    public UnityEvent eventCallback;

    public EnemyBase enemyBase;

    public List<GameObject> listOfObjects;

    private void Attack()
    {
        foreach(var o in listOfObjects)
        {
            //if (o != null)
            {
                var damageable = o.GetComponent<IDamageable<int>>();
                if(damageable != null)
                {
                    damageable.Damage(1);
                }

            }

        }


    }

    private void Start()
    {
        
    }
    public bool checkStatus = false;

    [Range(-5, 5)]
    public int value01;
    public int value02;

    public int checkOne = 0;

    public void DebugLog()
    {
        Debug.Log("Clicou no botão :: "+ inputField.text);
    }

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Cat:
                OnReadCat();
                break;
            case Animals.Dog:
                OnReadDog();
                break;
            case Animals.Fish:
                OnReadFish();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            eventCallback.Invoke();

            //CheckSwitchCase(Animals.Cat);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            enemyBase.Attack();

            //CheckSwitchCase(Animals.Dog);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Attack();
            //CheckSwitchCase(Animals.Fish);

        }

    }

    private void CheckValues()
    {

        //if(true E true)
        if (value01 == checkOne)
        {
            Debug.Log("value01 é igual a checkOne");
        }
        else if (value01 == 1)
        {
            Debug.Log("value01 é 1");
        }
        else if (value01 == 2)
        {
            Debug.Log("value01 é 2");
        }
    }

    private void OnReadCat()
    {
        Debug.Log("Gato");
    }
    
    private void OnReadDog()
    {
        Debug.Log("Cachorro");
    }
    
    private void OnReadFish()
    {
        Debug.Log("Peixe");
    }
    
    private void Update()
    {
        //CheckSwitchCase();
        CheckKeys();
        

    }
}
