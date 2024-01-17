using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAnimation : MonoBehaviour
{
    [SerializeField]
    private GameObject sun, mercury, venus, earth, mars, jupiter, saturn, uranus, neptune;

    public float speed = 30f;
    public float angularSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        mercury.transform.Rotate(new Vector3(0, angularSpeed * 0.80f * Time.deltaTime, 0));
        venus.transform.Rotate(new Vector3(0, angularSpeed * 0.62f * Time.deltaTime, 0));
        earth.transform.Rotate(new Vector3(0, angularSpeed * 0.54f * Time.deltaTime, 0));
        mars.transform.Rotate(new Vector3(0, angularSpeed * 0.49f * Time.deltaTime, 0));
        jupiter.transform.Rotate(new Vector3(0, angularSpeed * 0.42f * Time.deltaTime, 0));
        saturn.transform.Rotate(new Vector3(0, angularSpeed * 0.36f * Time.deltaTime, 0));
        uranus.transform.Rotate(new Vector3(0, angularSpeed * 0.23f * Time.deltaTime, 0));
        neptune.transform.Rotate(new Vector3(0, angularSpeed * 0.14f * Time.deltaTime, 0));
    }
}
