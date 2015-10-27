using System;
using Android.Widget;
using Android.Views;
using Android.Graphics;
using Android.Runtime;
using Android.Content;
using Android.Util;
using Android.Views.Animations;

namespace CommunityCenter.Common
{
	public class CustomScrollView:ScrollView
	{
		// y方向上当前触摸点的前一次记录位置
		private int previousY = 0;
		// y方向上的触摸点的起始记录位置
		private int startY = 0;
		// y方向上的触摸点当前记录位置
		private int currentY = 0;
		// y方向上两次移动间移动的相对距离
		private int deltaY = 0;

		// 第一个子视图
		private View childView;

		// 用于记录childView的初始位置
		private Rect topRect = new Rect();
		protected CustomScrollView (IntPtr javaReference, JniHandleOwnership transfer):base(javaReference,transfer)
		{
		}

		public CustomScrollView(Context context) :base(context){

		}

		public CustomScrollView(Context context, IAttributeSet attrs) :base(context,attrs){

		}

		public CustomScrollView(Context context, IAttributeSet attrs, int defStyle):base(context,attrs,defStyle) {

		}

		protected override void OnFinishInflate ()
		{
			if (ChildCount > 0) {
				childView = GetChildAt(0);
			}
			base.OnFinishInflate ();
		}
		public override bool DispatchTouchEvent (MotionEvent e)
		{
			if (null == childView) {
				return base.DispatchTouchEvent(e);
			}

			switch (e.Action) {

			case MotionEventActions.Down:
				startY = (int) e.GetY();
				previousY = startY;
				break;
			case  MotionEventActions.Move:
				currentY = (int) e.GetY();
				deltaY = previousY - currentY;
				previousY = currentY;

				if (0 == ScrollY|| childView.MeasuredHeight- Height <= ScrollY) {
					// 记录childView的初始位置
					if (topRect.IsEmpty) {
						topRect.Set(childView.Left, childView.Top,
							childView.Right, childView.Bottom);
					}

					// 更新childView的位置
					childView.Layout(childView.Left, childView.Top
						- deltaY / 3, childView.Right,
						childView.Bottom - deltaY / 3);
				}
				break;
			case MotionEventActions.Up:
				if (!topRect.IsEmpty) {
					upDownMoveAnimation();
					// 子控件回到初始位置
					childView.Layout(topRect.Left, topRect.Top, topRect.Right,
						topRect.Bottom);
				}

				startY = 0;
				currentY = 0;
				topRect.SetEmpty();
				break;
			default:
				break;
			}
			return base.DispatchTouchEvent (e);
		}
		// 初始化上下回弹的动画效果
		private void upDownMoveAnimation() {
			TranslateAnimation animation = new TranslateAnimation(0.0f, 0.0f,
				childView.Top, topRect.Top);
			animation.Duration=300;
			animation.Interpolator = new AccelerateInterpolator ();
			childView.Animation =animation;
		}
	}
}

