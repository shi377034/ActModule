using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;
using System;

namespace ActCanvas
{
    public class ActTree : Graph
    {
        public override Type baseNodeType => typeof(ActNode);

        public override bool requiresAgent => true;

        public override bool requiresPrimeNode => true;

        public override bool isTree => true;

        public override bool allowBlackboardOverrides => true;

        public override bool canAcceptVariableDrops => false;
        public ActNode currentNode { get; private set; }
    }
}

