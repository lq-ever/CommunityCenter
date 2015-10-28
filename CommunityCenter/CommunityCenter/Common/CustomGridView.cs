using System;

using Android.Content;
using Android.Util;

using Android.Widget;
using Android.Runtime;

namespace CommunityCenter.Common
{
	
	public class CustomGridView:GridView
	{
		protected CustomGridView (IntPtr javaReference, JniHandleOwnership transfer):base(javaReference,transfer)
		{
			
		}
		public CustomGridView(Context context):base(context)
		{
		}

		public CustomGridView (Context context, IAttributeSet attrs):base(context,attrs)
		{
		}

		public CustomGridView (Context context, IAttributeSet attrs, int defStyle):base(context,attrs,defStyle)
		{
		}

		protected override void OnMeasure (int widthMeasureSpec, int heightMeasureSpec)
		{
			int expandSpec = MeasureSpec.MakeMeasureSpec(int.MaxValue >> 2,Android.Views.MeasureSpecMode.AtMost);
			base.OnMeasure (widthMeasureSpec, expandSpec);
		}
			
		protected override void OnDraw (Android.Graphics.Canvas canvas)
		{
			base.OnDraw (canvas);
		}
	}
}

