

## <div dir="rtl">کتابخانه PersianDateTime.Core</div>

<div dir="rtl">
  کتابخانه ای ست جهت کار با تاریخ در برنامه های دات نت که از آن می توان در برنامه های مبتنی بر دات نت Core یا دات نت Standard و یا دات نت معمولی استفاده کرد.
  این کتابخانه شامل یک سری امکانات و متد های الحاقی است که لیست  برخی از آنها را در جدول زیر میتوانید ببینید
</div>

## <div dir="rtl">نصب از طریق NuGet </div>

<div dir="rtl">
برای نصب این کتابخانه میتوانید دستور زیر را در کنسول پاورشل نیوگت اجرا کنید
</div>

<pre><code>PM&gt; Install-Package PersianDateTime.Core
</code></pre>

## <div dir="rtl">نصب از طریق NuGet </div>

عنوان | مثال | خروجی
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDateTime() | 1396/06/13 14:34:03 |
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDateTimeString() | دوشنبه 13 شهریور 1396 ساعت 14:34:03|
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDateString() | دوشنبه 13 شهریور 1396 |
--- | --- | --- |
تبدیل تاریخ میلادی به میلادی | dt.ToDateTimeString() | Monday 4 September 2017 02:36:55 PM |
--- | --- | --- |
تبدیل تاریخ میلادی به میلادی | dt.ToDigitalDateTimeString() |2017/09/4 14:36:55 |
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDigitalDateTimeString() | 1396/06/13 14:36:55 |
--- | --- | --- |
تبدیل تاریخ شمسی به میلادی | dt.ToDateTime() | 9/4/2017 2:36:55 PM |
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDigitalDateTimeString() | 1396/06/13 14:36:55 |
--- | --- | --- |
تبدیل تاریخ میلادی به شمسی | dt.ToPersianDigitalDateString() | 1396/06/13 |
--- | --- | --- |
تبدیل تاریخ میلادی به میلادی | dt.ToDateString() | Monday 4 September 2017 |

# Thanks
[rahmat rezaei](http://www.codeplex.com/site/users/view/rahmatrezaei)


