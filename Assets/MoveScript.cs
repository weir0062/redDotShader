using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Material mat;
    public float speed = 5;
    public AudioSource audioSource;
    public List<AudioClip> soundsList;
    // Start is called before the first frame update
    public Vector3 Position;
    int randSoundToSet;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    void PlayRandomSound()
    {
        randSoundToSet = Random.Range(0, soundsList.Count - 1);
        audioSource.clip = soundsList[randSoundToSet];
        audioSource.PlayOneShot(audioSource.clip);    
    }
   
    // Update is called once per frame
    void Update()
    {
        HandleMovements();
        HandleSounds();
    }
    void HandleMovements()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Position.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Position.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Position.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Position.x += speed * Time.deltaTime;
        }

        mat.SetVector("_Position", Position);
    }

    void HandleSounds()
    {
        if (Input.GetKeyDown(KeyCode.W) ||
           Input.GetKeyDown(KeyCode.A) ||
           Input.GetKeyDown(KeyCode.S) ||
           Input.GetKeyDown(KeyCode.D))
        {
            PlayRandomSound();
        }
    }

}
