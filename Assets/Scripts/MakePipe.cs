using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;

    float timer = 0;
    void Start()
    {

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0.94f,Random.Range (-1.39f,4.41f),0);
             
            timer = 0;
        }
    }
}
