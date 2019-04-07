﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("s_memo")]
    public class SMemoPacket : IPacket
    {
        [PacketIndex(0)]
        public SMemoType Type { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}