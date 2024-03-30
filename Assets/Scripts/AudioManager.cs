using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Background Music")]
    [SerializeField] private AudioClip mainMenuMusic; 
    [SerializeField] private AudioClip levelSelectionMusic;

    [Header("Sound Effects")]
    [SerializeField] private AudioClip checkpointSound;
    [SerializeField] private AudioClip failedSound;
    [SerializeField] private AudioClip inspectseatSound;
    [SerializeField] private AudioClip opendoorSound;

    private static AudioManager instance;

    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("AudioManager");
                    instance = obj.AddComponent<AudioManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe from the sceneLoaded event

    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from the sceneLoaded event
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Determine which background music to play based on the scene name
        if (scene.name == "MainMenu" || scene.name == "About")
        {
            if (!musicSource.isPlaying || musicSource.clip != mainMenuMusic)
            {
                PlayBackgroundMusic(mainMenuMusic);
            }
        }
        else if (scene.name == "Level Modules")
        {
            musicSource.Stop();
            if (!musicSource.isPlaying || musicSource.clip != levelSelectionMusic)
            {
                PlayBackgroundMusic(levelSelectionMusic);
            }
        } //la pa code for when the music should stop pag pasok ng lvl 1
    }

    private void PlayBackgroundMusic(AudioClip clip)
    {
        if (clip != null)
        {
            musicSource.clip = clip;
            musicSource.loop = true;
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("Background music clip is null.");
        }
    }

    public void PlayCheckpointSound()
    {
        PlaySound(checkpointSound, sfxSource);
    }

    public void PlayFailedSound()
    {
        PlaySound(failedSound, sfxSource);
    }

    private void PlaySound(AudioClip clip, AudioSource source)
    {
        if (clip != null && source != null)
        {
            source.PlayOneShot(clip);
        }
    }
}
