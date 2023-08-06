using System;


 /// <summary>
    /// 
    /// </summary>
    public static class PersianDateTimeExtension
{




        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> یکشنبه 12 شهریور 1396 ساعت 15:16:29 </returns>
        public static string ToPersianDateTimeString(this DateTime dt)
        {
            var pd = new PersianDateTime(dt);
            return pd.ToString("dddd d MMMM yyyy ساعت HH:mm:ss");
        }




        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> یکشنبه 12 شهریور 1396 </returns>
        public static string ToPersianDateString(this DateTime dt)
        {
            var pd = new PersianDateTime(dt);
            return pd.ToString("dddd d MMMM yyyy");
        }



        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> 1396/06/12 15:16:29 </returns>
        public static PersianDateTime ToPersianDateTime(this DateTime dt)
        {
            PersianDateTime persiandate = new PersianDateTime(dt);
            return persiandate;
        }




        /// <summary>
        /// تبدیل تاریخ میلادی به میلادی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> Sunday 3 September 2017 03:16:29 PM </returns>
        public static string ToDateTimeString(this DateTime dt)
        {
            return dt.ToString("dddd d MMMM yyyy hh:mm:ss tt");
        }



        /// <summary>
        /// تبدیل تاریخ میلادی به میلادی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> 2017/09/3 15:16:29 </returns>
        public static string ToDigitalDateTimeString(this DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd H:mm:ss");
        }



        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ میلادی</param>
        /// <returns> 1396/06/12 15:16:29 </returns>
        public static string ToPersianDigitalDateTimeString(this DateTime dt)
        {
            var pd = new PersianDateTime(dt);
            return pd.ToString("yyyy/MM/dd H:mm:ss");
        }






        /// <summary>
        /// تبدیل تاریخ شمسی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ شمسی</param>
        /// <returns> یکشنبه 12 شهریور 1396 </returns>
        public static string ToPersianDateString(this PersianDateTime dt)
        {
            return dt.ToString("dddd d MMMM yyyy");
        }




        /// <summary>
        /// تبدیل تاریخ شمسی به میلادی
        /// </summary>
        /// <param name="dt">تاریخ شمسی</param>
        /// <returns> 9/3/2017 3:16:29 PM </returns>
        public static DateTime ToDateTime(this PersianDateTime dt)
        {
            return dt.ToDateTime();
        }




        /// <summary>
        /// تبدیل تاریخ شمسی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ شمسی</param>
        /// <returns> 1396/06/12 15:16:29 </returns>
        public static string ToPersianDigitalDateTimeString(this PersianDateTime dt)
        {
            return dt.ToString("yyyy/MM/dd H:mm:ss");
        }


        /// <summary>
        /// تبدیل تاریخ شمسی به شمسی
        /// </summary>
        /// <param name="dt">تاریخ شمسی</param>
        /// <returns>1396/06/12</returns>
        public static string ToPersianDigitalDateString(this PersianDateTime dt)
        {
            return dt.ToString("yyyy/MM/dd");
        }



        /// <summary>
        /// تبدیل تاریخ شمسی به میلادی
        /// </summary>
        /// <param name="dt">تاریخ شمسی</param>
        /// <returns>Sunday 3 September 2017 </returns>
        public static string ToDateString(this PersianDateTime dt)
        {
            return dt.ToDateTime().ToString("dddd d MMMM yyyy");
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int ToInteger(this TimeSpan time)
        {
            return int.Parse(time.Hours.ToString() + time.Minutes.ToString().PadLeft(2, '0') + time.Seconds.ToString().PadLeft(2, '0'));
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static short ToShort(this TimeSpan time)
        {
            return short.Parse(time.Hours.ToString() + time.Minutes.ToString().PadLeft(2, '0'));
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToHHMM(this TimeSpan time)
        {
            return time.ToString("hh\\:mm");
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ToHHMMSS(this TimeSpan time)
        {
            return time.ToString("hh\\:mm\\:ss");
        }




    }



