using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class PlayerController : MonoBehaviour
{
    // public AudioClip c1, c2, c3;
    AudioSource asource;
    public AudioSource source1 , source2;
    // public AudioClip clip;
    public float speed = 1f;
    public float jumpSpeed = 9f;
    public float maxSpeed = 10f;
    public float JumpPower = 20f;
    public bool Ground;
    public bool Jump;
    public float jumpRate = 1f; //จำนวนการกระโดด
    public float nextJumpPress = 0.0f;
    public float fireRate = 0.2f;
    public float nextFireRate = 0.0f;
    private Rigidbody2D rigidBody2D;
    private Physics2D physic2D;
    Animator animator;
    public int healthbar = 100; //เลือด
    public TMP_Text healthText;
    public Slider sliderHp;

    // public static Vector2 lastCheckPointPos = new Vector2(-3,0);
    // public GameObject[] playerPrefabs;
    //  ;

    // private void Awake()
    // {
    //     PlayerPrefs.GetInt("SeletedCharacter",0);
    //     Instantiate(playerPrefabs[characterIndex], lastCheckPointPos,Quaternion.identity);
    // }

    // private int score;
    // public TMP_Text scoreUI;
    

    // Start is called before the first frame update

    // public Coin cm;
    // public static int numberOfCoins;
    // public TMP_Text coinsText;

    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        sliderHp.maxValue = healthbar;
        sliderHp.value = healthbar;
        asource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "HEALTH : " + healthbar;
        if(healthbar <= 0){
            healthbar = 0;
            animator.SetTrigger("Dead");
            SceneManager.LoadScene("GameOver");
        }

        sliderHp.value = healthbar;
        
        // if(other.gameObject.tag == "Enemy"){
        //     TakeDamage(10);
        // }

       //coinsText.text = "Point : " + numberOfCoins;
        
        // healthText.text = "HEALTH : " + healthbar;
        // if(healthbar <= 0)
        // {
        // healthbar = 0;
        // animator.SetTrigger("Death");

        // }
        
        // AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        // if(state.IsName("Jump")){
        //     asource.clip = c2;
        //     if(!asource.isPlaying){
        //         asource.Play();
        //     }
        // }

        // if(state.IsName("Run")){
        //     asource.clip = c1;
        //     if(!asource.isPlaying){
        //         asource.Play();
        //     }
        // }

        // if(state.IsName("Dead")){
        //     asource.clip = c3;
        //     if(!asource.isPlaying){
        //         asource.Play();
        //     }
        // }

        animator.SetBool("Ground", true);
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetButtonDown("Jump")  && Time.time > nextJumpPress)  //&& !Jump
        {
            source1.Play();
            animator.SetBool("Jump", true);
            nextJumpPress = Time.time * jumpRate;
            rigidBody2D.AddForce(jumpSpeed * (Vector2.up * JumpPower));
        }
        else
        {
            animator.SetBool("Jump", false);
        }


        // void OnTriggerEnter2D(Collider2D other)
        // {
        //    if(other.gameObject.tag == "deathzone")
        //    {
        //        healthbar = 0;
        //        //Destroy(other.gameObject);
        //    }
        // }
    }

    public void TakeDamage(int damage)
    {
        healthbar = healthbar - damage;
    }

    void OnTriggerEnter2D (Collider2D other){
        if(other.gameObject.tag == "health"){
            healthbar = healthbar + 50; 
            Destroy(other.gameObject);
            
        }

        if(other.gameObject.tag == "deathzone"){
            healthbar = 0;
            SceneManager.LoadScene("GameOver");
        }
        if(other.gameObject.tag == "Enemy"){
            source2.Play();
            TakeDamage(5);
            //Destroy(other.gameObject);
            //healthbar = healthbar - damage; 
        }

        // if(other.gameObject.CompareTag("Coins"))
        // {
        //     // cm.coinCount++;
        //     score += 1;
        //     scoreUI.text = "Point : " + score.ToString();
        //     Destroy(other.gameObject);
        // }
    }

    // private void OnCollisionEnter2D(Collision2D target){
    //     if(target.gameObject.CompareTag("Ground"))
    //     {
    //         Jump = false;
    //     }
    // }
    // private void OnCollisionExit2D(Collision2D target){
    //     if(target.gameObject.CompareTag("Ground"))
    //     {
    //         Jump = true;
    //     }
    // }

}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;


// public class PlayerContro : MonoBehaviour
// {
//     public AudioClip c1, c2, c3;
//     AudioSource asource;
//     public AudioSource source;
//     public AudioClip clip;
//     public float speed = 4f;
//     public float jumpSpeed = 17f;
//     public float maxSpeed = 15f;
//     public float JumpPower = 25f;
//     public bool grounded;
//     public float jumpRate = 1f;
//     public float nextJumpPress = 0.0f;
//     public float fireRate = 0.2f;
//     public float nextFireRate = 0.0f;
//     private Rigidbody2D rigidBody2D;
//     private Physics2D physics2D;
//     Animator animator;
//     public int healthbar  ;
//     public Text healthText;
//     public GameObject HitArea;
//     public Slider sliderHp;

//     void Start()
//     {
//         rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
//         animator = this.gameObject.GetComponent<Animator>();
//         sliderHp.maxValue = healthbar;
//         sliderHp.value = healthbar;
//         asource = GetComponent<AudioSource>();
//     }

//     void Update()
//     {
//         healthText.text = "HEALTH : " + healthbar;

//         if(healthbar <= 0){
//             healthbar = 0;
//             animator.SetTrigger("Dead");
//             // StartCoroutine(Dead());
//         }

//         sliderHp.value = healthbar;

//         if(Input.GetKey(KeyCode.L)){
//             TakeDamage(5);
//         }

//         animator.SetBool("Grounded",true);
//         animator.SetFloat("Speed",Mathf.Abs(Input.GetAxis("Horizontal")));
//         if(Input.GetAxis("Horizontal") < -0.1f){
//             transform.Translate(Vector2.right * speed * Time.deltaTime);
//             transform.eulerAngles = new Vector2(0,180);
//         }else if(Input.GetAxis("Horizontal") > 0.1f){
//             transform.Translate(Vector2.right * speed * Time.deltaTime);
//             transform.eulerAngles = new Vector2(0,0);
//         }

//         AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
//         if(state.IsName("Jump")){
//             asource.clip = c2;
//             if(!asource.isPlaying){
//                 asource.Play();
//             }
//         }

//         if(state.IsName("Run")){
//             asource.clip = c1;
//             if(!asource.isPlaying){
//                 asource.Play();
//             }
//         }

//         if(state.IsName("Dead")){
//             asource.clip = c3;
//             if(!asource.isPlaying){
//                 asource.Play();
//             }
//         }

//         if(Input.GetButtonDown("Jump") && Time.time > nextJumpPress){
//             animator.SetBool("Jump",true);
//             nextJumpPress = Time.time + jumpRate;
//             rigidBody2D.AddForce(jumpSpeed*(Vector2.up * JumpPower));
//         }else{
//             animator.SetBool("Jump",false);
//         }

//         if(Input.GetKey(KeyCode.P) && Time.time > nextFireRate){
//             source.PlayOneShot(clip);
//             nextFireRate = Time.time + fireRate;
//             animator.SetBool("Attack",true);
//             Attack();
//         }else{
//             animator.SetBool("Attack",false);
//         }

//     }

//     void TakeDamage(int damage){
//         healthbar = healthbar - damage;
//     }

//     public void Attack(){
//         StartCoroutine(DelaySlash());
//         Instantiate(HitArea,transform.position,transform.rotation);
//     }

//     IEnumerator DelaySlash(){
//         yield return new WaitForSeconds(0.3f);
//         Instantiate(HitArea,transform.position,transform.rotation);
//     }
    
//     // // IEnumerable Dead()
//     // // {
//     // //     yield return new WaitForSeconds(2f);
//     // //     healthbar = 100;
//     // //     // PlayerContro.SetInt("SceneIndex", SceneManager.GetActiveScene().buildIndex);
//     // //     SceneManager.LoadScene("Game Over");
//     // }
//     void OnTriggerEnter2D (Collider2D other){
//         if(other.gameObject.tag == "health"){
//             healthbar = healthbar + 50; 
//             Destroy(other.gameObject);
//         }

//         if(other.gameObject.tag == "deadzone"){
//             healthbar = 0;
//         }
//         if(other.gameObject.tag == "enemy"){
//             TakeDamage(5);
//         }

//         if(other.gameObject.CompareTag("Coins"))
//         {
//             Destroy(other.gameObject);
//         }
//     }
// }
