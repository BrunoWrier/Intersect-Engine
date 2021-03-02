﻿using System;

namespace Intersect.Network.Packets.Client
{

    public class AttackPacket : AbstractTimedPacket
    {

        public AttackPacket(Guid target, bool targetOnFocus)
        {
            Target = target;
            TargetOnFocus = targetOnFocus;
        }

        public Guid Target { get; set; }

        public bool TargetOnFocus { get; set; }

    }

}
