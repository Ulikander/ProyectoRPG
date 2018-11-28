using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardAnimation : MonoBehaviour
{
    public Texture2D spriteAll;
    [SerializeField]
    Sprite[] sprites;
    public SpriteRenderer sr;
    //public string type;
    [SerializeField]
    int currentFrame = 0;
    public bool playing = false;
    public float frameDuration = 0.4f;
    float frameCont = 0f;
    public int lookingAt = 1;
    

    
	// Use this for initialization
	void Start ()
    {
        
        //StartCoroutine(Animation());
    }
	
	// Update is called once per frame
	void Update ()
    {
        Animation();	
	}

    void Animation()
    {
        if (!playing)
        {
            sr.sprite = sprites[(lookingAt * 4)];
            currentFrame = 0;
            frameCont = 0f;
            return;
        }

        if (frameCont >= frameDuration)
        {
            sr.sprite = sprites[currentFrame + (lookingAt * 4)];
            currentFrame++;
            if (currentFrame > 3) currentFrame = 0;
            frameCont = 0;
        }
        else
            frameCont += 1 * Time.deltaTime;
    }
}
