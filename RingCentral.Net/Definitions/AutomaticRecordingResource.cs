namespace RingCentral
{
    public class AutomaticRecordingResource
    {
        /// <summary>
        /// Flag for controling Automatic Call Recording settings
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// Flag for controlling 'Play Call Recording Announcement for Outbound Calls' settings
        /// </summary>
        public bool? outboundCallTones { get; set; }

        /// <summary>
        /// Flag for controlling 'Play periodic tones for outbound calls' settings
        /// </summary>
        public bool? outboundCallAnnouncement { get; set; }

        /// <summary>
        /// Flag for controlling 'Allow mute in auto call recording' settings
        /// </summary>
        public bool? allowMute { get; set; }

        /// <summary>
        /// Total amount of extension that are used in call recordings
        /// </summary>
        public long? extensionCount { get; set; }

        /// <summary>
        /// Retention period of a call recording, the default value is 90 days
        /// </summary>
        public long? retentionPeriod { get; set; }

        /// <summary>
        /// Max number of automatic call recordings per account, the default value is 100 000
        /// </summary>
        public long? maxNumberLimit { get; set; }
    }
}