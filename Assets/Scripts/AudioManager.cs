using UnityEngine;

public class AudioManager : MonoBehaviour
{

   [Header("--------AUDIO SOURCE---------")]
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   [Header("--------AUDIO CLIP---------")]
   public AudioClip background;
   public AudioClip checkpoint;
   public AudioClip wallTouch;

   private void Start()
   {
       musicSource.clip=background;
       musicSource.Play();
   }

   public void PlaySFX(AudioClip clip)
   {
    SFXSource.PlayOneShot(clip);
   }
}