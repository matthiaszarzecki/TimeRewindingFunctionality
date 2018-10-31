using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class Keyframe
{
    public Vector3 position;
    public Vector3 rotation;

    public Keyframe(Vector3 position, Vector3 rotation)
    {
        this.position = position;
        this.rotation = rotation;
    }
}

public class TimeController: MonoBehaviour
{
	public GameObject player;
    public ArrayList keyframes;
    public bool isReversing = false;

    public int keyframe = 5;
    private int frameCounter = 0;
    private int reverseCounter = 0;

    private Vector3 currentPosition;
    private Vector3 previousPosition;
    private Vector3 currentRotation;
    private Vector3 previousRotation;

    private Camera camera;

    private bool firstRun = true;

	void Start()
	{
        keyframes = new ArrayList();
        camera = Camera.main;
	}

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            isReversing = true;
            camera.GetComponent<Blur>().enabled = true;
            camera.GetComponent<Bloom>().enabled = true;
        }
        else
        {
            isReversing = false;
            firstRun = true;
            camera.GetComponent<Blur>().enabled = false;
            camera.GetComponent<Bloom>().enabled = false;
        }
    }

	void FixedUpdate()
	{
        if(!isReversing)
        {
            if(frameCounter < keyframe)
            {
                frameCounter += 1;
            }
            else
            {
                frameCounter = 0;
                keyframes.Add(new Keyframe(player.transform.position, player.transform.localEulerAngles));
            }
        }
        else
        {
            if(reverseCounter > 0)
            {
                reverseCounter -= 1;
            }
            else
            {
                reverseCounter = keyframe;
                RestorePositions();
            }

            if(firstRun)
            {
                firstRun = false;
                RestorePositions();
            }

            float interpolation = (float) reverseCounter / (float) keyframe;
            player.transform.position = Vector3.Lerp(previousPosition, currentPosition, interpolation);
            player.transform.localEulerAngles = Vector3.Lerp(previousRotation, currentRotation, interpolation);
        }

        if(keyframes.Count > 128)
        {
            keyframes.RemoveAt(0);
        }
	}

    void RestorePositions()
    {
        int lastIndex = keyframes.Count - 1;
        int secondToLastIndex = keyframes.Count - 2;

        if(secondToLastIndex >= 0)
        {
            currentPosition  = (keyframes[lastIndex] as Keyframe).position;
            previousPosition = (keyframes[secondToLastIndex] as Keyframe).position;

            currentRotation  = (keyframes[lastIndex] as Keyframe).rotation;
            previousRotation = (keyframes[secondToLastIndex] as Keyframe).rotation;

            keyframes.RemoveAt(lastIndex);
        }
    }
}