using UnityEngine;
using System.Collections;

public class Player: MonoBehaviour
{
    private TimeController timeController;

    void Start()
    {
        timeController = FindObjectOfType(typeof(TimeController)) as TimeController;
    }
	
	void Update()
	{
        if(!timeController.isReversing)
        {
		    transform.Translate (Vector3.forward * 3.0f * Time.deltaTime * Input.GetAxis ("Vertical"));
		    transform.Rotate (Vector3.up * 200.0f * Time.deltaTime * Input.GetAxis ("Horizontal"));
        }
	}
}