using Csla.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsUi.Controls
{
    public class ExtendedPropertyInfo : PropertyInfo
    {
        public ExtendedPropertyInfo()
        {
        }

        public static readonly BindableProperty ExtraInfoProperty = BindableProperty.Create(nameof(ExtraInfo), typeof(object), typeof(ExtendedPropertyInfo), null);
        public object ExtraInfo
        {
            get { return GetValue(ExtraInfoProperty); }
            set
            {
                SetValue(ExtraInfoProperty, value);
            }
        }
    }
}
