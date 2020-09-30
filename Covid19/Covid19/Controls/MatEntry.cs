using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Covid19.Controls
{
	public class MatEntry : Entry
	{
		public MatEntry()
		{
			this.HeightRequest = 50;
		}
		public static readonly BindableProperty ImageProperty =
			BindableProperty.Create(nameof(Image), typeof(string), typeof(MatEntry), string.Empty);
		public static readonly BindableProperty TrailImageProperty =
			BindableProperty.Create(nameof(TrailImage), typeof(string), typeof(MatEntry), string.Empty);

		public static readonly BindableProperty LineColorProperty =
			BindableProperty.Create(nameof(LineColor), typeof(Xamarin.Forms.Color), typeof(MatEntry), Color.White);

		public static readonly BindableProperty ImageHeightProperty =
			BindableProperty.Create(nameof(ImageHeight), typeof(int), typeof(MatEntry), 40);

		public static readonly BindableProperty ImageWidthProperty =
			BindableProperty.Create(nameof(ImageWidth), typeof(int), typeof(MatEntry), 40);

		public static readonly BindableProperty ImageAlignmentProperty =
			BindableProperty.Create(nameof(ImageAlignment), typeof(ImageAlignment), typeof(MatEntry), ImageAlignment.Left);
	
		 
		public Color LineColor
		{
			get { return (Color)GetValue(LineColorProperty); }
			set { SetValue(LineColorProperty, value); }
		}

		public int ImageWidth
		{
			get { return (int)GetValue(ImageWidthProperty); }
			set { SetValue(ImageWidthProperty, value); }
		}

		public int ImageHeight
		{
			get { return (int)GetValue(ImageHeightProperty); }
			set { SetValue(ImageHeightProperty, value); }
		}

		public string Image
		{
			get { return (string)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}
		public string TrailImage
		{
			get { return (string)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}
		
		public ImageAlignment ImageAlignment
		{
			get { return (ImageAlignment)GetValue(ImageAlignmentProperty); }
			set { SetValue(ImageAlignmentProperty, value); }
		}
	}

	public enum ImageAlignment
	{
		Left,
		Right
	}
}