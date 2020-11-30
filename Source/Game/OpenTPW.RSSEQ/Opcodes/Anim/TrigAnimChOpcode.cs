﻿namespace OpenTPW.RSSEQ.Opcodes
{
    public class TrigAnimChOpcode : OpcodeHandler
    {
        public override OpcodeID[] OpcodeIds => new[] { OpcodeID.TRIGANIM_CH };

        public override void Invoke(Operand[] args)
        {

        }

        public override int MinArgs => 4;
        public override int MaxArgs => 4;
        public override string Description => "Unknown";

        public override string[] Args => new[] { "unknown", "unknown", "unknown", "unknown" };
    }
}