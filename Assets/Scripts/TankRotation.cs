using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotation : MonoBehaviour
{
    [SerializeField] private float rotateAngle;
    private void Update()
    {
        transform.Rotate(0, rotateAngle, 0);
    }
}
