using System;
using Android.App;
using Android.Runtime;
using Com.Nostra13.Universalimageloader.Utils;
using Java.IO;
using Com.Nostra13.Universalimageloader.Core;
using Com.Nostra13.Universalimageloader.Cache.Disc.Naming;
using Com.Nostra13.Universalimageloader.Cache.Disc.Impl;
using Com.Nostra13.Universalimageloader.Core.Download;
using Com.Nostra13.Universalimageloader.Core.Assist;
using Com.Nostra13.Universalimageloader.Cache.Memory.Impl;
using Java.Lang;
using CN.Jpush.Android.Api;
using Com.Baidu.Mapapi;

namespace CommunityCenter.Common
{
	public class CommunityCenterApplication:Application
	{
		public CommunityCenterApplication ():base()
		{
		}
		protected CommunityCenterApplication (IntPtr javaReference, JniHandleOwnership transfer):base(javaReference,transfer)
		{
			
		}
		public override void OnCreate ()
		{
			base.OnCreate ();
			#region 极光推送相关
			//注册Jpush
			JPushInterface.SetDebugMode (true);
			JPushInterface.Init (ApplicationContext);
			//设置基本样式
			SetNotificationStyleBasic();
			//自定义推送通知栏样式 test
			SetNotificationStyleCustom();
			//设置保留最近5条通知
			JPushInterface.SetLatestNotificationNumber(ApplicationContext,5);
			#endregion

			#region imageloader 使用二级缓存
			//var configuration = ImageLoaderConfiguration.CreateDefault(ApplicationContext);//创建默认的ImageLoader配置参数 

		    //自定义缓存路径
			var cachePath =  Android.OS.Environment.ExternalStorageDirectory.ToString()+"/"+"eldyoungCommCenter/Cache/HeadImage/";
			Java.IO.File file = new Java.IO.File(cachePath);
			if(!file.Exists())
				file.Mkdirs();// 创建文件夹
			File  cacheDir = StorageUtils.GetOwnCacheDirectory(ApplicationContext, cachePath);  //自定义缓存路径
			var configuration = new ImageLoaderConfiguration.Builder(ApplicationContext).MemoryCacheExtraOptions(480,800)
				.ThreadPoolSize(3).ThreadPriority(Thread.NormPriority -2).DenyCacheImageMultipleSizesInMemory()
				.MemoryCache(new UsingFreqLimitedMemoryCache(2*1024*1024)).MemoryCacheSize(2 * 1024 * 1024).DiskCacheSize(50 * 1024 * 1024)
				.DiskCacheFileNameGenerator(new Md5FileNameGenerator()).TasksProcessingOrder(QueueProcessingType.Lifo).DiskCacheFileCount(100)
				.DiskCache(new UnlimitedDiskCache(cacheDir)).DefaultDisplayImageOptions(DisplayImageOptions.CreateSimple()).ImageDownloader(new BaseImageDownloader(ApplicationContext, 5 * 1000, 30 * 1000))
				.Build();
			ImageLoader.Instance.Init(configuration);

			#endregion

			#region 百度地图使用
			SDKInitializer.Initialize(ApplicationContext);
			#endregion
		}

		/// <summary>
		/// Sets the notification style basic.
		/// </summary>
		private void SetNotificationStyleBasic()
		{
			BasicPushNotificationBuilder builder1 = new BasicPushNotificationBuilder(this);
			builder1.StatusBarDrawable =Resource.Drawable.ic_launch;
			builder1.NotificationFlags = (int) NotificationFlags.AutoCancel;  //设置为自动消失
			builder1.NotificationDefaults =(int) NotificationDefaults.All; // 设置为铃声与震动都要
			JPushInterface.SetPushNotificationBuilder((Integer)1,builder1);
		}

		/// <summary>
		/// Sets the notification style custom.
		/// </summary>
		private void SetNotificationStyleCustom()
		{
			CustomPushNotificationBuilder  builder2 = new CustomPushNotificationBuilder(this,Resource.Layout.customer_notitfication_layout,
				Resource.Id.msgIcon,Resource.Id.msgTitle,Resource.Id.msgContent);
			builder2.StatusBarDrawable = Resource.Drawable.ic_launch;      
			// 指定最顶层状态栏小图标
			builder2.LayoutIconDrawable = Resource.Drawable.ic_launch;   
			// 指定下拉状态栏时显示的通知图标
			JPushInterface.SetPushNotificationBuilder((Integer)2, builder2);

		}
	}
}

