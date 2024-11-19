using System;
using System.Linq;
using Logic;
using UnityEngine;

namespace Infrastructure
{
    public class GameRunner : MonoBehaviour
    {
        public GameBootstrapper BootstrapperPrefab;
        private void Awake()
        {
            var bootstrapper =
                FindObjectsByType<GameBootstrapper>(FindObjectsSortMode.None).First(); //FindObjectsOfType<GameBootstrapper>();

            if (bootstrapper == null)
                Instantiate(BootstrapperPrefab);
        }
    }
}