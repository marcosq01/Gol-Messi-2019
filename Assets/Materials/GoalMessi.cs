using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMessi : MonoBehaviour
{
    public AudioSource audio_goal;

    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.name == "Goal") 
        {
            audio_goal.Play();
        }
    }
}
