namespace PersianDateTime
{
    /// <summary>
    /// Specifies the date and time format
    /// </summary>
    public enum PersianDateTimeFormat
    {
        Date = 0,
        DateTime = 1,
        LongDate = 2,
        LongDateLongTime = 3,
        FullDate = 4,
        FullDateLongTime = 5,
        FullDateFullTime = 6,
        DateShortTime = 7,
        ShortDateShortTime = 8,
        LongDateFullTime = 9
    }

    /// <summary>
    /// Specifies the persian date and time mode to determining the PersianDateTime.Now.
    /// </summary>
    public enum PersianDateTimeMode
    {
        /// <summary>
        /// Using the current time zone.
        /// </summary>
        System,
        /// <summary>
        /// Using the persian time zone.
        /// </summary>
        PersianTimeZoneInfo,
        /// <summary>
        /// Using the UTC date and time with custom daylight saving time.
        /// </summary>
        UtcOffset
    }
}
