/*
* Author: Wee Han
* Date of creation: 25/05/2024
* Description: Code for all the collectibles change
*/
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using StarterAssets;
public class Collectible : MonoBehaviour
{
    public void SpeedIncrease(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().MoveSpeed = 40.0f;
    }
    public void JumpIncrease(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().JumpHeight = 40.0f;
    }
}
