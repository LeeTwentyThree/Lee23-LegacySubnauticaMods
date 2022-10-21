using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class TankViewBottom: TankView
    {
        protected override void InitializeFields()
        {
            _lookHorizontalMin = float.MinValue;
            _lookHorizontalMax = float.MaxValue;
            _lookVerticalMin = -30f;
            _lookVerticalMax = 90f;
        }
    }
}
