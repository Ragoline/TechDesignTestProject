using UnityEngine;
using UnityEngine.UI;

public class animation_click : MonoBehaviour
{
    [SerializeField] private Animator _anotherAnimator;
    [SerializeField] private Text _orHereText;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] sounds;

    private void OnMouseDown()
    {
        _audioSource.PlayOneShot(sounds[Random.Range(0, sounds.Length - 1)]);
        Animator animator = GetComponent<Animator>();
        animator.SetBool("launch", true);
        animator.Play("walk_animation");
        animator.Play("idle_animation");
        animator.SetBool("launch", false);
        _anotherAnimator.SetBool("launch", true);
        _anotherAnimator.Play("walk_animation");
        _anotherAnimator.Play("idle_animation");
        _anotherAnimator.SetBool("launch", false);
        _orHereText.gameObject.SetActive(true);
    }
}
