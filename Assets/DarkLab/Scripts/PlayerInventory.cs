using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public static int TP;
    public int NumberOfTables { get; private set; }

    //public UnityEvent<PlayerInventory> OnTableCollected;

  
    public void TableCollected()
    {
        NumberOfTables++;
       //OnTableCollected.Invoke(this);
        PlayerInventory.TP += 1;
        Debug.Log(NumberOfTables);
        
    }

   
}
