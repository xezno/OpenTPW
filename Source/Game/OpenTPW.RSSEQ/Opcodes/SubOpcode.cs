﻿namespace OpenTPW.RSSEQ.Opcodes
{
    public class SubOpcode : OpcodeHandler
    {
        public override OpcodeID[] OpcodeIds => new[] { OpcodeID.SUB };

        public override void Invoke(Operand[] args)
        {
            args[2].Value = args[0].Value - args[1].Value;
        }

        public override int MinArgs => 3;
        public override int MaxArgs => 3;
        public override string Description => "Subtract one value from another.";

        public override string[] Args => new[] { "value / source", "value / source", "dest" };
    }
}
