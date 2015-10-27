using System;
using Android.Content;
using Java.IO;
using Java.Math;
using Android.Text;
using Android.Util;

namespace CommunityCenter.Common
{
	public class DeleteCleanCacheManager
	{
		private const string Tag = "DeleteCleanCache";
		public DeleteCleanCacheManager ()
		{
		}

		/// <summary>
		/// 清除本应用内部缓存(/data/data/com.xxx.xxx/cache) * * 
		/// </summary>
		public static void cleanInternalCache(Context context) {  
			DeleteFilesByDirectory(context.CacheDir);  
		}  
			
		/// <summary>
		/// 除本应用所有数据库(/data/data/com.xxx.xxx/databases) * *
		/// </summary>
		/// <param name="context">Context.</param>
		public static void cleanDatabases(Context context) {   
			DeleteFilesByDirectory(new File("/data/data/"  
				+ context.PackageName + "/databases"));  
		}  
			
		/// <summary>
		/// 清除本应用SharedPreference(/data/data/com.xxx.xxx/shared_prefs) * 
		/// </summary>
		/// <param name="context">Context.</param>
		public static void cleanSharedPreference(Context context) {  
			DeleteFilesByDirectory(new File("/data/data/"  
				+ context.PackageName + "/shared_prefs"));  
		}  


		/// <summary>
		/// 按名字清除本应用数据库 * * 
		/// </summary>
		/// <param name="context">Context.</param>
		/// <param name="dbName">Db name.</param>
		public static void cleanDatabaseByName(Context context, String dbName) {  
			
			context.DeleteDatabase(dbName);  
		}  

 
		/// <summary>
		/// 清除/data/data/com.xxx.xxx/files下的内容 * * 
		/// </summary>
		/// <param name="context">Context.</param>
		public static void cleanFiles(Context context) {  
			DeleteFilesByDirectory(context.FilesDir);  
		}  


		/// <summary>
		/// 清除外部cache下的内容(/mnt/sdcard/android/data/com.xxx.xxx/cache) 
		/// </summary>
		/// <param name="context">Context.</param>
		public static void cleanExternalCache(Context context) {  
			if ( Android.OS.Environment.ExternalStorageState.Equals(  
				Android.OS.Environment.MediaMounted)) {  
				DeleteFilesByDirectory(context.ExternalCacheDir);  
			}  
		}  
 
		/// <summary>
		/// 清除自定义路径下的文件，使用需小心，请不要误删。而且只支持目录下的文件删除 * * 
		/// </summary>
		/// <param name="filePath">File path.</param>
		public static bool CleanCustomCache(string filePath) { 
			var flag = false;
			try{

				DeleteFilesByDirectory(new File(filePath));  
				flag = true;
			}
			catch(Exception ex) {
				flag = false;
				Log.Error (Tag, ex.Message);
			}
			return flag;

		}  
			
		/// <summary>
		/// 删除方法 这里只会删除某个文件夹下的文件，如果传入的directory是个文件，将不做处理 * * 
		/// </summary>
		/// <param name="directory">Directory.</param>
		private static void DeleteFilesByDirectory(File directory)
		{
			if (directory != null && directory.IsDirectory) {
				string[] childs = directory.List ();
				for (int i = 0; i < childs.Length; i++) {
					DeleteFilesByDirectory(new File(directory,childs[i]));
				}
			} else
				directory.Delete ();
		}

		/// <summary>
		/// 获取缓存大小.
		/// </summary>
		/// <returns>The folder size.</returns>
		/// <param name="file">File.</param>
		public static long GetFolderSize(File file)
		{
			long size = 0;
			try{
				File [] fileList = file.ListFiles();
				for(int i=0;i<fileList.Length;i++)
				{
					if(fileList[i].IsDirectory)
						size += GetFolderSize(fileList[i]);
					else
						size += fileList[i].Length();
				}
			}
			catch(Exception ex) {
				Log.Debug (Tag, ex.Message);
			}
			return size;
		}
			
		/// <summary>
		///  删除指定目录下文件及目录 
		/// </summary>
		/// <param name="filePath">File path.</param>
		/// <param name="deleteThisPath">If set to <c>true</c> delete this path.</param>
		public static void DeleteFolderFile(string filePath,bool deleteThisPath)
		{
			try{
				if (!TextUtils.IsEmpty (filePath)) {
					var file = new File (filePath);
					if (file.IsDirectory) {
						File[] files = file.ListFiles ();
						for (int i = 0; i < files.Length; i++) {
							DeleteFolderFile (files [i].AbsolutePath, true);
						}
					}
					if (deleteThisPath) {
						if (file.IsFile)
							file.Delete ();
						else if (file.IsDirectory)
						if (file.ListFiles ().Length == 0)
							file.Delete ();
					}
				}
			}
			catch(Exception ex) {
				Log.Error (Tag, ex.Message);
			}

		}

		/// <summary>
		/// 格式化显示大小
		/// </summary>
		/// <returns>The format size.</returns>
		/// <param name="size">Size.</param>
		public static string GetFormatSize(double size)
		{  
			double kiloByte = size / 1024;  
			if (kiloByte < 1) {  
				return size + "Byte";  
			}
			double megaByte = kiloByte / 1024; 
			if (megaByte < 1) {
				BigDecimal result1 = new BigDecimal(kiloByte.ToString()); 
				return result1.SetScale (2, RoundOptions.HalfUp).ToPlainString()+"KB";
			}
			double gigaByte = megaByte / 1024;  
			if (gigaByte < 1) {  
				BigDecimal result2 = new BigDecimal(megaByte.ToString());  
				return result2.SetScale(2,RoundOptions.HalfUp)  
					.ToPlainString() + "MB";  
			}  

			double teraBytes = gigaByte / 1024;  
			if (teraBytes < 1) {  
				BigDecimal result3 = new BigDecimal(gigaByte.ToString());  
				return result3.SetScale(2, RoundOptions.HalfUp)  
					.ToPlainString() + "GB";  
			}  
			BigDecimal result4 = new BigDecimal(teraBytes);  
			return result4.SetScale(2, RoundOptions.HalfUp).ToPlainString()  
				+ "TB";  
		
		}  


		public static String GetCacheSize(File file) 
		{  
			return GetFormatSize(GetFolderSize(file));  
		}  
	}
}

