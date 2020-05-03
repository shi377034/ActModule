using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
namespace ActCanvas
{
    abstract public class ActNode : Node
    {
        public override int maxInConnections { get { return -1; } }
        public override int maxOutConnections { get { return 1; } }

        sealed public override bool canSelfConnect { get { return false; } }
        sealed public override System.Type outConnectionType { get { return typeof(ActConnection); } }
        sealed public override Alignment2x2 commentsAlignment { get { return Alignment2x2.Right; } }
        sealed public override Alignment2x2 iconAlignment { get { return Alignment2x2.Bottom; } }
         protected ActTree ACT {
            get { return (ActTree)graph; }
        }
    }
}