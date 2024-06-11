using konsnos.SimpleTabSystem;
using UnityEngine;

namespace com.konsnos.SimpleTabSystem
{
    public class SampleScene : MonoBehaviour
    {
        public void TabChanged(TabSystem tabSystem)
        {
            Debug.Log("Tab changed to " + tabSystem.CurrentTab);
        }
    }
}
