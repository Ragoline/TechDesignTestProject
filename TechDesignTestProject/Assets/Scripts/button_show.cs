using UnityEngine;
using UnityEngine.UI;

public class button_show : MonoBehaviour
{
    [SerializeField] private Button _sceneButton;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] sounds;

    private void OnMouseDown()
    {
        _audioSource.PlayOneShot(sounds[Random.Range(0, sounds.Length - 1)]);
        _sceneButton.gameObject.SetActive(true);
    }
}
