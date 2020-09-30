using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Covid19.Controls;
using Covid19.Droid.CustomRenderer;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Support.V4.Content;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(MatEntry), typeof(MaterilaEntryRenderer))]
namespace Covid19.Droid.CustomRenderer
{
    public class MaterilaEntryRenderer : MaterialEntryRenderer
    {
        Android.Content.Context Context;
        public MaterilaEntryRenderer(Context context) : base(context)
        {
            Context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

            MatEntry MatImage = (MatEntry)e.NewElement;

            base.OnElementChanged(e);

            if (Control != null)
            {
                //Drawable draw =  ContextCompat.GetDrawable(Context, Resource.Drawable.icon_login_password);
                //draw.SetBounds(0, 0, 30, 30);
                //Control.PasswordVisibilityToggleDrawable = draw;
                //Control.PasswordVisibilityToggleEnabled = true;
                //Control.Pa
                
            }
        }
    }
}