

## <div dir="rtl">کتابخانه PersianDateTime.Core</div>

<div dir="rtl">
  کتابخانه ای ست جهت کار با تاریخ در برنامه های دات نت که از آن می توان در برنامه های مبتنی بر دات نت Core یا دات نت Standard و یا دات نت معمولی استفاده کرد.
  این کتابخانه شامل یک سری امکانات و متد های الحاقی است که لیست  برخی از آنها را در جدول زیر میتوانید ببینید
</div>

## <div dir="rtl">نصب از طریق NuGet </div>

<div dir="rtl">
برای نصب این کتابخانه میتوانید دستور زیر را در کنسول پاورشل نیوگت اجرا کنید
</div>

<pre><code>PM&gt; Install-Package PersianDateTime.Core</code></pre>

## <div dir="rtl">جدول امکانات </div>
خروجی   | مثال  | عنوان
------------- | -------------- | -------------
1396/06/13 15:32:17 | PersianDateTime.Now | دریافت تاریخ جاری به صورت شمسی
1392/03/02 00:00:00 | PersianDateTime.Parse("1392/03/02") | تبدیل رشته به تاریخ شمسی	 
15:32:17.4807575 | PersianDateTime.Now.TimeOfDay | دریافت ساعت جاری	 
2 | PersianDateTime.Now.DayOfWeek | دریافت روز جاری	 
1396/06/28 15:32:17   | PersianDateTime.Now.AddDays(15)	    | افزایش چند روز به تاریخ شمسی جاری	 
14.23:59:59.9999914   | PersianDateTime.Now.AddDays(15) - PersianDateTime.Now	    | عملگر تفریق بین دو تاریخ شمسی	 
1396/06/13 15:32:17   | DateTime.Now.ToPersianDateTime()	    | تبدیل تاریخ میلادی به شمسی	 
دوشنبه 13 شهریور 1396 ساعت 15:32:17   | DateTime.Now.ToPersianDateTimeString()	    | تبدیل تاریخ میلادی به شمسی	 
دوشنبه 13 شهریور 1396   | DateTime.Now.ToPersianDateString()	    | تبدیل تاریخ میلادی به شمسی	 
1396/06/13 15:32:17   | DateTime.Now.ToPersianDigitalDateTimeString()	    | تبدیل تاریخ میلادی به شمسی	 
1396/06/13   | PersianDateTime.Now.ToPersianDigitalDateString()	    | تبدیل تاریخ شمسی به شمسی	 
9/4/2017 3:32:17 PM   | PersianDateTime.Now.ToDateTime()	    | تبدیل تاریخ شمسی به میلادی	 
Monday 4 September 2017   | PersianDateTime.Now.ToDateString()	    | تبدیل تاریخ شمسی به میلادی	 
Monday 4 September 2017 03:32:17 PM   | DateTime.Now.ToDateTimeString()	    | تبدیل تاریخ میلادی به میلادی	 
2017/09/4 15:32:17   | DateTime.Now.ToDigitalDateTimeString()	    | تبدیل تاریخ میلادی به میلادی	 


# Thanks
[rahmat rezaei](http://www.codeplex.com/site/users/view/rahmatrezaei)


