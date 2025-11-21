using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator linnsAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        linnsAnimator = GetComponent<Animator>();
        
        linnsAnimator.SetBool("Walk", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            linnsAnimator.SetBool("Walk", true);
        }
            
        if (Input.GetKeyUp("d"))
        {
            linnsAnimator.SetBool("Walk", false);
        }
        
        if (Input.GetKeyDown("a"))
        {
            linnsAnimator.SetBool("Walk", true);
        }
            
        if (Input.GetKeyUp("a"))
        {
            linnsAnimator.SetBool("Walk", false);
        }
    }
}
