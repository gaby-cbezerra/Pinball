using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]
public class FlipperController : MonoBehaviour
{
    [Header("Tecla de controle")]
    public KeyCode inputKey;

    [Header("Configuração do motor")]
    public float motorSpeed = 1000f;
    public float motorMaxTorque = 50000f; // ⬅️ AUMENTADO

    [Header("Inverter direção")]
    public bool invertDirection = false;

    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;

        // Garante que o motor esteja inicializado corretamente
        JointMotor2D motor = hinge.motor;
        motor.maxMotorTorque = motorMaxTorque;
        hinge.motor = motor;
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        float finalSpeed = invertDirection ? -motorSpeed : motorSpeed;

        if (Input.GetKey(inputKey))
        {
            motor.motorSpeed = -finalSpeed;
        }
        else
        {
            motor.motorSpeed = finalSpeed;
        }

        motor.maxMotorTorque = motorMaxTorque;
        hinge.motor = motor;    
    }
}
