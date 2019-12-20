﻿using NogginSign.net.Constants;

namespace NogginSign.net
{
    /// <summary>
    /// Container for data to be sent to a sign device.
    /// Packet objects are created by other classes and should not usually be instantiated directly.
    /// </summary>
    internal class Packet
    {
        public Packet(string contents)
        {
            _contents = contents;
        }

        private readonly string _contents;

        /// <summary>
        /// Sign Address (see protocol)
        /// </summary>
        public string Address = "00";

        /// <summary>
        /// Type code (see protocol)
        /// </summary>
        public string Type { get; set; } = "Z";

        public override string ToString()
        {
            return $"{PacketConstants.NUL.Repeat(5)}{PacketConstants.SOH}{Type}{Address}{PacketConstants.STX}{_contents}{PacketConstants.EOT}";
            /*("%s%s%s%s%s%s%s" %
                 (constants.NUL* 5, constants.SOH, self.type,
                  self.address, constants.STX, contents,
                  constants.EOT))*/
        }

    }
}