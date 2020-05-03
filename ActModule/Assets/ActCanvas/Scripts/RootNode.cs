using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace ActCanvas
{
    [DoNotList]
    [ProtectedSingleton]
    sealed public class RootNode : ActNode
    {
        public override bool allowAsPrime => true;
        public override int maxInConnections { get { return 0; } }
        public override int maxOutConnections { get { return -1; } }
        protected override Status OnExecute(Component agent, IBlackboard bb)
        {
            return Status.Running;
        }
    }
}