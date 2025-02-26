﻿namespace Supercell.Laser.Logic.Message.Team
{
    public class TeamCreateMessage : GameMessage
    {
        public int EventSlot;
        public int TeamType;

        public bool UnkBoolean;
        public long UnkLong;
        public int UnkVInt;
        public int UnkGlobalId;

        public long UnkLogicLong;

        public override void Decode()
        {
            UnkLogicLong = Stream.ReadLong();
            TeamType = Stream.ReadVInt();
            EventSlot = Stream.ReadVInt();
            UnkVInt = Stream.ReadVInt();

            //Console.WriteLine($"Unk2: {EventSlot}, TeamType: {TeamType}, LogicLong: {UnkLogicLong}");
        }

        public override int GetMessageType()
        {
            return 12541;
        }

        public override int GetServiceNodeType()
        {
            return 9;
        }
    }
}
