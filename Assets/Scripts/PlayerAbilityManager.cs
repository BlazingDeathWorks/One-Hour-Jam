using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;

public class PlayerAbilityManager : SingletonPersistent<PlayerAbilityManager>
{
    [SerializeField] private GameObject _player;
    private const string NO_ENEMY_COLLIDER_LAYER = "Player";

    private IEnumerator ReturnPlayerSize(float length, float originalValue)
    {
        yield return new WaitForSecondsRealtime(length);
        _player.transform.localScale = new Vector3(originalValue, originalValue, originalValue);
    }

    private IEnumerator ReturnPlayerColliderWithEnemy(float length)
    {
        yield return new WaitForSecondsRealtime(length);
        _player.layer = LayerMask.NameToLayer("Default");
    }

    public void ShrinkPlayer(float shrinkScale, float length)
    {
        //Assume scale on all axis are the same
        float originalValue = _player.transform.localScale.x;
        _player.transform.localScale = new Vector3(shrinkScale, shrinkScale, shrinkScale);
        StartCoroutine(ReturnPlayerSize(length, originalValue));
    }

    public void HidePlayerColliderWithEnemy(float length)
    {
        _player.layer = LayerMask.NameToLayer(NO_ENEMY_COLLIDER_LAYER);
        Debug.Log(_player.layer);
        StartCoroutine(ReturnPlayerColliderWithEnemy(length));
    }
}
