using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class PlatformMove : MonoBehaviour
{
    public GameObject platform;
    [SerializeField] private Image[] emptyCircle;
    [SerializeField] private Sprite winCircle;
    [SerializeField] private int shootBall;
    int basketPoint;

    private void Start()
    {
        for (int i = 0; i < shootBall; i++)
        {
            emptyCircle[i].gameObject.SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))

        platform.transform.position = Vector3.Lerp(platform.transform.position, new Vector3(platform.transform.position.x -.3f, platform.transform.position.y, platform.transform.position.z),.050f);
        else if(Input.GetKey(KeyCode.D))
            platform.transform.position = Vector3.Lerp(platform.transform.position, new Vector3(platform.transform.position.x +.3f, platform.transform.position.y, platform.transform.position.z),.050f);
    }



    public void Basket()
    {
        basketPoint++;
        emptyCircle[basketPoint-1].sprite=winCircle;
    }
    public void Lose()
    {
        Time.timeScale = 0.0f;
    }

}
