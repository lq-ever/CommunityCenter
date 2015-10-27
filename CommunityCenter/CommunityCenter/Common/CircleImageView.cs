using System;
using Android.Widget;
using Android.Graphics;
using Android.Runtime;
using Android.Content;
using Android.Util;
using Android.Content.Res;
using Java.Lang;
using Android.Graphics.Drawables;


namespace CommunityCenter.Common
{
	public class CircleImageView:ImageView
	{
		private static readonly ScaleType SCALE_TYPE = ScaleType.CenterCrop;

		private static readonly Bitmap.Config BITMAP_CONFIG = Bitmap.Config.Argb8888;
		private static readonly int COLORDRAWABLE_DIMENSION = 2;

		private static readonly int DEFAULT_BORDER_WIDTH = 0;
		//		private static readonly int DEFAULT_BORDER_COLOR = Color.Black;
		//
		//		private static readonly int DEFAULT_FILL_COLOR = Color.Transparent;
		private static readonly int DEFAULT_BORDER_COLOR = Resource.Color.white;

		private static readonly int DEFAULT_FILL_COLOR = Resource.Color.transparent;

		private static readonly bool DEFAULT_BORDER_OVERLAY = false;

		private readonly RectF mDrawableRect = new RectF();
		private readonly RectF mBorderRect = new RectF();

		private readonly Matrix mShaderMatrix = new Matrix();
		private readonly Paint mBitmapPaint = new Paint();
		private readonly Paint mBorderPaint = new Paint();
		private readonly Paint mFillPaint = new Paint();

		private int mBorderColor = DEFAULT_BORDER_COLOR;
		private int mBorderWidth = DEFAULT_BORDER_WIDTH;
		private int mFillColor = DEFAULT_FILL_COLOR;

		private Bitmap mBitmap;
		private BitmapShader mBitmapShader;
		private int mBitmapWidth;
		private int mBitmapHeight;

		private float mDrawableRadius;
		private float mBorderRadius;
		private ColorFilter mColorFilter;

		private bool mReady;
		private bool mSetupPending;
		private bool mBorderOverlay;

		protected CircleImageView (IntPtr javaReference, JniHandleOwnership transfer):base(javaReference,transfer)
		{
		}
		public CircleImageView (Context context):base(context)
		{
			init();
		}

		public  CircleImageView (Context context, IAttributeSet attrs):this(context, attrs, 0)
		{

		}
		public CircleImageView(Context context, IAttributeSet attrs, int defStyle):base(context,attrs,defStyle) {



			TypedArray a = context.ObtainStyledAttributes(attrs, Resource.Styleable.CircleImageView, defStyle, 0);

			mBorderWidth = a.GetDimensionPixelSize(Resource.Styleable.CircleImageView_civ_border_width,DEFAULT_BORDER_WIDTH);
			mBorderColor = a.GetColor(Resource.Styleable.CircleImageView_civ_border_overlay, DEFAULT_BORDER_COLOR);//使用这个不报错
			mBorderOverlay = a.GetBoolean(Resource.Styleable.CircleImageView_civ_border_overlay, DEFAULT_BORDER_OVERLAY);
			mFillColor = a.GetColor(Resource.Styleable.CircleImageView_civ_border_overlay, DEFAULT_FILL_COLOR);//使用这个不报错
			a.Recycle ();
			init ();
		}
		private void init() {
			base.SetScaleType(SCALE_TYPE);
			mReady = true;

			if (mSetupPending) {
				setup();
				mSetupPending = false;
			}
		}

		public override ScaleType GetScaleType ()
		{
			return SCALE_TYPE;
		}

		public override void SetScaleType (ScaleType scaleType)
		{
			if (scaleType != SCALE_TYPE) {
				throw new IllegalArgumentException(string.Format("ScaleType %s not supported.", scaleType));
			}
		}

		public override void SetAdjustViewBounds (bool adjustViewBounds)
		{
			if (adjustViewBounds) {
				throw new IllegalArgumentException("adjustViewBounds not supported.");
			}
		}


		protected override void OnDraw (Canvas canvas)
		{

			if (mBitmap == null) {
				return;
			}

			if (mFillColor != Color.Transparent) {
				canvas.DrawCircle(Width/ 2.0f, Height/ 2.0f, mDrawableRadius, mFillPaint);
			}
			canvas.DrawCircle(Width / 2.0f, Height / 2.0f, mDrawableRadius, mBitmapPaint);
			if (mBorderWidth != 0) {
				canvas.DrawCircle(Width/ 2.0f, Height / 2.0f, mBorderRadius, mBorderPaint);
			}
		}



		protected override void OnSizeChanged (int w, int h, int oldw, int oldh)
		{
			base.OnSizeChanged (w, h, oldw, oldh);
			setup();
		}

		public int getBorderColor() {
			return mBorderColor;
		}

		public void setBorderColor(int borderColor) {
			if (borderColor == mBorderColor) {
				return;
			}

			mBorderColor = borderColor;
			mBorderPaint.Color= Context.Resources.GetColor(mBorderColor);
			Invalidate ();
		}


		public void setBorderColorResource(int borderColorRes) {
			//setBorderColor(getContext().getResources().getColor(borderColorRes));
			setBorderColor(Context.Resources.GetColor(borderColorRes));
		}

		public int getFillColor() {
			return mFillColor;
		}

		public void setFillColor(int fillColor) {
			if (fillColor == mFillColor) {
				return;
			}

			mFillColor = fillColor;
			mFillPaint.Color =Context.Resources.GetColor(fillColor);
			Invalidate();
		}


		public int getBorderWidth() {
			return mBorderWidth;
		}

		public void setBorderWidth(int borderWidth) {
			if (borderWidth == mBorderWidth) {
				return;
			}

			mBorderWidth = borderWidth;
			setup();
		}

		public bool isBorderOverlay() {
			return mBorderOverlay;
		}

		public void setBorderOverlay(bool borderOverlay) {
			if (borderOverlay == mBorderOverlay) {
				return;
			}

			mBorderOverlay = borderOverlay;
			setup();
		}

		public override void SetImageBitmap (Bitmap bm)
		{
			base.SetImageBitmap (bm);
			mBitmap = bm;
			setup();
		}

		public override void SetImageDrawable (Android.Graphics.Drawables.Drawable drawable)
		{
			base.SetImageDrawable (drawable);
			mBitmap = getBitmapFromDrawable(drawable);

			setup();
		}

		public override void SetImageResource (int resId)
		{
			base.SetImageResource (resId);
			mBitmap = getBitmapFromDrawable(Drawable);
			setup();
		}

		public override void SetImageURI (Android.Net.Uri uri)
		{
			base.SetImageURI (uri);
			mBitmap = uri != null ? getBitmapFromDrawable(Drawable) : null;
			setup();
		}

		public override void SetColorFilter (ColorFilter cf)
		{
			base.SetColorFilter (cf);
			if (cf == mColorFilter) {
				return;
			}

			mColorFilter = cf;
			mBitmapPaint.SetColorFilter(mColorFilter);
			Invalidate();
		}

		private Bitmap getBitmapFromDrawable(Drawable drawable) {
			if (drawable == null) {
				return null;
			}

			if (drawable is BitmapDrawable) {
				return ((BitmapDrawable) drawable).Bitmap;
			}

			try {
				Bitmap bitmap;

				if (drawable is ColorDrawable) {
					bitmap = Bitmap.CreateBitmap(COLORDRAWABLE_DIMENSION, COLORDRAWABLE_DIMENSION, BITMAP_CONFIG);
				} else {
					bitmap = Bitmap.CreateBitmap(drawable.IntrinsicWidth, drawable.IntrinsicHeight, BITMAP_CONFIG);
				}

				Canvas canvas = new Canvas(bitmap);
				drawable.SetBounds(0,0,canvas.Width,canvas.Height);
				drawable.Draw(canvas);
				return bitmap;
			} catch (OutOfMemoryError e) {
				return null;
			}
		}

		private void setup() {
			if (!mReady) {
				mSetupPending = true;
				return;
			}

			if (mBitmap == null) {
				return;
			}

			mBitmapShader = new BitmapShader(mBitmap, Shader.TileMode.Clamp, Shader.TileMode.Clamp);

			mBitmapPaint.AntiAlias = true;
			mBitmapPaint.SetShader(mBitmapShader);

			mBorderPaint.SetStyle (Paint.Style.Stroke);
			mBorderPaint.AntiAlias = true;
			//bug ,报错
			var packageName = Context.Resources.GetString(Resource.String.app_name);
			mBorderPaint.Color = Context.Resources.GetColor(mBorderColor); 


			mBorderPaint.StrokeWidth = mBorderWidth;

			mFillPaint.SetStyle(Paint.Style.Fill);
			mFillPaint.AntiAlias=true;
			mFillPaint.Color =  Context.Resources.GetColor(mFillColor);

			mBitmapHeight = mBitmap.Height;
			mBitmapWidth = mBitmap.Width;

			mBorderRect.Set(0, 0, Width, Height);
			mBorderRadius = Java.Lang.Math.Min((mBorderRect.Height()- mBorderWidth) / 2, (mBorderRect.Width() - mBorderWidth) / 2);
			mDrawableRect.Set(mBorderRect);

			if (!mBorderOverlay) {
				mDrawableRect.Inset(mBorderWidth, mBorderWidth);
			}

			mDrawableRadius = Java.Lang.Math.Min(mDrawableRect.Height() / 2, mDrawableRect.Width() / 2);

			updateShaderMatrix();
			Invalidate ();
		}
		private void updateShaderMatrix() {
			float scale;
			float dx = 0;
			float dy = 0;

			mShaderMatrix.Set(null);

			if (mBitmapWidth * mDrawableRect.Height() > mDrawableRect.Width() * mBitmapHeight) {
				scale = mDrawableRect.Height() / (float) mBitmapHeight;
				dx = (mDrawableRect.Width() - mBitmapWidth * scale) * 0.5f;
			} else {
				scale = mDrawableRect.Width() / (float) mBitmapWidth;
				dy = (mDrawableRect.Height() - mBitmapHeight * scale) * 0.5f;
			}

			mShaderMatrix.SetScale(scale, scale);
			mShaderMatrix.PostTranslate((int) (dx + 0.5f) + mBorderWidth, (int) (dy + 0.5f) + mBorderWidth);

			mBitmapShader.SetLocalMatrix(mShaderMatrix);
		}


	}
}

