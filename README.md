

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
<div dir="rtl">
  <table class="table table-striped">
        <thead class="">
            <tr>
                <th>عنوان</th>
                <th>مثال</th>
                <th>خروجی</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>دریافت تاریخ جاری به صورت شمسی</td>
                <td>PersianDateTime.Now</td>
                <td>1396/06/13 15:32:17</td>
            </tr>
            <tr>
                <td>تبدیل رشته به تاریخ شمسی</td>
                <td>PersianDateTime.Parse("1392/03/02")</td>
                <td>1392/03/02 00:00:00</td>
            </tr>

            <tr>
                <td>دریافت ساعت جاری</td>
                <td>PersianDateTime.Now.TimeOfDay</td>
                <td>15:32:17.4807575</td>
            </tr>
            <tr>
                <td>دریافت روز جاری</td>
                <td>PersianDateTime.Now.DayOfWeek</td>
                <td>2</td>
            </tr>
            <tr>
                <td>افزایش چند روز به تاریخ شمسی جاری</td>
                <td>PersianDateTime.Now.AddDays(15)</td>
                <td>1396/06/28 15:32:17</td>
            </tr>
            <tr>
                <td>عملگر تفریق بین دو تاریخ شمسی</td>
                <td>PersianDateTime.Now.AddDays(15) - PersianDateTime.Now</td>
                <td>14.23:59:59.9999914</td>
            </tr>
            <tr>
                <td>تبدیل تاریخ میلادی به شمسی</td>
                <td>DateTime.Now.ToPersianDateTime()</td>
                <td>1396/06/13 15:32:17</td>
            </tr>


            <tr>
                <td>تبدیل تاریخ میلادی به شمسی</td>
                <td>DateTime.Now.ToPersianDateTimeString()</td>
                <td>دوشنبه 13 شهریور 1396 ساعت 15:32:17</td>
            </tr>


            <tr>
                <td>تبدیل تاریخ میلادی به شمسی</td>
                <td>DateTime.Now.ToPersianDateString()</td>
                <td>دوشنبه 13 شهریور 1396</td>
            </tr>


            <tr>
                <td>تبدیل تاریخ میلادی به شمسی</td>
                <td>DateTime.Now.ToPersianDigitalDateTimeString()</td>
                <td>1396/06/13 15:32:17</td>
            </tr>

            <tr>
                <td>تبدیل تاریخ میلادی به شمسی</td>
                <td>DateTime.Now.ToPersianDigitalDateTimeString()</td>
                <td>1396/06/13 15:32:17</td>
            </tr>

            <tr>
                <td>تبدیل تاریخ شمسی به شمسی</td>
                <td>PersianDateTime.Now.ToPersianDigitalDateString()</td>
                <td>1396/06/13</td>
            </tr>
            <tr>
                <td>تبدیل تاریخ شمسی به میلادی</td>
                <td>PersianDateTime.Now.ToDateTime()</td>
                <td>9/4/2017 3:32:17 PM</td>
            </tr>
            <tr>
                <td>تبدیل تاریخ شمسی به میلادی</td>
                <td>PersianDateTime.Now.ToDateString()</td>
                <td>Monday 4 September 2017</td>
            </tr>


            <tr>
                <td>تبدیل تاریخ میلادی به میلادی</td>
                <td>DateTime.Now.ToDateTimeString()</td>
                <td>Monday 4 September 2017 03:32:17 PM</td>
            </tr>
            <tr>
                <td>تبدیل تاریخ میلادی به میلادی</td>
                <td>DateTime.Now.ToDigitalDateTimeString()</td>
                <td>2017/09/4 15:32:17</td>
            </tr>

        </tbody>
    </table>
    
</div>

# Thanks
[rahmat rezaei](http://www.codeplex.com/site/users/view/rahmatrezaei)


