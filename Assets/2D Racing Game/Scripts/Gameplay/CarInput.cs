using UnityEngine;
using System.Collections;

public class CarInput : MonoBehaviour
{
    [HideInInspector] public CarController carController;

    public void Gas()
    {
        carController.Acceleration();
    }

    public void Brake()
    {
        carController.Brake();
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(.3f);
        carController = GameObject.FindObjectOfType<CarController>();
    }


    public void ReleaseGasBrake()
    {
        carController.GasBrakeRelease();
    }
}