using UnityEngine;

namespace konsnos.SimpleTabSystem
{
    /// <summary>
    /// Manages the persistence of the current tab in <see cref="TabSystem"/> using PlayerPrefs.
    /// The persistence key is created by combining a constant prefix and the GameObject name.
    /// Ensure the GameObject name is unique across the scene.
    /// </summary>
    public class TabSystemMemory : MonoBehaviour
    {
        private TabSystem _tabSystem;
        private const string PrefKeyPrefix = "SimpleTabSystem_";
        private string _persistentKey;

        private void Awake()
        {
            _tabSystem = GetComponent<TabSystem>();

            _persistentKey = PrefKeyPrefix + gameObject.name;
        }

        private void Start()
        {
            SetTabFromMemory();
            _tabSystem.onTabChanged.AddListener(TabChanged);
        }

        private void OnDestroy()
        {
            _tabSystem.onTabChanged.RemoveListener(TabChanged);
        }

        private void SetTabFromMemory()
        {
            var savedTabIndex = PlayerPrefs.GetInt(_persistentKey, -1);
            if (savedTabIndex == -1) return;
            _tabSystem.ShowTab(savedTabIndex);
        }

        private void TabChanged(int tabIndex)
        {
            PlayerPrefs.SetInt(_persistentKey, tabIndex);
        }
    }
}