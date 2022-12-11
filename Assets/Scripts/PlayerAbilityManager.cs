using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;

public class PlayerAbilityManager : SingletonPersistent<PlayerAbilityManager>
{
    [SerializeField] private GameObject _player;

    private IEnumerator ReturnPlayerSize(float length, float originalValue)
    {
        yield return new WaitForSecondsRealtime(length);
        _player.transform.localScale = new Vector3(originalValue, originalValue, originalValue);
    }

    public void ShrinkPlayer(float shrinkScale, float length)
    {
        //Assume scale on all axis are the same
        float originalValue = _player.transform.localScale.x;
        _player.transform.localScale = new Vector3(shrinkScale, shrinkScale, shrinkScale);
        StartCoroutine(ReturnPlayerSize(length, originalValue));
    }
}
